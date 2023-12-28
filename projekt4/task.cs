using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt4
{
    internal class task
    {
        public string TaskName { get; set; }
        public string Importance { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }

        public task(string taskName, string importance, string date, string description)
        {
            TaskName = taskName;
            Importance = importance;
            Date = date;
            Description = description;
        }

    }
}
