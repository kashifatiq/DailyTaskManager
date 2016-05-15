using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class TaskPriorityBO
    {
        public TaskPriorityBO()
        {
            this.Tasks = new HashSet<TaskBO>();
        }

        public long TaskPriorityID { get; set; }
        public string PriorityText { get; set; }
        public Nullable<bool> Status { get; set; }
        public string CustomCSS { get; set; }

        public virtual ICollection<TaskBO> Tasks { get; set; }
    }
}
