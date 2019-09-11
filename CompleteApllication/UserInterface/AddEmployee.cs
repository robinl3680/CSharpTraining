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
using System.Collections;

namespace UserInterface
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }
        
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            comboBox1.DataSource = data.GetAllDepartmentName();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            int deptid = data.GetDepartmentId(comboBox1.Text);
            if(deptid > 0)
            {
                int empid = int.Parse(textBox1.Text);
                string location = textBox2.Text;
                decimal salary = decimal.Parse(textBox3.Text);
                string name = textBox4.Text;
                if (data.InsertEmployee(empid, name, salary, location, deptid))
                    MessageBox.Show("Inserted successfully");
                else
                    MessageBox.Show("Insertion failed");
            }
        }
    }
}
