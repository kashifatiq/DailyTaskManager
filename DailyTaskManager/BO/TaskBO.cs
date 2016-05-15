using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class TaskBO
    {
        public TaskBO()
        {
            this.TaskComments = new HashSet<TaskCommentBO>();
        }

        public long TaskID { get; set; }
        public string Text { get; set; }
        public long TaskStatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<System.DateTime> DateLastUpdated { get; set; }
        public Nullable<System.DateTime> DeadLineDate { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> AssingedToID { get; set; }
        public Nullable<System.DateTime> AssingedDate { get; set; }
        public Nullable<long> TaskPriorityID { get; set; }


        public TaskStatusBO TaskStatus { get; set; }
        public TeamMemberBO TeamMemberName { get; set; }
        public virtual ICollection<TaskCommentBO> TaskComments { get; set; }
        public virtual TaskPriorityBO TaskPriority { get; set; }
    }
}
