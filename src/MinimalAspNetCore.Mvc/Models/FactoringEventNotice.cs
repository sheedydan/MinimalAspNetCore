using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinimalAspNetCore.Mvc.Models
{
    public class FactoringEventNotice
    {
        public int ID { get; set; }

        [Display(Name = "Event Commencement date and time")]
        public DateTime EventStartDateTime { get; set; }

        [Display(Name = "Was the Company's Representative promptly notified of the Factoring Event by the Contractor as soon as the delay/disruption was identified?")]
        public bool IsEventNotified { get; set; }

        // todo: add in is event notified 96 hours

        [Display(Name = "Factoring event type")]
        public string EventType { get; set; }

        [Display(Name = "Factoring event type (sub-category)")]
        public string EventSubType { get; set; }

        [Display(Name = "Primary Excavator")]
        public string PrimaryExcavator { get; set; }

        [Display(Name = "Fleet")]
        public string ExcavatorFleet { get; set; }

        [Display(Name = "Description of other event")]
        public string ExcavatorDescriptionOfOtherEvent { get; set; }

        [Display(Name = "Dig plan")]
        public string DigPlan { get; set; }

        [Display(Name = "Material type")]
        public string MaterialType { get; set; }

        [Display(Name = "Pit/Block/Strip")]
        public string Pit { get; set; }

        [Display(Name = "Other particulars")]
        public string OtherParticulars { get; set; }


        [Display(Name = "Has the factoring event been realised?")]
        public bool IsEventDateRealised { get; set; }

        [Display(Name = "Factoring Event commencement date and time.")]
        public DateTime EventRealisedDateTime { get; set; }


        [Display(Name = "Were mitigating measures implemented to minimise the factoring event?")]
        public bool IsMitigatingMeasures { get; set; }

        [Display(Name = "Mitigating measure 1")]
        public string MitigatingMeasure1 { get; set; }

        [Display(Name = "Mitigating measure 2")]
        public string MitigatingMeasure2 { get; set; }

        [Display(Name = "Mitigating measure 3")]
        public string MitigatingMeasure3 { get; set; }

        [Display(Name = "Mitigating measure 4")]
        public string MitigatingMeasure4 { get; set; }

        [Display(Name = "Further comments/notes")]
        public string FurtherComments { get; set; }

        [Display(Name = "Name")]
        public string SubmittingUserName { get; set; }

        [Display(Name = "Supervisor name")]
        public string SubmittingUserSupervisorName { get; set; }

        [Display(Name = "Attachments")]
        public byte[] Attachments { get; set; }

    }
}
