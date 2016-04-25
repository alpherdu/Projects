using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Proxy
{
    public class ExcelProxy
    {
        public void Save(IList<Employee> list)
        {
           // Create 2 dimensional array
            string[,] values = new string[list.Count, 3];
            for (int i = 0; i < list.Count; i++)
            {
                values[i, 0] = list[i].Name;
                values[i, 1] = list[i].Address;
                values[i, 2] = list[i].Salary.ToString();
            }

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


            oSheet.get_Range("A2", "C" + ((values.Length / 3) + 1).ToString()).Value = values;

            oXL.Visible = true;
            oXL.UserControl = true;
        }
    }
}
