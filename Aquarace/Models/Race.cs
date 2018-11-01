using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquarace.Models
{
    public class Race
    {
        public int RaceID { get; private set; }
        public string RaceLocation { get; private set; }
        public DateTime RaceDate { get; private set; }
        public Driver[] driversPlacement { get; private set; }
        public Driver fastestDriver { get; private set; }
    }
}