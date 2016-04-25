namespace StrategyPattern
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ChangeGun = new System.Windows.Forms.Button();
            this.GunBox = new System.Windows.Forms.PictureBox();
            this.BulletsLabel = new System.Windows.Forms.Label();
            this.BulletBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.ChangeGun);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 521);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(12, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 179);
            this.label1.TabIndex = 2;
            this.label1.Text = "Strategy Pattern: Define a family of algorithms, encapsulate each one, and make t" +
                "hem interchangeable. Strategy\r\nlets the algorithm vary independently from client" +
                "s that use it.";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(12, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fire";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChangeGun
            // 
            this.ChangeGun.BackColor = System.Drawing.Color.Black;
            this.ChangeGun.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeGun.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChangeGun.Location = new System.Drawing.Point(12, 12);
            this.ChangeGun.Name = "ChangeGun";
            this.ChangeGun.Size = new System.Drawing.Size(169, 95);
            this.ChangeGun.TabIndex = 0;
            this.ChangeGun.Text = "Change Gun";
            this.ChangeGun.UseVisualStyleBackColor = false;
            this.ChangeGun.Click += new System.EventHandler(this.ChangeGun_Click);
            // 
            // GunBox
            // 
            this.GunBox.Location = new System.Drawing.Point(217, 207);
            this.GunBox.Name = "GunBox";
            this.GunBox.Size = new System.Drawing.Size(158, 93);
            this.GunBox.TabIndex = 1;
            this.GunBox.TabStop = false;
            // 
            // BulletsLabel
            // 
            this.BulletsLabel.BackColor = System.Drawing.Color.Black;
            this.BulletsLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BulletsLabel.ForeColor = System.Drawing.Color.Lime;
            this.BulletsLabel.Location = new System.Drawing.Point(780, 12);
            this.BulletsLabel.Name = "BulletsLabel";
            this.BulletsLabel.Size = new System.Drawing.Size(148, 23);
            this.BulletsLabel.TabIndex = 2;
            this.BulletsLabel.Text = "Bullets: 5";
            this.BulletsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BulletBox
            // 
            this.BulletBox.Location = new System.Drawing.Point(409, 207);
            this.BulletBox.Name = "BulletBox";
            this.BulletBox.Size = new System.Drawing.Size(46, 36);
            this.BulletBox.TabIndex = 3;
            this.BulletBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 521);
            this.Controls.Add(this.BulletBox);
            this.Controls.Add(this.BulletsLabel);
            this.Controls.Add(this.GunBox);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Strategy Pattern";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GunBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BulletBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ChangeGun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox GunBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BulletsLabel;
        private System.Windows.Forms.PictureBox BulletBox;
    }
}

