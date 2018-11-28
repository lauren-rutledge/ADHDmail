﻿using System;
using System.Collections.Generic;
using Xunit;
using ADHDmail;

namespace ADHDmailTests
{
    public class ExtensionsTests
    {
        [Theory]
        [InlineData(@"c:\temp\MyTest.txt", true)]
        [InlineData("", false)]
        [InlineData(">", false)]
        [InlineData("|", false)]
        [InlineData("\"", false)]
        [InlineData("This is a string that exceeds 260 characters. This is a string that " +
                    "exceeds 260 characters. This is a string that exceeds 260 characters. " +
                    "This is a string that exceeds 260 characters. This is a string that " +
                    "exceeds 260 characters. This is a string that exceeds 260 characters.", false)]
        public void IsValidPath_Test(string input, bool expectedOutput)
        {
            Assert.Equal(input.IsValidPath(), expectedOutput);
        }

        private const string GmailDateTimeFormatExample = "Tue, 13 Nov 2018 22:01:48 + 0000(UTC)";

        public static IEnumerable<object[]> ValidDateTimes =>
            new List<object[]>
            {
                new object[] { GmailDateTimeFormatExample, new DateTime(2018, 11, 13, 22, 01, 48) },
            };

        public static IEnumerable<object[]> InvalidDateTimes =>
            new List<object[]>
            {
                new object[] { "Invalid date time", DateTime.MinValue },
                new object[] { "", DateTime.MinValue },
                new object[] { "     ", DateTime.MinValue },
                new object[] { null, DateTime.MinValue}
            };

        [Theory]
        [MemberData(nameof(ValidDateTimes))]
        [MemberData(nameof(InvalidDateTimes))]
        public void ToDateTime_Test(string input, DateTime expectedOutput)
        {
            Assert.Equal(input.ToDateTime(), expectedOutput);
        }
    }
}
