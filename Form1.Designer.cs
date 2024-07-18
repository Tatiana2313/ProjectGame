namespace Lab_10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRules = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripDropDownButton();
            this.изменитьЦветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьШрифтТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьЦветШрифтаТекстаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonDiagram = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCorrectAnswers = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.rjProgressBar1 = new Lab_10.RJProgressBar();
            this.roundedPanel1 = new Lab_10.RoundedPanel();
            this.labelWrong = new System.Windows.Forms.Label();
            this.rjButtonCheck = new Lab_10.RJButton();
            this.rjTextBoxAnswer = new Lab_10.RJTextBox();
            this.labelPrimer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 44);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::Lab_10.Properties.Resources.buttonclose;
            this.buttonClose.Location = new System.Drawing.Point(879, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(44, 44);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Azure;
            this.toolStrip1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonStart,
            this.toolStripButtonStop,
            this.toolStripButtonSave,
            this.toolStripButtonRules,
            this.toolStripButtonSettings,
            this.toolStripButtonDiagram});
            this.toolStrip1.Location = new System.Drawing.Point(0, 44);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(6, 5, 20, 5);
            this.toolStrip1.Size = new System.Drawing.Size(923, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonStart
            // 
            this.toolStripButtonStart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStart.Image")));
            this.toolStripButtonStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStart.Name = "toolStripButtonStart";
            this.toolStripButtonStart.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButtonStart.Size = new System.Drawing.Size(104, 26);
            this.toolStripButtonStart.Text = "Начать";
            this.toolStripButtonStart.Click += new System.EventHandler(this.toolStripButtonStart_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.Enabled = false;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButtonStop.Size = new System.Drawing.Size(84, 26);
            this.toolStripButtonStop.Text = "Стоп";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Enabled = false;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButtonSave.Size = new System.Drawing.Size(134, 26);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonRules
            // 
            this.toolStripButtonRules.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRules.Image")));
            this.toolStripButtonRules.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRules.Name = "toolStripButtonRules";
            this.toolStripButtonRules.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButtonRules.Size = new System.Drawing.Size(114, 26);
            this.toolStripButtonRules.Text = "Правила";
            this.toolStripButtonRules.Click += new System.EventHandler(this.toolStripButtonRules_Click);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьЦветФонаToolStripMenuItem,
            this.изменитьШрифтТекстаToolStripMenuItem,
            this.изменитьЦветШрифтаТекстаToolStripMenuItem});
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.toolStripButtonSettings.Size = new System.Drawing.Size(144, 26);
            this.toolStripButtonSettings.Text = "Настройки";
            // 
            // изменитьЦветФонаToolStripMenuItem
            // 
            this.изменитьЦветФонаToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.изменитьЦветФонаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьЦветФонаToolStripMenuItem.Image")));
            this.изменитьЦветФонаToolStripMenuItem.Name = "изменитьЦветФонаToolStripMenuItem";
            this.изменитьЦветФонаToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6);
            this.изменитьЦветФонаToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.изменитьЦветФонаToolStripMenuItem.Text = "Изменить цвет фона";
            this.изменитьЦветФонаToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветФонаToolStripMenuItem_Click);
            // 
            // изменитьШрифтТекстаToolStripMenuItem
            // 
            this.изменитьШрифтТекстаToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.изменитьШрифтТекстаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьШрифтТекстаToolStripMenuItem.Image")));
            this.изменитьШрифтТекстаToolStripMenuItem.Name = "изменитьШрифтТекстаToolStripMenuItem";
            this.изменитьШрифтТекстаToolStripMenuItem.Padding = new System.Windows.Forms.Padding(6);
            this.изменитьШрифтТекстаToolStripMenuItem.Size = new System.Drawing.Size(376, 36);
            this.изменитьШрифтТекстаToolStripMenuItem.Text = "Изменить шрифт текста";
            this.изменитьШрифтТекстаToolStripMenuItem.Click += new System.EventHandler(this.изменитьШрифтТекстаToolStripMenuItem_Click);
            // 
            // изменитьЦветШрифтаТекстаToolStripMenuItem
            // 
            this.изменитьЦветШрифтаТекстаToolStripMenuItem.BackColor = System.Drawing.Color.Azure;
            this.изменитьЦветШрифтаТекстаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("изменитьЦветШрифтаТекстаToolStripMenuItem.Image")));
            this.изменитьЦветШрифтаТекстаToolStripMenuItem.Name = "изменитьЦветШрифтаТекстаToolStripMenuItem";
            this.изменитьЦветШрифтаТекстаToolStripMenuItem.Size = new System.Drawing.Size(364, 26);
            this.изменитьЦветШрифтаТекстаToolStripMenuItem.Text = "Изменить цвет шрифта текста";
            this.изменитьЦветШрифтаТекстаToolStripMenuItem.Click += new System.EventHandler(this.изменитьЦветШрифтаТекстаToolStripMenuItem_Click);
            // 
            // toolStripButtonDiagram
            // 
            this.toolStripButtonDiagram.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDiagram.Image")));
            this.toolStripButtonDiagram.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDiagram.Name = "toolStripButtonDiagram";
            this.toolStripButtonDiagram.Size = new System.Drawing.Size(134, 26);
            this.toolStripButtonDiagram.Text = "Статистика";
            this.toolStripButtonDiagram.Click += new System.EventHandler(this.toolStripButtonDiagram_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-17, 260);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 528);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(498, 557);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(425, 240);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.labelCorrectAnswers);
            this.panel2.Controls.Add(this.rjProgressBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 788);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(923, 65);
            this.panel2.TabIndex = 5;
            // 
            // labelCorrectAnswers
            // 
            this.labelCorrectAnswers.AutoSize = true;
            this.labelCorrectAnswers.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCorrectAnswers.Location = new System.Drawing.Point(331, 29);
            this.labelCorrectAnswers.Name = "labelCorrectAnswers";
            this.labelCorrectAnswers.Size = new System.Drawing.Size(54, 19);
            this.labelCorrectAnswers.TabIndex = 9;
            this.labelCorrectAnswers.Text = "label1";
            this.labelCorrectAnswers.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(303, 118);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(82, 34);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "label1";
            this.labelTime.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(687, 458);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(498, 524);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 86);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(513, 696);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(81, 86);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(747, 242);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(176, 115);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(747, 373);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(176, 115);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // rjProgressBar1
            // 
            this.rjProgressBar1.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rjProgressBar1.ChannelHeight = 17;
            this.rjProgressBar1.ForeBackColor = System.Drawing.Color.White;
            this.rjProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.rjProgressBar1.Location = new System.Drawing.Point(23, 6);
            this.rjProgressBar1.Maximum = 60;
            this.rjProgressBar1.Name = "rjProgressBar1";
            this.rjProgressBar1.ShowMaximun = false;
            this.rjProgressBar1.ShowValue = Lab_10.TextPosition.None;
            this.rjProgressBar1.Size = new System.Drawing.Size(251, 47);
            this.rjProgressBar1.SliderColor = System.Drawing.Color.RoyalBlue;
            this.rjProgressBar1.SliderHeight = 24;
            this.rjProgressBar1.SymbolAfter = "";
            this.rjProgressBar1.SymbolBefore = "";
            this.rjProgressBar1.TabIndex = 8;
            this.rjProgressBar1.Visible = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.roundedPanel1.Controls.Add(this.labelWrong);
            this.roundedPanel1.Controls.Add(this.rjButtonCheck);
            this.roundedPanel1.Controls.Add(this.rjTextBoxAnswer);
            this.roundedPanel1.Controls.Add(this.labelPrimer);
            this.roundedPanel1.CornerRadius = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(128, 188);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(613, 330);
            this.roundedPanel1.TabIndex = 2;
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWrong.ForeColor = System.Drawing.Color.Red;
            this.labelWrong.Location = new System.Drawing.Point(153, 222);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(74, 31);
            this.labelWrong.TabIndex = 8;
            this.labelWrong.Text = "label1";
            this.labelWrong.Visible = false;
            // 
            // rjButtonCheck
            // 
            this.rjButtonCheck.BackColor = System.Drawing.Color.Transparent;
            this.rjButtonCheck.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButtonCheck.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButtonCheck.BorderRadius = 20;
            this.rjButtonCheck.BorderSize = 0;
            this.rjButtonCheck.Enabled = false;
            this.rjButtonCheck.FlatAppearance.BorderSize = 0;
            this.rjButtonCheck.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButtonCheck.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rjButtonCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButtonCheck.ForeColor = System.Drawing.Color.White;
            this.rjButtonCheck.Image = global::Lab_10.Properties.Resources.icon_check;
            this.rjButtonCheck.Location = new System.Drawing.Point(437, 107);
            this.rjButtonCheck.Name = "rjButtonCheck";
            this.rjButtonCheck.Size = new System.Drawing.Size(94, 74);
            this.rjButtonCheck.TabIndex = 7;
            this.rjButtonCheck.TextColor = System.Drawing.Color.White;
            this.rjButtonCheck.UseVisualStyleBackColor = false;
            this.rjButtonCheck.Visible = false;
            this.rjButtonCheck.Click += new System.EventHandler(this.rjButtonCheck_Click);
            // 
            // rjTextBoxAnswer
            // 
            this.rjTextBoxAnswer.BackColor = System.Drawing.Color.PowderBlue;
            this.rjTextBoxAnswer.BorderColor = System.Drawing.Color.SlateBlue;
            this.rjTextBoxAnswer.BorderFocusColor = System.Drawing.Color.DarkCyan;
            this.rjTextBoxAnswer.BorderRadius = 0;
            this.rjTextBoxAnswer.BorderSize = 2;
            this.rjTextBoxAnswer.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rjTextBoxAnswer.ForeColor = System.Drawing.Color.Black;
            this.rjTextBoxAnswer.Location = new System.Drawing.Point(254, 117);
            this.rjTextBoxAnswer.Multiline = false;
            this.rjTextBoxAnswer.Name = "rjTextBoxAnswer";
            this.rjTextBoxAnswer.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBoxAnswer.PasswordChar = false;
            this.rjTextBoxAnswer.PlaceholderColor = System.Drawing.Color.DimGray;
            this.rjTextBoxAnswer.PlaceholderText = "";
            this.rjTextBoxAnswer.Size = new System.Drawing.Size(142, 52);
            this.rjTextBoxAnswer.TabIndex = 6;
            this.rjTextBoxAnswer.Texts = "";
            this.rjTextBoxAnswer.UnderlinedStyle = true;
            this.rjTextBoxAnswer.Visible = false;
            this.rjTextBoxAnswer._TextChanged += new System.EventHandler(this.rjTextBox__TextChanged);
            this.rjTextBoxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // labelPrimer
            // 
            this.labelPrimer.AutoSize = true;
            this.labelPrimer.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrimer.Location = new System.Drawing.Point(101, 127);
            this.labelPrimer.Name = "labelPrimer";
            this.labelPrimer.Size = new System.Drawing.Size(97, 42);
            this.labelPrimer.TabIndex = 5;
            this.labelPrimer.Text = "label1";
            this.labelPrimer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(923, 853);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Таблица умножения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonStart;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonRules;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSettings;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьШрифтТекстаToolStripMenuItem;
        private System.Windows.Forms.Label labelPrimer;
        private System.Windows.Forms.ToolStripMenuItem изменитьЦветШрифтаТекстаToolStripMenuItem;
        private RJTextBox rjTextBoxAnswer;
        private RJButton rjButtonCheck;
        private RJProgressBar rjProgressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labelCorrectAnswers;
        private System.Windows.Forms.ToolStripButton toolStripButtonDiagram;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

