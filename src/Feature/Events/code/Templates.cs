using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecore.Feature.Events
{
    public struct Templates
    {
        public struct Event
        {
            public static readonly ID ID = new ID("{B8F01FE1-5430-4772-AFF2-540B61AB7AB7}");
            public struct Fields
            {
                public static readonly ID Title = new ID("{4DBF4835-5D8A-4650-A2AE-290A5AA7D597}");
                public static readonly ID Description = new ID("{1A432835-D5ED-4854-A1B0-69229E2DFF30}");
                public static readonly ID Date = new ID("{A2F26289-FCCC-4B18-A062-F88AC2157E04}");
                public static readonly ID Venue = new ID("{1FB67D00-0963-4C6B-B5A2-23411F1A8BB4}");
                public static readonly ID VenueAddress = new ID("{FC5C2D87-9694-490D-BD52-030780B39A66}");
            }
        }
    }
}