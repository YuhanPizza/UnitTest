using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
	public class TestedFunction
	{
		public string ReturnsUnicornIfZero(int num)
		{
			return (num == 0 ? "Unicorn" : "Potato"); //returns unicorn or zero depending of num value
		}
	}
}