using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private List<Employee> employees;

        public Form1()
        {
            InitializeComponent();
            employees = new List<Employee>();
            employeeCatagory.SelectedIndex = 0;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Employee employee = null;
            switch (employeeCatagory.SelectedIndex)
            {
                case 1:
                    employee = new Sales(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, performanceTextBox.Text);
                    break;

                case 2:
                    employee = new Manager(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text, performanceTextBox.Text, this.manageTextBox.Text);
                    break;

                default:
                    employee = new Employee(idTextBox.Text, nameTextBox.Text, baseSalaryTextBox.Text);
                    break;
            }

            employees.Add(employee);
            UpdateEmployeesInfo();
        }

        private void UpdateEmployeesInfo()
        {
            infoRichTextBox.Text = string.Empty;
            idTextBox.Text = string.Empty;
            nameTextBox.Text = string.Empty;
            baseSalaryTextBox.Text = string.Empty;
            this.performanceTextBox.Text = string.Empty;
            this.manageTextBox.Text = string.Empty;
            foreach (Employee employee in employees)
            {
                infoRichTextBox.Text += string.Format("{0}\n"
                    , employee);
            }
        }

        private void employeeCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {
            performanceLabel.Visible = employeeCatagory.SelectedIndex > 0;
            performanceTextBox.Visible = employeeCatagory.SelectedIndex > 0;
            this.manageLabel.Visible = 2 == this.employeeCatagory.SelectedIndex;
            this.manageTextBox.Visible = 2 == this.employeeCatagory.SelectedIndex;
        }
    }
}