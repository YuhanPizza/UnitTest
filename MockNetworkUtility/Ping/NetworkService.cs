using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MockNetworkUtility.Ping
{
	public class NetworkService
	{
		//search DNS(); 
		//BuildPacket();
		//return mockping;
		public string SendPing() => "Success: Ping Sent!";
		public int PingTimeOut(int a, int b) => a + b;
		public DateTime LastPingDate() => DateTime.Now;
		//from ping library
		public PingOptions GetPingOptions() => new PingOptions()
		{
			DontFragment = true,
			Ttl = 1
		};
		public IEnumerable<PingOptions> MostRecentPings()
		{
			IEnumerable<PingOptions> pingOptions = new PingOptions[]
			{
				new PingOptions
				{
					DontFragment = true,
					Ttl = 1,
				},
				new PingOptions
				{
					DontFragment = true,
					Ttl = 1,
				},
				new PingOptions
				{
					DontFragment = true,
					Ttl = 1,
				},

			};
			return pingOptions;
		}


	}
}