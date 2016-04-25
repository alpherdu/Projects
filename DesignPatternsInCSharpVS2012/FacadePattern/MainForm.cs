using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FacadePattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("connection string");
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE Customer SET Processed=1";
            command.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLFacade.ExecuteSQL("UPDATE query here..");
        }
    }
}
