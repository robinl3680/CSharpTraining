using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompleteApllication.DataAcceessLayer;
using ApplicationUtilities;
namespace UserInterface
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            dept_combo.DataSource = data.GetAllDepartmentName();
        }
    }
}
