namespace BuilderPattern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AMDCPU = new System.Windows.Forms.RadioButton();
            this.IntelCPU = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LGMonitor = new System.Windows.Forms.RadioButton();
            this.SamsungMonitor = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SurroundSpeakers = new System.Windows.Forms.RadioButton();
            this.StereoSpeakers = new System.Windows.Forms.RadioButton();
            this.NoSpeakers = new System.Windows.Forms.RadioButton();
            this.AddRobot = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.StartRun = new System.Windows.Forms.Button();
            this.Factory = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AMDCPU);
            this.groupBox1.Controls.Add(this.IntelCPU);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 1: Select CPU";
            // 
            // AMDCPU
            // 
            this.AMDCPU.AutoSize = true;
            this.AMDCPU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMDCPU.Location = new System.Drawing.Point(66, 66);
            this.AMDCPU.Name = "AMDCPU";
            this.AMDCPU.Size = new System.Drawing.Size(56, 22);
            this.AMDCPU.TabIndex = 4;
            this.AMDCPU.TabStop = true;
            this.AMDCPU.Text = "AMD";
            this.AMDCPU.UseVisualStyleBackColor = true;
            // 
            // IntelCPU
            // 
            this.IntelCPU.AutoSize = true;
            this.IntelCPU.Checked = true;
            this.IntelCPU.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelCPU.Location = new System.Drawing.Point(66, 38);
            this.IntelCPU.Name = "IntelCPU";
            this.IntelCPU.Size = new System.Drawing.Size(55, 22);
            this.IntelCPU.TabIndex = 3;
            this.IntelCPU.TabStop = true;
            this.IntelCPU.Text = "Intel";
            this.IntelCPU.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LGMonitor);
            this.groupBox2.Controls.Add(this.SamsungMonitor);
            this.groupBox2.Location = new System.Drawing.Point(213, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 2: Select Monitor";
            // 
            // LGMonitor
            // 
            this.LGMonitor.AutoSize = true;
            this.LGMonitor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGMonitor.Location = new System.Drawing.Point(60, 66);
            this.LGMonitor.Name = "LGMonitor";
            this.LGMonitor.Size = new System.Drawing.Size(41, 22);
            this.LGMonitor.TabIndex = 6;
            this.LGMonitor.TabStop = true;
            this.LGMonitor.Text = "LG";
            this.LGMonitor.UseVisualStyleBackColor = true;
            // 
            // SamsungMonitor
            // 
            this.SamsungMonitor.AutoSize = true;
            this.SamsungMonitor.Checked = true;
            this.SamsungMonitor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamsungMonitor.Location = new System.Drawing.Point(60, 38);
            this.SamsungMonitor.Name = "SamsungMonitor";
            this.SamsungMonitor.Size = new System.Drawing.Size(81, 22);
            this.SamsungMonitor.TabIndex = 5;
            this.SamsungMonitor.TabStop = true;
            this.SamsungMonitor.Text = "Samsung";
            this.SamsungMonitor.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SurroundSpeakers);
            this.groupBox3.Controls.Add(this.StereoSpeakers);
            this.groupBox3.Controls.Add(this.NoSpeakers);
            this.groupBox3.Location = new System.Drawing.Point(419, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 3: Has Speakers";
            // 
            // SurroundSpeakers
            // 
            this.SurroundSpeakers.AutoSize = true;
            this.SurroundSpeakers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurroundSpeakers.Location = new System.Drawing.Point(61, 80);
            this.SurroundSpeakers.Name = "SurroundSpeakers";
            this.SurroundSpeakers.Size = new System.Drawing.Size(83, 22);
            this.SurroundSpeakers.TabIndex = 7;
            this.SurroundSpeakers.TabStop = true;
            this.SurroundSpeakers.Text = "Surround";
            this.SurroundSpeakers.UseVisualStyleBackColor = true;
            // 
            // StereoSpeakers
            // 
            this.StereoSpeakers.AutoSize = true;
            this.StereoSpeakers.Checked = true;
            this.StereoSpeakers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StereoSpeakers.Location = new System.Drawing.Point(61, 52);
            this.StereoSpeakers.Name = "StereoSpeakers";
            this.StereoSpeakers.Size = new System.Drawing.Size(67, 22);
            this.StereoSpeakers.TabIndex = 6;
            this.StereoSpeakers.TabStop = true;
            this.StereoSpeakers.Text = "Stereo";
            this.StereoSpeakers.UseVisualStyleBackColor = true;
            // 
            // NoSpeakers
            // 
            this.NoSpeakers.AutoSize = true;
            this.NoSpeakers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSpeakers.Location = new System.Drawing.Point(61, 24);
            this.NoSpeakers.Name = "NoSpeakers";
            this.NoSpeakers.Size = new System.Drawing.Size(60, 22);
            this.NoSpeakers.TabIndex = 5;
            this.NoSpeakers.TabStop = true;
            this.NoSpeakers.Text = "None";
            this.NoSpeakers.UseVisualStyleBackColor = true;
            // 
            // AddRobot
            // 
            this.AddRobot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddRobot.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRobot.Location = new System.Drawing.Point(27, 31);
            this.AddRobot.Name = "AddRobot";
            this.AddRobot.Size = new System.Drawing.Size(96, 64);
            this.AddRobot.TabIndex = 4;
            this.AddRobot.Text = "Add Robot";
            this.AddRobot.UseVisualStyleBackColor = false;
            this.AddRobot.Click += new System.EventHandler(this.AddRobot_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.AddRobot);
            this.groupBox4.Location = new System.Drawing.Point(625, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 117);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 4: Add Robot";
            // 
            // StartRun
            // 
            this.StartRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.StartRun.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartRun.Location = new System.Drawing.Point(7, 131);
            this.StartRun.Name = "StartRun";
            this.StartRun.Size = new System.Drawing.Size(768, 50);
            this.StartRun.TabIndex = 6;
            this.StartRun.Text = "After adding enough Robots   >>   Click here to start running the Robots";
            this.StartRun.UseVisualStyleBackColor = false;
            this.StartRun.Click += new System.EventHandler(this.StartRun_Click);
            // 
            // Factory
            // 
            this.Factory.BackColor = System.Drawing.Color.White;
            this.Factory.Location = new System.Drawing.Point(7, 193);
            this.Factory.Name = "Factory";
            this.Factory.Size = new System.Drawing.Size(768, 350);
            this.Factory.TabIndex = 7;
            this.Factory.TabStop = false;
            this.Factory.Text = "Factory:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(5, 547);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 587);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Factory);
            this.Controls.Add(this.StartRun);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder Pattern";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton AMDCPU;
        private System.Windows.Forms.RadioButton IntelCPU;
        private System.Windows.Forms.RadioButton LGMonitor;
        private System.Windows.Forms.RadioButton SamsungMonitor;
        private System.Windows.Forms.RadioButton StereoSpeakers;
        private System.Windows.Forms.RadioButton NoSpeakers;
        private System.Windows.Forms.Button AddRobot;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button StartRun;
        private System.Windows.Forms.GroupBox Factory;
        private System.Windows.Forms.RadioButton SurroundSpeakers;
        private System.Windows.Forms.Label label1;
    }
}

