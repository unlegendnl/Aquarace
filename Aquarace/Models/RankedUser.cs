using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aquarace.Models
{
    public class RankedUser : User
    {
        public int Rank { get; private set; }

    }
}