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

        [TestMethod]
        public void Given_A_String_With_A_Space_And_Width_Smaller_Than_String_Length_WordWrap_Should_Return_String_Splitted_By_Line_Feed()
        {
            WordWrap wordWrap = new WordWrap();
            var result = wordWrap.WordWrapString("hello boy", 7);

            result.Should().Be("hello\nboy");
        }


        [TestMethod]
        public void Given_A_String_With_Several_Spaces_And_Width_Smaller_Than_String_Length_WordWrap_Should_Return_String_Splitted_By_Line_Feed_Last_Word()
        {
            WordWrap wordWrap = new WordWrap();
            var result = wordWrap.WordWrapString("welcome to tdd", 12);

            result.Should().Be("welcome to\ntdd");
        }

        [TestMethod]
        public void Given_A_String_With_Several_Spaces_And_Width_Smaller_Than_String_Length_WordWrap_Should_Return_String_Splitted_By_Several_Line_Feeds()
        {
            WordWrap wordWrap = new WordWrap();
            var result = wordWrap.WordWrapString("welcome to tdd YoungPadawan", 12);

            result.Should().Be("welcome to\ntdd\nYoungPadawan");
        }

        [TestMethod]
        public void Given_A_String_With_No_Spaces_And_Width_Smaller_Than_String_Length_WordWrap_Should_Return_String_Splitted_By_Several_Line_Feeds()
        {
            WordWrap wordWrap = new WordWrap();
            var result = wordWrap.WordWrapString("ThisLongStringShouldBeSplittedSeveralTimes", 14);

            result.Should().Be("ThisLongString\nShouldBeSplitt\nedSeveralTimes");
        }

        [TestMethod]
        public void Given_A_String_With_Several_Spaces_And_Width_Able_To_Fit_Several_Words_Should_Return_String_Splitted_By_Several_Line_Feeds()
        {
            WordWrap wordWrap = new WordWrap();
            var result = wordWrap.WordWrapString("This sentence should be splitted several times", 19);

            result.Should().Be("This sentence\nshould be splitted\nseveral times");
        }

        [TestMethod]
        public void Given_A_String_With_Several_Spaces_Set_Width_Equals_To_Space_Return_String_Splitted_And_Trimmed()
        {
            WordWrap wordWrap = new WordWrap();
            var result = wordWrap.WordWrapString("TestTheBehavior of wordwrap when matching width and space", 15);

            result.Should().Be("TestTheBehavior\nof wordwrap\nwhen matching\nwidth and space");
        }
    }
}
