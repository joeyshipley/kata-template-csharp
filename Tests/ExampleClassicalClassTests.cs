using FluentAssertions;
using Kata.App.ExampleClasses;
using Kata.Tests.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleClassicalClassTests
{
    [TestClass]
    public class When_asking_for_a_message_that_had_no_message_set
        : ClassicalTestBase<ClassA>
    {
        string _result;

        public override void Arrange() {}

        public override void Act() 
        {
            _result = SUT.Fetch();
        }

        [TestMethod]
        public void It_does_not_return_a_message()
        {
            _result.Should().BeNull();
        }
    }

    [TestClass]
    public class When_asking_for_a_message_that_had_previously_been_set
        : ClassicalTestBase<ClassA>
    {
        string _result;

        public override void Arrange() 
        {
            SUT.Store("rawr");
        }

        public override void Act() 
        {
            _result = SUT.Fetch();
        }

        [TestMethod]
        public void It_returns_the_message_that_was_set()
        {
            _result.Should().Be("rawr");
        }
    }
}
