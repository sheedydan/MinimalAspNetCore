using System;
using System.IO;
using System.Linq;
using MinimalAspNetCore.Mvc.Models;

namespace MinimalAspNetCore.Mvc.Data
{
    public class FactoringEventDbInitializer
    {
        public static void Initialize(FactoringEventContext context)
        {
            context.Database.EnsureCreated();

            if (context.FactoringEventNotices.Any())
            {
                return;
            }

            var factoringEventNotices = new FactoringEventNotice[]
            {
                new FactoringEventNotice
                {
                    EventStartDateTime = new DateTime(2018, 01, 25),
                    IsEventNotified = true,
                    EventType = FactoringEventType.BlastedWasteInWedgeConfiguration,
                    EventSubType = FactoringEventSubType.FaultedCoal,
                    PrimaryExcavator = "HT003",
                    ExcavatorFleet = "1",
                    ExcavatorDescriptionOfOtherEvent = "Description of other event.",
                    Pit = "Pit A",
                    MaterialType = "Material Type 1",
                    DigPlan = "Plan 1",
                    OtherParticulars = "OtherParticulars",
                    IsEventDateRealised = true,
                    EventRealisedDateTime = new DateTime(2018, 02, 07),
                    IsMitigatingMeasures = true,
                    MitigatingMeasure1 = "Mitigating measure 1",
                    MitigatingMeasure2 = "Mitigating measure 2",
                    MitigatingMeasure3 = "Mitigating measure 3",
                    MitigatingMeasure4 = "Mitigating measure 4",
                    FurtherComments = "Further comments",
                    SubmittingUserName = "Daniel Sheedy",
                    SubmittingUserSupervisorName = "Kelly Vipen",
                    Attachments = File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, @"Data/Assets/attachment.json"))
                }
            };

            foreach (var factoringEventNotice in factoringEventNotices)
            {
                context.FactoringEventNotices.Add(factoringEventNotice);
            }

            context.SaveChanges();
        }
    }
}
