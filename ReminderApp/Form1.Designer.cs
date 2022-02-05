namespace ReminderApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTimeSetting = new System.Windows.Forms.GroupBox();
            this.rb1Hour = new System.Windows.Forms.RadioButton();
            this.rb40min = new System.Windows.Forms.RadioButton();
            this.rb30min = new System.Windows.Forms.RadioButton();
            this.rb10Min = new System.Windows.Forms.RadioButton();
            this.rb20min = new System.Windows.Forms.RadioButton();
            this.rbMannually = new System.Windows.Forms.RadioButton();
            this.numericUpSecond = new System.Windows.Forms.NumericUpDown();
            this.numericUpMinute = new System.Windows.Forms.NumericUpDown();
            this.numericUpHour = new System.Windows.Forms.NumericUpDown();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbTimeDisplay = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClearTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxTimeSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // groupBoxTimeSetting
            // 
            this.groupBoxTimeSetting.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBoxTimeSetting.Controls.Add(this.rb1Hour);
            this.groupBoxTimeSetting.Controls.Add(this.rb40min);
            this.groupBoxTimeSetting.Controls.Add(this.rb30min);
            this.groupBoxTimeSetting.Controls.Add(this.rb10Min);
            this.groupBoxTimeSetting.Controls.Add(this.rb20min);
            this.groupBoxTimeSetting.Controls.Add(this.rbMannually);
            this.groupBoxTimeSetting.Controls.Add(this.numericUpSecond);
            this.groupBoxTimeSetting.Controls.Add(this.numericUpMinute);
            this.groupBoxTimeSetting.Controls.Add(this.numericUpHour);
            this.groupBoxTimeSetting.Controls.Add(this.btnRegister);
            this.groupBoxTimeSetting.Controls.Add(this.label2);
            this.groupBoxTimeSetting.Controls.Add(this.label1);
            this.groupBoxTimeSetting.Location = new System.Drawing.Point(23, 12);
            this.groupBoxTimeSetting.Name = "groupBoxTimeSetting";
            this.groupBoxTimeSetting.Size = new System.Drawing.Size(208, 246);
            this.groupBoxTimeSetting.TabIndex = 5;
            this.groupBoxTimeSetting.TabStop = false;
            this.groupBoxTimeSetting.Text = "Time Setting";
            // 
            // rb1Hour
            // 
            this.rb1Hour.AutoSize = true;
            this.rb1Hour.Location = new System.Drawing.Point(13, 176);
            this.rb1Hour.Name = "rb1Hour";
            this.rb1Hour.Size = new System.Drawing.Size(70, 21);
            this.rb1Hour.TabIndex = 18;
            this.rb1Hour.TabStop = true;
            this.rb1Hour.Text = "1 hour";
            this.rb1Hour.UseVisualStyleBackColor = true;
            // 
            // rb40min
            // 
            this.rb40min.AutoSize = true;
            this.rb40min.Location = new System.Drawing.Point(13, 149);
            this.rb40min.Name = "rb40min";
            this.rb40min.Size = new System.Drawing.Size(98, 21);
            this.rb40min.TabIndex = 17;
            this.rb40min.TabStop = true;
            this.rb40min.Text = "40 minutes";
            this.rb40min.UseVisualStyleBackColor = true;
            // 
            // rb30min
            // 
            this.rb30min.AutoSize = true;
            this.rb30min.Location = new System.Drawing.Point(13, 122);
            this.rb30min.Name = "rb30min";
            this.rb30min.Size = new System.Drawing.Size(98, 21);
            this.rb30min.TabIndex = 16;
            this.rb30min.TabStop = true;
            this.rb30min.Text = "30 minutes";
            this.rb30min.UseVisualStyleBackColor = true;
            // 
            // rb10Min
            // 
            this.rb10Min.AutoSize = true;
            this.rb10Min.Location = new System.Drawing.Point(13, 68);
            this.rb10Min.Name = "rb10Min";
            this.rb10Min.Size = new System.Drawing.Size(98, 21);
            this.rb10Min.TabIndex = 15;
            this.rb10Min.TabStop = true;
            this.rb10Min.Text = "10 minutes";
            this.rb10Min.UseVisualStyleBackColor = true;
            // 
            // rb20min
            // 
            this.rb20min.AutoSize = true;
            this.rb20min.Location = new System.Drawing.Point(13, 95);
            this.rb20min.Name = "rb20min";
            this.rb20min.Size = new System.Drawing.Size(98, 21);
            this.rb20min.TabIndex = 14;
            this.rb20min.TabStop = true;
            this.rb20min.Text = "20 minutes";
            this.rb20min.UseVisualStyleBackColor = true;
            // 
            // rbMannually
            // 
            this.rbMannually.AutoSize = true;
            this.rbMannually.Location = new System.Drawing.Point(13, 34);
            this.rbMannually.Name = "rbMannually";
            this.rbMannually.Size = new System.Drawing.Size(17, 16);
            this.rbMannually.TabIndex = 13;
            this.rbMannually.TabStop = true;
            this.rbMannually.UseVisualStyleBackColor = true;
            // 
            // numericUpSecond
            // 
            this.numericUpSecond.Location = new System.Drawing.Point(160, 32);
            this.numericUpSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpSecond.Name = "numericUpSecond";
            this.numericUpSecond.Size = new System.Drawing.Size(35, 22);
            this.numericUpSecond.TabIndex = 10;
            // 
            // numericUpMinute
            // 
            this.numericUpMinute.Location = new System.Drawing.Point(98, 32);
            this.numericUpMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpMinute.Name = "numericUpMinute";
            this.numericUpMinute.Size = new System.Drawing.Size(35, 22);
            this.numericUpMinute.TabIndex = 11;
            // 
            // numericUpHour
            // 
            this.numericUpHour.Location = new System.Drawing.Point(36, 32);
            this.numericUpHour.Name = "numericUpHour";
            this.numericUpHour.Size = new System.Drawing.Size(35, 22);
            this.numericUpHour.TabIndex = 12;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Tan;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(56, 203);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(98, 35);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lbTimeDisplay
            // 
            this.lbTimeDisplay.AutoSize = true;
            this.lbTimeDisplay.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeDisplay.Location = new System.Drawing.Point(257, 24);
            this.lbTimeDisplay.Name = "lbTimeDisplay";
            this.lbTimeDisplay.Size = new System.Drawing.Size(160, 42);
            this.lbTimeDisplay.TabIndex = 6;
            this.lbTimeDisplay.Text = "-- : -- : --";
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBegin.Enabled = false;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(288, 79);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(93, 42);
            this.btnBegin.TabIndex = 7;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Tan;
            this.btnReset.Enabled = false;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(288, 163);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 42);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnClearTime
            // 
            this.btnClearTime.BackColor = System.Drawing.Color.Salmon;
            this.btnClearTime.Enabled = false;
            this.btnClearTime.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTime.Location = new System.Drawing.Point(288, 211);
            this.btnClearTime.Name = "btnClearTime";
            this.btnClearTime.Size = new System.Drawing.Size(93, 42);
            this.btnClearTime.TabIndex = 10;
            this.btnClearTime.Text = "Clear Time";
            this.btnClearTime.UseVisualStyleBackColor = false;
            this.btnClearTime.Click += new System.EventHandler(this.btnClearTime_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Developed by Copyright © Yibing Chen 2020. All rights reserved.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(442, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lbTimeDisplay);
            this.Controls.Add(this.groupBoxTimeSetting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Break Reminder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxTimeSetting.ResumeLayout(false);
            this.groupBoxTimeSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxTimeSetting;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbTimeDisplay;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numericUpSecond;
        private System.Windows.Forms.NumericUpDown numericUpMinute;
        private System.Windows.Forms.NumericUpDown numericUpHour;
        private System.Windows.Forms.Button btnClearTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb1Hour;
        private System.Windows.Forms.RadioButton rb40min;
        private System.Windows.Forms.RadioButton rb30min;
        private System.Windows.Forms.RadioButton rb10Min;
        private System.Windows.Forms.RadioButton rb20min;
        private System.Windows.Forms.RadioButton rbMannually;
    }
}

