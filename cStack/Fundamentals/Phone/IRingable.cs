using System;
using System.Collections.Generic;

namespace Phone
{
    public interface IRingable
    {
        // string VersionNumber { get; set; }
        // int BatteryPercentage { get; set; }
        // string Carrier { get; set; }
        // string RingTone { get; set; }

        string Ring();
        string Unlock();
    }
}