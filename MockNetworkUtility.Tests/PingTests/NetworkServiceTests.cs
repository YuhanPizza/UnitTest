using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MockNetworkUtility.Ping;
using FluentAssertions;
using FluentAssertions.Extensions;
using System.Net.NetworkInformation;
using MockNetworkUtility.DNS;
using FakeItEasy;

//Tests
namespace MockNetworkUtility.Test.PingTests
{
	public class NetworkServiceTests
	{
		private readonly NetworkService _pingService;
		private readonly IDNS _dNS;
		public NetworkServiceTests()
		{
			//Dependencies
			_dNS = A.Fake<IDNS>(); //FAKE IT EASY MOCK doesnt actually have access to that interface

			//SUT - System Under Test
			_pingService = new NetworkService(_dNS);
		}
		[Fact]
		public void NetworkService_SendPing_ReturnString()
		{
			//Arrange - variables, classes, mocks
			//var pingService = new NetworkService(); Switched with SUT
			A.CallTo(()=> _dNS.SendDNS()).Returns(true); //because we dont have access to that interface we mock it 
			//and controll the return of that call. we set it true
			//Act - actual execution
			var result = _pingService.SendPing();

			//Assert
			//Fluent assertion plugin extension
			//https:\//fluentassertions.com/strings\ -website
			result.Should().NotBeNullOrWhiteSpace();
			result.Should().Be("Success: Ping Sent!");
			result.Should().Contain("Succes", Exactly.Once());
		}

		[Theory] //lets you pass in variables or inline data.
		[InlineData(1, 2, 3)]
		[InlineData(3, 2, 5)]
		public void NetworkService_PingTimeOut_ReturnInt(int a, int b, int expected)
		{
			//Arrange
			//var pingService = new NetworkService(); Switched with SUT

			//Act
			var result = _pingService.PingTimeOut(a, b);

			//Assert
			//https:\//fluentassertions.com/numerictypes/ -website
			result.Should().Be(expected);
			result.Should().BeGreaterThanOrEqualTo(3);
			result.Should().BePositive();
		}

		[Fact]
		public void NetworkService_LastPingDate_ReturnDate()
		{
			//Arrange - variables, classes, mocks
			//var pingService = new NetworkService(); Switched with SUT

			//Act - actual execution
			var result = _pingService.LastPingDate();

			//Assert
			//Fluent assertion plugin extension
			//https:\//fluentassertions.com/datetimespans/ -website
			result.Should().BeAfter(1.January(2010));
			result.Should().BeBefore(1.January(2050));
		}
		[Fact]
		public void NetworkService_GetPingOptions_ReturnObject()
		{
			//Arrange 
			var expected = new PingOptions()
			{
				DontFragment = true,
				Ttl = 1
			};
			//ACT
			var result = _pingService.GetPingOptions();

			//Assert WARNING: Be Careful!
			//comparing strict equality
			//CHECK FOR THE TYPE
			result.Should().BeOfType<PingOptions>();
			//you ned to use strict equality
			result.Should().BeEquivalentTo(expected);
			//comparing value of an object member
			result.Ttl.Should().Be(1);
			result.DontFragment.Should().BeTrue();

		}
		[Fact]
		public void NetworkService_MostRecentPings_ReturnObject()
		{
			//Arrange 
			var expected = new PingOptions()
			{
				DontFragment = true,
				Ttl = 1
			};
			//ACT
			var result = _pingService.MostRecentPings();

			//Assert WARNING: Be Careful!
			//comparing strict equality
			//CHECK FOR THE TYPE
			result.Should().BeOfType<PingOptions[]>(); //we returning an array ([]) of PingOptions
			//for collections contains an equivalent object
			result.Should().ContainEquivalentOf(expected);
			//comparing value of an object member
			result.Should().Contain(x => x.DontFragment == true);
			result.Should().Contain(i => i.Ttl == 1);
		}

	}
}