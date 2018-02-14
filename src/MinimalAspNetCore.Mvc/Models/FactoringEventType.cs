using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalAspNetCore.Mvc.Models
{
    public class FactoringEventType
    {
        public const string TopLoading = "Top Loading";
        public const string DoubleStripWidths = "Double Strip Widths";
        public const string DoubleStripWidthsTopLoading = "Double Strip Widths/Top Loading";
        public const string DoubleStripWidthsBlastedWasteInWedgeConfiguration = "Double Strip/Widths Blasted Waste in Wedge Configuration";
        public const string BlastedWasteInWedgeConfiguration = "Blasted Waste in Wedge Configuration";
        public const string PoorFragmentationInBlastedWaste = "Poor Fragmentation in Blasted Waste";
        public const string UnderTruckingDueToTheLHDLimits = "Under-Trucking due to the LHD limits";
        public const string HaulRouteImpactsOnTruckGuaranteedProductivity = "Haul Route Impacts on Truck Guaranteed Productivity";
        public const string OtherFactoringEvent = "Other Factoring Event";

        public static List<string> Events = new List<string>()
        {
            "Top Loading",
            "Double Strip Widths",
            "Double Strip Widths/Top Loading",
            "Double Strip/Widths Blasted Waste in Wedge Configuration",
            "Blasted Waste in Wedge Configuration",
            "Poor Fragmentation in Blasted Waste",
            "Under-Trucking due to the LHD limits",
            "Haul Route Impacts on Truck Guaranteed Productivity",
            "Other Factoring Event"
        };
    }
}
