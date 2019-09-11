using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationUtilities;
using CompleteApllication.DataAcceessLayer;
namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            comboBox1.DataSource = data.GetAllDepartmentName();
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Delete data";
            btn.Text = "Delete";
            btn.Name = "btn_delete"; 
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn1);
            btn1.HeaderText = "Update data";
            btn1.Text = "Update";
            btn1.Name = "btn_update";
            btn1.UseColumnTextForButtonValue = true;
            dataGridView1.Hide();
            dataGridView1.DataSource = "";
            
        }
        private void UpdateDataGridView()
        {
            DataAccess data = new DataAccess();
            List<Employee> employees = null;

            int deptid = data.GetDepartmentId(comboBox1.Text);
            if (deptid > 0)
            {
                employees = data.GetAllEmployees(deptid);
            }
            if (employees != null)
            {
                dataGridView1.Show();
                dataGridView1.DataSource = employees;

                ;
            }
            else
            {
                dataGridView1.Hide();
                dataGridView1.DataSource = "";
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdateDataGridView();
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string data = dataGridView1.CurrentCell.GetType().ToString();
            
            if(data == "System.Windows.Forms.DataGridViewButtonCell")
            {
                string cellContent = dataGridView1.CurrentCell.Value.ToString();
                if(cellContent == "Delete")
                {
                    MessageBox.Show("Deleting content");
                    string deleteString = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    DataAccess obj = new DataAccess();
                    if(obj.DeleteEmployee(int.Parse(deleteString)))
                    {
                        MessageBox.Show("Deleted");

                        UpdateDataGridView();
                    }

                }
                else if(cellContent == "Update")
                {
                    this.Hide();
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                    string name = (string)(dataGridView1.CurrentRow.Cells["Name"].Value);
                    decimal salary = (decimal)(dataGridView1.CurrentRow.Cells["Salary"].Value);
                    string location = (string)(dataGridView1.CurrentRow.Cells["Location"].Value);


                    Update up = new Update(id,name,salary,location);
                    up.MdiParent = ParentForm;
                    up.Show();
                }


            }
           

                
        }
    }
}
