using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalAspNetCore.Mvc.Models
{
    public class Equipment
    {
        public static List<string> Excavators = new List<string>()
        {
            "HT001",
            "TK001",
            "TK003",
            "HT002",
            "TK002",
            "TK004",
            "HT003",
        };

        public static List<string> Fleets = new List<string>()
        {
            "1", "2", "3"
        };
    }
}
