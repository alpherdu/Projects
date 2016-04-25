using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace AbstractFactory
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SqlClientFactory factory = SqlClientFactory.Instance;
            
            DbConnection connection = factory.CreateConnection();
            DbCommand command = factory.CreateCommand();

            command.Connection = connection;
            command.CommandText = "query here";
            command.ExecuteNonQuery();
        }
    }
}

public abstract class DbProviderFactory
{
    public abstract DbConnection CreateConnection();
    public abstract DbCommand CreateCommand();
}
