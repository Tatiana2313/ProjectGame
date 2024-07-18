namespace Lab_10
{
    partial class GamerName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamerName));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelGameName = new System.Windows.Forms.Label();
            this.rjTextBoxGameName = new Lab_10.RJTextBox();
            this.rjButtonOk = new Lab_10.RJButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 42);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Segoe Print", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGameName.Location = new System.Drawing.Point(26, 108);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(229, 38);
            this.labelGameName.TabIndex = 1;
            this.labelGameName.Text = "Введите свое имя:";
            // 
            // rjTextBoxGameName
            // 
            this.rjTextBoxGameName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjTextBoxGameName.BorderColor = System.Drawing.Color.SaddleBrown;
            this.rjTextBoxGameName.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.rjTextBoxGameName.BorderRadius = 10;
            this.rjTextBoxGameName.BorderSize = 2;
            this.rjTextBoxGameName.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxGameName.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxGameName.Location = new System.Drawing.Point(273, 113);
            this.rjTextBoxGameName.Multiline = false;
            this.rjTextBoxGameName.Name = "rjTextBoxGameName";
            this.rjTextBoxGameName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxGameName.PasswordChar = false;
            this.rjTextBoxGameName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBoxGameName.PlaceholderText = "";
            this.rjTextBoxGameName.Size = new System.Drawing.Size(175, 35);
            this.rjTextBoxGameName.TabIndex = 3;
            this.rjTextBoxGameName.Texts = "";
            this.rjTextBoxGameName.UnderlinedStyle = false;
            this.rjTextBoxGameName._TextChanged += new System.EventHandler(this.rjTextBoxGameName__TextChanged);
            this.rjTextBoxGameName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // rjButtonOk
            // 
            this.rjButtonOk.BackColor = System.Drawing.Color.Peru;
            this.rjButtonOk.BackgroundColor = System.Drawing.Color.Peru;
            this.rjButtonOk.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonOk.BorderRadius = 27;
            this.rjButtonOk.BorderSize = 0;
            this.rjButtonOk.Enabled = false;
            this.rjButtonOk.FlatAppearance.BorderSize = 0;
            this.rjButtonOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.rjButtonOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.rjButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonOk.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjButtonOk.ForeColor = System.Drawing.Color.White;
            this.rjButtonOk.Location = new System.Drawing.Point(55, 182);
            this.rjButtonOk.Name = "rjButtonOk";
            this.rjButtonOk.Size = new System.Drawing.Size(124, 51);
            this.rjButtonOk.TabIndex = 2;
            this.rjButtonOk.Text = "OK";
            this.rjButtonOk.TextColor = System.Drawing.Color.White;
            this.rjButtonOk.UseVisualStyleBackColor = false;
            this.rjButtonOk.Click += new System.EventHandler(this.rjButtonOk_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::Lab_10.Properties.Resources.buttonclose;
            this.buttonClose.Location = new System.Drawing.Point(497, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 42);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GamerName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(539, 469);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjTextBoxGameName);
            this.Controls.Add(this.rjButtonOk);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GamerName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GamerName";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelGameName;
        private RJButton rjButtonOk;
        private RJTextBox rjTextBoxGameName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}