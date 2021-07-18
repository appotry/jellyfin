﻿using MediaBrowser.Providers.Plugins.Tmdb;
using Xunit;

namespace Jellyfin.Providers.Tests.Tmdb
{
    public static class TmdbUtilsTests
    {
        [Theory]
        [InlineData("de", "de")]
        [InlineData("En", "En")]
        [InlineData("de-de", "de-DE")]
        [InlineData("en-US", "en-US")]
        [InlineData("de-CH", "de")]
        public static void NormalizeLanguage_Valid_Success(string input, string expected)
        {
            Assert.Equal(expected, TmdbUtils.NormalizeLanguage(input));
        }

        [Theory]
        [InlineData(null, null)]
        [InlineData("", "")]
        public static void NormalizeLanguage_Invalid_Equal(string? input, string? expected)
        {
            Assert.Equal(expected, TmdbUtils.NormalizeLanguage(input!));
        }
    }
}
