using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanaban501app
{
    public class KanbanItem
    {
        public string Activity { get; set; }

        public string Resources { get; set; }

        public DateTime CompleteBy { get; set; }

        public string Status { get; set; }

        public KanbanItem(string activity, string resources, DateTime completeBy, string status)
        {
            Activity = activity;
            Resources = resources;
            CompleteBy = completeBy;
            Status = status;
        }

        public override string ToString()
        {
            return Activity;
        }
    }
}
