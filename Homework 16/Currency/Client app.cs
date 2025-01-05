using System;
using System.Net.Sockets;
using System.Text;

class CurrencyClient
{
    public static void Main(string[] args)
    {
        string serverAddress = "127.0.0.1";
        int serverPort = 8888;

        try
        {
            using (TcpClient client = new TcpClient(serverAddress, serverPort))
            using (NetworkStream stream = client.GetStream())
            {
                Console.WriteLine("Підключено до сервера.");

                while (true)
                {
                    Console.WriteLine("Введіть запит (наприклад, USD EURO):");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                    {
                        break;
                    }

                    byte[] requestBytes = Encoding.UTF8.GetBytes(input);
                    stream.Write(requestBytes, 0, requestBytes.Length);

                    byte[] responseBytes = new byte[1024];
                    int bytesRead = stream.Read(responseBytes, 0, responseBytes.Length);
                    string response = Encoding.UTF8.GetString(responseBytes, 0, bytesRead);

                    Console.WriteLine("Відповідь сервера: " + response);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}
