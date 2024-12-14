using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class Server
{
    private const int Port = 5000;

    static void Main()
    {
        TcpListener listener = new TcpListener(IPAddress.Any, Port);
        listener.Start();
        Console.WriteLine("Server is running...");

        while (true)
        {
            try
            {
                TcpClient client = listener.AcceptTcpClient();
                Thread clientThread = new Thread(() => HandleClient(client));
                clientThread.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[256];
        int bytesRead;

        try
        {
            bytesRead = stream.Read(buffer, 0, buffer.Length);
            string clientMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            string clientIp = ((IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

            Console.WriteLine($"Server: Received from {clientIp}: {clientMessage}");

            string response = "Hello, Client!";
            byte[] responseBytes = Encoding.UTF8.GetBytes(response);
            stream.Write(responseBytes, 0, responseBytes.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            client.Close();
        }
    }
}


// Task 2

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class TimeServer
{
    private const int Port = 5000;

    static void Main()
    {
        TcpListener listener = new TcpListener(IPAddress.Any, Port);
        listener.Start();
        Console.WriteLine("Server is running...");

        while (true)
        {
            try
            {
                TcpClient client = listener.AcceptTcpClient();
                HandleClient(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }

    static void HandleClient(TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[256];
        int bytesRead;

        try
        {
            bytesRead = stream.Read(buffer, 0, buffer.Length);
            string clientMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            string response = string.Empty;
            if (clientMessage.ToLower() == "time")
            {
                response = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (clientMessage.ToLower() == "date")
            {
                response = DateTime.Now.ToString("yyyy-MM-dd");
            }
            else
            {
                response = "Invalid request.";
            }

            byte[] responseBytes = Encoding.UTF8.GetBytes(response);
            stream.Write(responseBytes, 0, responseBytes.Length);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            client.Close();
        }
    }
}
