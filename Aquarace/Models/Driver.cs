using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquarace.Models
{
    public class Driver
    {
        public int DriverID { get; private set; }
        public string DriverName { get; private set; }
        public Team teamName { get; private set; }

    }

    public enum Team
    {
        RedBull,
        Ferrari,
        ToroRosso,
        McLaren,
        Mercedes,
        PointForceIndia,
        Renault,
        Sauber,
        Haas,
        WilliamsMartini
    }
}