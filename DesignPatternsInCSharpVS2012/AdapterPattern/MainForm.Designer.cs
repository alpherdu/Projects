namespace AdapterPattern
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
            this.SquarePanel = new System.Windows.Forms.Panel();
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SquarePanel
            // 
            this.SquarePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SquarePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SquarePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SquarePanel.Location = new System.Drawing.Point(38, 24);
            this.SquarePanel.Name = "SquarePanel";
            this.SquarePanel.Size = new System.Drawing.Size(156, 146);
            this.SquarePanel.TabIndex = 0;
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.BackColor = System.Drawing.Color.Lime;
            this.RectanglePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RectanglePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglePanel.Location = new System.Drawing.Point(239, 24);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(279, 146);
            this.RectanglePanel.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(38, 189);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(156, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ResultLabel.Location = new System.Drawing.Point(34, 226);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 22);
            this.ResultLabel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 383);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.RectanglePanel);
            this.Controls.Add(this.SquarePanel);
            this.Name = "MainForm";
            this.Text = "Adapter Pattern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SquarePanel;
        private System.Windows.Forms.Panel RectanglePanel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

