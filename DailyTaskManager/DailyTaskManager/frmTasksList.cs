using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using DTMServices;
namespace DailyTaskManager
{
    public partial class frmTasksList : Form
    {
        DTMServices.TasksService _service = new TasksService();
        public frmTasksList()
        {
            InitializeComponent();
        }

        private void frmTasksList_Load(object sender, EventArgs e)
        {
            List<TaskBO> lstTasks = _service.GetTasksList(null, null, null, null, true);
            dgResult.DataSource = lstTasks;
            //test
        }
    }
}
