using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace tetrapak
{
    public class Device
    {
        public static string GetIpAddress()
        {
            var addresses = Dns.GetHostAddresses(Dns.GetHostName());
            return addresses.FirstOrDefault(i 
                => i.AddressFamily == AddressFamily.InterNetwork)?.ToString();
        }
    }
}