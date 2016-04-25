using Clock;
namespace CompositePattern
{
    partial class ClockForm
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
            this.clock1 = new ClockControl();
            this.clock2 = new ClockControl();
            this.SuspendLayout();
            // 
            // clock1
            // 
            this.clock1.ClockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clock1.CurrentTime = new System.DateTime(2012, 1, 26, 14, 22, 17, 927);
            this.clock1.Location = new System.Drawing.Point(-28, -28);
            this.clock1.Name = "clock1";
            this.clock1.Size = new System.Drawing.Size(308, 308);
            this.clock1.TabIndex = 1;
            // 
            // clock2
            // 
            this.clock2.ClockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.clock2.CurrentTime = new System.DateTime(2012, 1, 26, 14, 22, 28, 787);
            this.clock2.Location = new System.Drawing.Point(234, -27);
            this.clock2.Name = "clock2";
            this.clock2.Size = new System.Drawing.Size(308, 308);
            this.clock2.TabIndex = 2;
            this.clock2.Load += new System.EventHandler(this.clock2_Load);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 255);
            this.Controls.Add(this.clock2);
            this.Controls.Add(this.clock1);
            this.Name = "ClockForm";
            this.Text = "ClockForm";
            this.ResumeLayout(false);

        }

        #endregion

        public ClockControl clock1;
        public ClockControl clock2;
    }
}