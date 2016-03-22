using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrap
{
    using FluentAssertions;

    [TestClass]
    public class WordWrapTests
    {
        [TestMethod]
        public void Given_A_String_Without_Spaces_WordWrap_Should_Return_Same_String()
        {
            var result = WordWrapString("hello", 8);

            result.Should().Be("hello");
        }

        private object WordWrapString(string text, int width)
        {
            return text;
        }
    }
}
