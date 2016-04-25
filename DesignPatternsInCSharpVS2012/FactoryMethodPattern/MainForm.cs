using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using FactoryMethod;
using System.Data.OleDb;

namespace FactoryMethod
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AppInit(); // Invoke AppInit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewInsertRecord();
        }

        /// <summary>
        /// This is the application initialize code
        /// </summary>
        private void AppInit()
        {
            if (AppContext.DatabaseType == DatabaseType.SqlServer)
                AppContext.DbProviderFactory = SqlClientFactory.Instance;

            else if (AppContext.DatabaseType == DatabaseType.Access)
                AppContext.DbProviderFactory = OleDbFactory.Instance;
        }

        /// <summary>
        ///  This is the new method
        /// </summary>
        private void NewInsertRecord()
        {
            DbConnection connection = AppContext.DbProviderFactory.CreateConnection();
            DbCommand command = AppContext.DbProviderFactory.CreateCommand();

            command.Connection = connection;
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// This is the old method
        /// </summary>
        public void OldInsertRecord()
        {
            if (AppContext.DatabaseType == DatabaseType.SqlServer)
            {
                SqlConnection connection = new SqlConnection();
                SqlCommand command = new SqlCommand();

                command.Connection = connection;
                command.ExecuteNonQuery();
            }
            else if (AppContext.DatabaseType == DatabaseType.Access)
            {
                OleDbConnection connection = new OleDbConnection();
                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;
                command.ExecuteNonQuery();
            }
        }
    }
}