using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace Porter
{
    /// <summary>
    /// Some useful stuff.
    /// </summary>
    class Utils
    {
        /// <summary>
        /// Check if port is in use
        /// </summary>
        /// <param name="port">port number</param>
        /// <returns>true if free, false if used</returns>
        public static bool portCheck(int port)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,ProtocolType.Tcp);
            try
            {
                socket.Bind(new IPEndPoint(IPAddress.Any, port));
                socket.Listen(5);
                return true;
            }
            catch { return false; }
            finally { if (socket != null) socket.Close(); }
        }
    }
}
