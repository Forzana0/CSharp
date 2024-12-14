using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class MainForm : Form
    {
        private const string ServerAddress = "127.0.0.1";  // Server IP address
        private const int Port = 5000;

        public MainForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = "Hello, Server!";
            SendMessageToServer(message);
        }

        private void SendMessageToServer(string message)
        {
            try
            {
                TcpClient client = new TcpClient(ServerAddress, Port);
                NetworkStream stream = client.GetStream();

                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                stream.Write(messageBytes, 0, messageBytes.Length);

                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                string clientIp = ((System.Net.IPEndPoint)client.Client.RemoteEndPoint).Address.ToString();

                // Display the received message
                MessageBox.Show($"Client: Received from {clientIp}: {response}");

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

// Task 2

using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace TimeDateClient
{
    public partial class MainForm : Form
    {
        private const string ServerAddress = "127.0.0.1";  // Server IP address
        private const int Port = 5000;

        public MainForm()
        {
            InitializeComponent();
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            string request = timeRadioButton.Checked ? "time" : "date";
            SendRequestToServer(request);
        }

        private void SendRequestToServer(string request)
        {
            try
            {
                TcpClient client = new TcpClient(ServerAddress, Port);
                NetworkStream stream = client.GetStream();

                byte[] requestBytes = Encoding.UTF8.GetBytes(request);
                stream.Write(requestBytes, 0, requestBytes.Length);

                byte[] buffer = new byte[256];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // Display the received response
                MessageBox.Show($"Server response: {response}");

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
