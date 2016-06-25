using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    //test
    public class TaskStatusBO
    {
        public TaskStatusBO()
        {
            this.Tasks = new HashSet<TaskBO>();
        }    
        public long TaskStatusID { get; set; }
        public string Status { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<TaskBO> Tasks { get; set; }
    }
}
