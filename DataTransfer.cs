using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace San4oClient
{

    public static class DataTransferHandler
    {
        private static string adress = "25.84.145.110";
        private static int port = 25565;
        public static void SendData(string data)
        {
            Byte[] dataByte = Encoding.UTF8.GetBytes(data);
            TcpClient client = new TcpClient(adress, port);
            NetworkStream stream = client.GetStream();
            stream.Write(dataByte, 0, dataByte.Length);

        }
    }
}
