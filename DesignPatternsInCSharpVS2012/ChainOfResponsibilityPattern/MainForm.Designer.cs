namespace ChainOfResponsibility
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
            this.EmailerList = new System.Windows.Forms.ListBox();
            this.LoggerList = new System.Windows.Forms.ListBox();
            this.CreateMessageButton = new System.Windows.Forms.Button();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.NormalButton = new System.Windows.Forms.RadioButton();
            this.HighButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.EmailerList);
            this.panel1.Controls.Add(this.LoggerList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 224);
            this.panel1.TabIndex = 0;
            // 
            // EmailerList
            // 
            this.EmailerList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailerList.FormattingEnabled = true;
            this.EmailerList.ItemHeight = 15;
            this.EmailerList.Location = new System.Drawing.Point(306, 22);
            this.EmailerList.Name = "EmailerList";
            this.EmailerList.Size = new System.Drawing.Size(261, 184);
            this.EmailerList.TabIndex = 0;
            // 
            // LoggerList
            // 
            this.LoggerList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggerList.FormattingEnabled = true;
            this.LoggerList.ItemHeight = 15;
            this.LoggerList.Location = new System.Drawing.Point(21, 22);
            this.LoggerList.Name = "LoggerList";
            this.LoggerList.Size = new System.Drawing.Size(261, 184);
            this.LoggerList.TabIndex = 0;
            // 
            // CreateMessageButton
            // 
            this.CreateMessageButton.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateMessageButton.Location = new System.Drawing.Point(267, 243);
            this.CreateMessageButton.Name = "CreateMessageButton";
            this.CreateMessageButton.Size = new System.Drawing.Size(300, 90);
            this.CreateMessageButton.TabIndex = 1;
            this.CreateMessageButton.Text = "Generate Message";
            this.CreateMessageButton.UseVisualStyleBackColor = true;
            this.CreateMessageButton.Click += new System.EventHandler(this.CreateMessageButton_Click);
            // 
            // MessageText
            // 
            this.MessageText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageText.Location = new System.Drawing.Point(12, 243);
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(239, 27);
            this.MessageText.TabIndex = 2;
            this.MessageText.Text = "Message";
            // 
            // NormalButton
            // 
            this.NormalButton.AutoSize = true;
            this.NormalButton.Checked = true;
            this.NormalButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalButton.Location = new System.Drawing.Point(12, 281);
            this.NormalButton.Name = "NormalButton";
            this.NormalButton.Size = new System.Drawing.Size(124, 23);
            this.NormalButton.TabIndex = 3;
            this.NormalButton.TabStop = true;
            this.NormalButton.Text = "Normal Priority";
            this.NormalButton.UseVisualStyleBackColor = true;
            // 
            // HighButton
            // 
            this.HighButton.AutoSize = true;
            this.HighButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighButton.Location = new System.Drawing.Point(12, 310);
            this.HighButton.Name = "HighButton";
            this.HighButton.Size = new System.Drawing.Size(107, 23);
            this.HighButton.TabIndex = 3;
            this.HighButton.Text = "High Priority";
            this.HighButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(589, 351);
            this.Controls.Add(this.HighButton);
            this.Controls.Add(this.NormalButton);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.CreateMessageButton);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Chain of Responsibility";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateMessageButton;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.RadioButton NormalButton;
        private System.Windows.Forms.RadioButton HighButton;
        public System.Windows.Forms.ListBox EmailerList;
        public System.Windows.Forms.ListBox LoggerList;
    }
}

