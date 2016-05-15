using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using BO;
namespace DTMServices
{
    public class TasksService
    {
        DailyTaskManagerEntities _db = new DailyTaskManagerEntities();
        /// <summary>
        /// Get List of tasks
        /// </summary>
        /// <param name="teamMemberID">filtered list for specific team members</param>
        /// <param name="taskStatus">filtered list for specific status</param>
        /// <param name="AssignedDate">filtered list for specific date</param>
        /// <param name="PriorityID">filtered list for priority</param>        
        /// <param name="isShowDeleted">show/hide deleted tasks</param>
        /// <returns></returns>
        public List<TaskBO> GetTasksList(long? teamMemberID,long? taskStatus,string AssignedDate,long? PriorityID, bool isShowDeleted)
        {
            var lst = from Results in _db.Tasks 
                      select Results ;

            List<TaskBO> TasksList = new List<TaskBO>();
            foreach (DB.Task _task in lst)
            {
                TaskBO _BO = new TaskBO();
                _BO.TaskID = _task.TaskID;
                _BO.Text = _task.Text;
                _BO.TaskStatusID = _task.TaskStatusID;
                _BO.TaskStatus.Status = _task.TaskStatu.Status;

                _BO.AssingedToID = _task.AssingedToID;
                _BO.TeamMemberName.Name = _task.TeamMember.Name;

                _BO.DateCreated = _task.DateCreated;
                _BO.AssingedDate = _task.AssingedDate;
                _BO.DeadLineDate = _task.DeadLineDate;

                _BO.TaskPriorityID = _task.TaskPriorityID;
                _BO.TaskPriority.PriorityText = _task.TaskPriority.PriorityText;

                _BO.IsDeleted = _task.IsDeleted;
                TasksList.Add(_BO);
            }
            return TasksList;
        }
    }
}
