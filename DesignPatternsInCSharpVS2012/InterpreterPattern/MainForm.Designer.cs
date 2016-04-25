namespace InterpreterPattern
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CommandsText = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CommandsText
            // 
            this.CommandsText.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandsText.Location = new System.Drawing.Point(12, 12);
            this.CommandsText.Multiline = true;
            this.CommandsText.Name = "CommandsText";
            this.CommandsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommandsText.Size = new System.Drawing.Size(436, 63);
            this.CommandsText.TabIndex = 0;
            this.CommandsText.Text = "line,60,60,50,0;line,110,110,50,0;line,160,160,50,0;line,210,210,50,0;\r\ncircle,65" +
                ",10,40;circle,115,60,40;circle,165,110,40;circle,215,160,40;";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteButton.Location = new System.Drawing.Point(458, 12);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 63);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteBu_Click);
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.Location = new System.Drawing.Point(12, 81);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(436, 262);
            this.DrawingPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(253)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(545, 355);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.CommandsText);
            this.Name = "MainForm";
            this.Text = "Interpreter Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommandsText;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Panel DrawingPanel;
    }
}

