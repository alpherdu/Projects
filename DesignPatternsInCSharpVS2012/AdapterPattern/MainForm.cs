using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AdapterPattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Create Square class and assign Size from UI
            Square square = new Square();
            square.Size = SquarePanel.Width;

            // Use Adapter to calculate the area
            CalculatorAdapter adapter = new CalculatorAdapter();
            int area = adapter.GetArea(square);

            // Display the result back to UI
            ResultLabel.Text = "Area: " + area.ToString();
        }
    }
}
