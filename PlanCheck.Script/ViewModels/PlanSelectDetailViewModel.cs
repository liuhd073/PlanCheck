using PlanCheck.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;
using VMS.TPS.Common.Model.API;

namespace PlanCheck
{
    public class PlanSelectDetailViewModel : ViewModelBase
    {
        public PlanningItemViewModel ActivePlanningItem { get; set; }
        public string PlanningItemIdWithCourse { get; set; }
        public PlanningItem PlanningItemObject { get; set; }
        public string ApprovalStatus { get; set; }
        public bool IsPlanSum { get; set; }
        public bool IsDoseValid { get; set; }
        public string PlanName { get; set; }
        public string PlanCreated { get; set; }
        public string PlanFxDose { get; set; }
        public string PlanFractions { get; set; }
        public string PlanTotalDose { get; set; }
        public string PlanTarget { get; set; }
        public string PlanStructureSet { get; set; }
        public string PlanNumFields { get; set; }
    }
}
