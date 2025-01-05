using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class CurrencyServer
{
    private static Dictionary<(string, string), double> exchangeRates = new Dictionary<(string, string), double>
    {
        { ("USD", "EURO"), 0.85 },
        { ("EURO", "USD"), 1.18 },
        { ("USD", "GBP"), 0.75 },
        { ("GBP", "USD"), 1.33 },
        { ("EURO", "GBP"), 0.88 },
        { ("GBP", "EURO"), 1.14 }
    };

    private static void LogConnection(string clientAddress, string request, string response, string connectTime, string disconnectTime)
    {
        string logMessage = $"Client {clientAddress} connected at {connectTime}.\n" +
                            $"Request: {request}\n" +
                            $"Response: {response}\n" +
                            $"Disconnected at {disconnectTime}.\n\n";
        System.IO.File.AppendAllText("connection_log.txt", logMessage);
    }

    private static void HandleClient(TcpClient client)
    {
        string connectTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string clientAddress = client.Client.RemoteEndPoint.ToString();

        using (var stream = client.GetStream())
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break; 

                    string request = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    string[] currencies = request.Split(' ');

                    string response = "Невідомий запит";
                    if (currencies.Length == 2)
                    {
                        string currencyFrom = currencies[0].ToUpper();
                        string currencyTo = currencies[1].ToUpper();

                        if (exchangeRates.ContainsKey((currencyFrom, currencyTo)))
                        {
                            response = $"Курс {currencyFrom} до {currencyTo}: {exchangeRates[(currencyFrom, currencyTo)]}";
                        }
                        else
                        {
                            response = $"Курс для {currencyFrom} -> {currencyTo} не знайдений.";
                        }
                    }

                    byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                    stream.Write(responseBytes, 0, responseBytes.Length);
                }
            }
            finally
            {
                string disconnectTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                LogConnection(clientAddress, connectTime, client.Client.RemoteEndPoint.ToString(), disconnectTime);
                client.Close();
            }
        }
    }

    public static void Start(string ipAddress, int port)
    {
        var server = new TcpListener(IPAddress.Parse(ipAddress), port);
        server.Start();
        Console.WriteLine("Сервер запущено. Очікуємо з'єднання...");

        while (true)
        {
            var client = server.AcceptTcpClient();
            Console.WriteLine("Клієнт підключився.");

            Thread clientThread = new Thread(() => HandleClient(client));
            clientThread.Start();
        }
    }

    public static void Main(string[] args)
    {
        Start("127.0.0.1", 8888);
    }
}
