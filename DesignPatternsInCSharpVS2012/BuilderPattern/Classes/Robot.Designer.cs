namespace BuilderPattern.Classes
{
    partial class Robot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Robot));
            this.RobotPicture = new System.Windows.Forms.PictureBox();
            this.LogBox = new System.Windows.Forms.ListBox();
            this.Store = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.RobotPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // RobotPicture
            // 
            this.RobotPicture.Image = ((System.Drawing.Image)(resources.GetObject("RobotPicture.Image")));
            this.RobotPicture.Location = new System.Drawing.Point(3, 3);
            this.RobotPicture.Name = "RobotPicture";
            this.RobotPicture.Size = new System.Drawing.Size(129, 245);
            this.RobotPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RobotPicture.TabIndex = 0;
            this.RobotPicture.TabStop = false;
            // 
            // LogBox
            // 
            this.LogBox.BackColor = System.Drawing.Color.DarkGray;
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogBox.FormattingEnabled = true;
            this.LogBox.Location = new System.Drawing.Point(3, 251);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(242, 78);
            this.LogBox.TabIndex = 1;
            // 
            // Store
            // 
            this.Store.AutoScroll = true;
            this.Store.Location = new System.Drawing.Point(134, 3);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(111, 245);
            this.Store.TabIndex = 2;
            // 
            // Robot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Store);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.RobotPicture);
            this.Name = "Robot";
            this.Size = new System.Drawing.Size(247, 332);
            ((System.ComponentModel.ISupportInitialize)(this.RobotPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RobotPicture;
        private System.Windows.Forms.ListBox LogBox;
        private System.Windows.Forms.Panel Store;
    }
}
