using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
	public static class TestedFunctionTests
	{
		//naming convention - ClassName_MethodName_ExpectedResult
		public static void TestedFunction_ReturnsUnicornIfZero_ReturnString()
		{
			try
			{
				//Arrange - Go get your variables, whatever you need, your classes, your functions
				int rainbow = 0;
				TestedFunction testFunction = new TestedFunction();

				//Act - Execute this function
				string result = testFunction.ReturnsUnicornIfZero(rainbow);

				//Assert - whatever is returned is it what you want?
				Console.WriteLine(result == "Unicorn" ?
					$"Passed: TestFunction.ReturnsUnicornIfZero_ReturnString Result: {result} From : {rainbow}"
					: $"Failed: TestFunction.ReturnsUnicornIfZero_ReturnString Result: {result} From : {rainbow}");

			}
			catch (Exception ex)
			{
				Console.WriteLine("Caught Error: " + ex.ToString());
			}
		}
	}
}