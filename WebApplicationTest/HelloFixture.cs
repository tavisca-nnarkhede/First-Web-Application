using System;
using Xunit;
using WebApplication1.Controllers;
using FluentAssertions;
namespace WebApplicationTest
{
    public class HelloFixture
    {
        [Fact]
        public void Check_Response_of_Hello_for_hello()
        {
            HelloController hc = new HelloController();
            string result = hc.Get("Hello");
            result.Should().Be("Hi");
        }
        [Fact]
        public void Check_Response_of_Hello_for_other_than_hello()
        {
            HelloController hc = new HelloController();
            string result = hc.Get("Hii");
            result.Should().Be("Say Hello...");
        }
    }
}
