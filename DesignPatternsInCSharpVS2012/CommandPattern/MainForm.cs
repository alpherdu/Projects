using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CommandPattern.Classes;
using CommandPattern.CommandPattern;

namespace CommandPattern
{
    public partial class MainForm : Form
    {
        private ShapeEnum _activeShape = ShapeEnum.Square;
        private Color _activeColor = Color.Blue;

        private Bitmap _bitmap;
        private Graphics _graphics;

        public MainForm()
        {
            InitializeComponent();

            _bitmap = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Canvas.Image = _bitmap;
            _graphics = Graphics.FromImage(Canvas.Image);
            CreateColorPickerPanels();
        }

        #region "UI Code"

        /// <summary>
        /// Randomly create colors
        /// </summary>
        private void CreateColorPickerPanels()
        {
            Random random = new Random(100);

            for(int i = 1; i <= ColorTable.RowCount; i++)
                for (int j = 1; j <= ColorTable.ColumnCount; j++)
                {
                    Panel panel = new Panel();
                    panel.BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                    panel.Cursor = Cursors.Hand;
                    panel.Click += new EventHandler(colorPanel_Click);

                    ColorTable.Controls.Add(panel);
                }
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            _activeColor = (sender as Panel).BackColor;
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            _activeShape = ShapeEnum.Square;
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            _activeShape = ShapeEnum.Rectangle;
        }
        
        #endregion

        private Stack<ICommand> _commandStack = new Stack<ICommand>();

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            // Each mouse down creates a new command class instance

            ICommand command = null;

            if (_activeShape == ShapeEnum.Square)
                command = new SquareCommand(_bitmap, _activeColor, e.X, e.Y);

            else if (_activeShape == ShapeEnum.Rectangle)
                command = new RectangleCommand(_bitmap, _activeColor, e.X, e.Y);

            command.Do();
            _commandStack.Push(command);

            RefreshUI();
        }

        private void RefreshUI()
        {
            Canvas.Refresh();

            // Disable Undo button if no more commands available
            UndoButton.Enabled = _commandStack.Count > 0;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            // Check command stack contains items
            if (_commandStack.Count > 0)
            {
                // Remove the last command 
                ICommand lastCommand = _commandStack.Pop();

                // Call the Undo method
                lastCommand.Undo();
            }

            RefreshUI();
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            // Clear - continuously perform undo
            while (_commandStack.Count > 0)
                _commandStack.Pop().Undo();

            RefreshUI();
        }
    }

    public enum ShapeEnum
    {
        None,
        Square,
        Rectangle
    }
}
