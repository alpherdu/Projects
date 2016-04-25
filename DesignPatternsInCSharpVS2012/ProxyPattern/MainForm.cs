using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace Proxy
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            RefreshGrid();
        }

        private List<Employee> _list = new List<Employee>();

        private void RefreshGrid()
        {
            // Create data
            for (int i = 1; i <= 10; i++)
                _list.Add(new Employee() { Name = "Employee "+ i.ToString(), Address = "Address " + i.ToString(), Salary = 10000 * i });

            // Assign to grid
            dataGridView1.DataSource = _list;
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//Start Excel and get Application object.
Microsoft.Office.Interop.Excel.Application oXL = new Microsoft.Office.Interop.Excel.Application();
oXL.Visible = true;

//Get a new workbook.
Microsoft.Office.Interop.Excel._Workbook oWB = (Microsoft.Office.Interop.Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
Microsoft.Office.Interop.Excel._Worksheet oSheet = (Microsoft.Office.Interop.Excel._Worksheet)oWB.ActiveSheet;

//Add table headers going cell by cell.
oSheet.Cells[1, 1] = "Name";
oSheet.Cells[1, 2] = "Address";
oSheet.Cells[1, 3] = "Salary";

//Format A1:D1 as bold, vertical alignment = center.
oSheet.get_Range("A1", "C1").Font.Bold = true;
oSheet.get_Range("A1", "C1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

int i = 2;
foreach (Employee employee in _list)
{
    string[] values = new string[3];
    values[0] = employee.Name;
    values[1] = employee.Address;
    values[2] = employee.Salary.ToString();

    oSheet.get_Range("A" + i.ToString(), "C" + i.ToString()).Value = values;
    i++;
}

oXL.Visible = true;
oXL.UserControl = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
ExcelProxy proxy = new ExcelProxy();
proxy.Save(_list);
        }
    }
}
