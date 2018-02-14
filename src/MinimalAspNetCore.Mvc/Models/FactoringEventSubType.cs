using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalAspNetCore.Mvc.Models
{
    public class FactoringEventSubType
    {
        public const string LassPassOnWasteForTOCExposure = "Lass pass on Waste for TOC exposure";
        public const string FaultedCoal = "Faulted Coal (with no other Factoring)";
        public const string BottomFlitchOnCoal = "Bottom flitch on Coal";

        public static List<string> SubTypes = new List<string>()
        {
            "Lass pass on Waste for TOC exposure",
            "Faulted Coal (with no other Factoring)",
            "Bottom flitch on Coal"
        };
    }
}
