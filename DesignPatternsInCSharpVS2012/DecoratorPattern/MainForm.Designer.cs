namespace DecoratorPattern
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
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.btnAddChtristmasTree = new System.Windows.Forms.Button();
            this.btnAddSantaClaus = new System.Windows.Forms.Button();
            this.btnAddStars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMain
            // 
            this.pbxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMain.BackColor = System.Drawing.Color.White;
            this.pbxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxMain.Location = new System.Drawing.Point(10, 13);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(572, 422);
            this.pbxMain.TabIndex = 0;
            this.pbxMain.TabStop = false;
            this.pbxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxMain_MouseDown);
            // 
            // btnAddChtristmasTree
            // 
            this.btnAddChtristmasTree.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChtristmasTree.Location = new System.Drawing.Point(591, 13);
            this.btnAddChtristmasTree.Name = "btnAddChtristmasTree";
            this.btnAddChtristmasTree.Size = new System.Drawing.Size(172, 35);
            this.btnAddChtristmasTree.TabIndex = 1;
            this.btnAddChtristmasTree.Text = "Add Christmas Tree";
            this.btnAddChtristmasTree.UseVisualStyleBackColor = true;
            this.btnAddChtristmasTree.Click += new System.EventHandler(this.btnAddChtristmasTree_Click);
            // 
            // btnAddSantaClaus
            // 
            this.btnAddSantaClaus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSantaClaus.Location = new System.Drawing.Point(591, 58);
            this.btnAddSantaClaus.Name = "btnAddSantaClaus";
            this.btnAddSantaClaus.Size = new System.Drawing.Size(172, 35);
            this.btnAddSantaClaus.TabIndex = 2;
            this.btnAddSantaClaus.Text = "Add Santa Claus";
            this.btnAddSantaClaus.UseVisualStyleBackColor = true;
            this.btnAddSantaClaus.Click += new System.EventHandler(this.btnAddSantaClaus_Click);
            // 
            // btnAddStars
            // 
            this.btnAddStars.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStars.Location = new System.Drawing.Point(591, 103);
            this.btnAddStars.Name = "btnAddStars";
            this.btnAddStars.Size = new System.Drawing.Size(172, 35);
            this.btnAddStars.TabIndex = 3;
            this.btnAddStars.Text = "Add Stars";
            this.btnAddStars.UseVisualStyleBackColor = true;
            this.btnAddStars.Click += new System.EventHandler(this.btnAddStars_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(771, 446);
            this.Controls.Add(this.btnAddStars);
            this.Controls.Add(this.btnAddSantaClaus);
            this.Controls.Add(this.btnAddChtristmasTree);
            this.Controls.Add(this.pbxMain);
            this.Name = "MainForm";
            this.Text = "Decorator Pattern";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.Button btnAddChtristmasTree;
        private System.Windows.Forms.Button btnAddSantaClaus;
        private System.Windows.Forms.Button btnAddStars;
    }
}

