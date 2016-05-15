using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class TeamMemberBO
    {
        public TeamMemberBO()
        {
            this.Tasks = new HashSet<TaskBO>();
        }

        public long TeamMemberID { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Status { get; set; }

        public virtual ICollection<TaskBO> Tasks { get; set; }
    }
}
