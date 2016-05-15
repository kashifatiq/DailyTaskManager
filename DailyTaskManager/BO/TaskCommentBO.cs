using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class TaskCommentBO
    {
        public long TaskCommentsID { get; set; }
        public long TaskID { get; set; }
        public string Comment { get; set; }
        public virtual TaskBO Task { get; set; }
    }
}
