using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalAspNetCore.Mvc.Models
{
    public class Details
    {
        public static List<string> DigPlans = new List<string>()
        {
            "Dig plan A",
            "Dig plan B",
            "Dig plan C"
        };

        public static List<string> MaterialTypes = new List<string>()
        {
            "Material A",
            "Material B",
            "Material C"
        };
    }
}
