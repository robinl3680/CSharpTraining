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
        int id;
        string name;
        decimal salary;
        string location;
        int depitd;
        public Update()
        {
            InitializeComponent();
        }
        public Update(int id, string name, decimal salary, string location)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.location = location;
            this.salary = salary;
            this.depitd = 0;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            dept_combo.DataSource = data.GetAllDepartmentName();
            name_txt.Text = name;
            salary_txt.Text = salary.ToString();
            location_txt.Text = location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = name_txt.Text;
            salary = Convert.ToDecimal(salary_txt.Text);
            location = location_txt.Text;
            
            DataAccess data = new DataAccess();
            depitd = data.GetDepartmentId(dept_combo.Text);
            if(depitd > 0)
            {
                if (data.Updateemployee(id, name, location, salary, depitd))
                    MessageBox.Show("Update success");
                else
                    MessageBox.Show("Update failed");
            }
        }
    }
}
