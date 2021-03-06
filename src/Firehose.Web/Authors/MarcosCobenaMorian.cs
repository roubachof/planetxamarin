﻿using System;
using System.Collections.Generic;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class MarcosCobenaMorian : IAmACommunityMember
    {
        public string FirstName => "Marcos";
        public string LastName => "Cobeña Morián";
        public string ShortBioOrTagLine => "writes software to solve people's problems";
        public string EmailAddress => "marcoscm.digital@gmail.com";
        public string GravatarHash => "d5b1d9c158409e0093ad57e2e76a1727";
        public Uri WebSite => new Uri("https://marcoscobena.com");
        public string StateOrRegion => "Sevilla (Andalucía), Spain";
        public GeoPosition Position => new GeoPosition(37.4060605, -5.9309689);
        public string GitHubHandle => "MarcosCobena";
        public string TwitterHandle => "1Marcos2Cobena";
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://marcoscobena.com/feed.rss"); } }
        public string FeedLanguageCode => "en";
    }
}