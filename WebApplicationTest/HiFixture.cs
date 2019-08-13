using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WebApplication1.Controllers;
using FluentAssertions;

namespace WebApplicationTest
{
    public class HiFixture
    {
        [Fact]
        public void Check_Response_of_Hi_for_hi()
        {
            HiController hc = new HiController();
            string result = hc.Get("Hi");
            result.Should().Be("Hello");
        }
        [Fact]
        public void Check_Response_of_Hello_for_other_than_hello()
        {
            HiController hc = new HiController();
            string result = hc.Get("Hello");
            result.Should().Be("Say Hi..");
        }
    }
}
