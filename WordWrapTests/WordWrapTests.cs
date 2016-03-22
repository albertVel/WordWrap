using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordWrapTestsNamespace
{
    using FluentAssertions;

    using WordWrapNamespace;

    [TestClass]
    public class WordWrapTests
    {
        [TestMethod]
        public void Given_A_String_Without_Spaces_And_Width_Larger_Than_String_Length_WordWrap_Should_Return_Same_String()
        {
            WordWrap wordWrap = new WordWrap();
            var result = wordWrap.WordWrapString("hello", 8);

            result.Should().Be("hello");
        }
    }
}
