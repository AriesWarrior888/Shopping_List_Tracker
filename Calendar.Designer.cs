﻿
namespace Shopping_List_Tracker
{
    partial class Calendar
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcCalendar = new System.Windows.Forms.TabControl();
            this.tpWeek = new System.Windows.Forms.TabPage();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.btnWeekNext = new System.Windows.Forms.Button();
            this.btnWeekPrevious = new System.Windows.Forms.Button();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.tpDay = new System.Windows.Forms.TabPage();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnDayPrevious = new System.Windows.Forms.Button();
            this.btnDayNext = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcCalendar.SuspendLayout();
            this.tpWeek.SuspendLayout();
            this.tpDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.flpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnClose);
            this.splitContainer1.Panel1.Controls.Add(this.lblTitle);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcCalendar);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 109;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(385, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calendar";
            // 
            // tcCalendar
            // 
            this.tcCalendar.Controls.Add(this.tpWeek);
            this.tcCalendar.Controls.Add(this.tpDay);
            this.tcCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCalendar.Location = new System.Drawing.Point(0, 0);
            this.tcCalendar.Name = "tcCalendar";
            this.tcCalendar.SelectedIndex = 0;
            this.tcCalendar.Size = new System.Drawing.Size(800, 337);
            this.tcCalendar.TabIndex = 0;
            // 
            // tpWeek
            // 
            this.tpWeek.Controls.Add(this.lblMonday);
            this.tpWeek.Controls.Add(this.lblSunday);
            this.tpWeek.Controls.Add(this.btnWeekNext);
            this.tpWeek.Controls.Add(this.btnWeekPrevious);
            this.tpWeek.Controls.Add(this.lblSaturday);
            this.tpWeek.Controls.Add(this.lblFriday);
            this.tpWeek.Controls.Add(this.lblThursday);
            this.tpWeek.Controls.Add(this.lblWednesday);
            this.tpWeek.Controls.Add(this.lblTuesday);
            this.tpWeek.Location = new System.Drawing.Point(4, 22);
            this.tpWeek.Name = "tpWeek";
            this.tpWeek.Padding = new System.Windows.Forms.Padding(3);
            this.tpWeek.Size = new System.Drawing.Size(792, 311);
            this.tpWeek.TabIndex = 0;
            this.tpWeek.Text = "Week";
            this.tpWeek.UseVisualStyleBackColor = true;
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(159, 51);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(45, 13);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Monday";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(54, 51);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(43, 13);
            this.lblSunday.TabIndex = 0;
            this.lblSunday.Text = "Sunday";
            // 
            // btnWeekNext
            // 
            this.btnWeekNext.Location = new System.Drawing.Point(753, 98);
            this.btnWeekNext.Name = "btnWeekNext";
            this.btnWeekNext.Size = new System.Drawing.Size(36, 83);
            this.btnWeekNext.TabIndex = 8;
            this.btnWeekNext.Text = ">";
            this.btnWeekNext.UseVisualStyleBackColor = true;
            this.btnWeekNext.Click += new System.EventHandler(this.btnWeekNext_Click);
            // 
            // btnWeekPrevious
            // 
            this.btnWeekPrevious.Location = new System.Drawing.Point(1, 98);
            this.btnWeekPrevious.Name = "btnWeekPrevious";
            this.btnWeekPrevious.Size = new System.Drawing.Size(36, 83);
            this.btnWeekPrevious.TabIndex = 7;
            this.btnWeekPrevious.Text = "<";
            this.btnWeekPrevious.UseVisualStyleBackColor = true;
            this.btnWeekPrevious.Click += new System.EventHandler(this.btnWeekPrevious_Click);
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Location = new System.Drawing.Point(684, 51);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(49, 13);
            this.lblSaturday.TabIndex = 6;
            this.lblSaturday.Text = "Saturday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(579, 51);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(35, 13);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(474, 51);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(51, 13);
            this.lblThursday.TabIndex = 4;
            this.lblThursday.Text = "Thursday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(369, 51);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(64, 13);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Wednesday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(264, 51);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(48, 13);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Tuesday";
            // 
            // tpDay
            // 
            this.tpDay.Controls.Add(this.btnCreate);
            this.tpDay.Controls.Add(this.flpList);
            this.tpDay.Controls.Add(this.btnDayNext);
            this.tpDay.Controls.Add(this.btnDayPrevious);
            this.tpDay.Controls.Add(this.lblDay);
            this.tpDay.Location = new System.Drawing.Point(4, 22);
            this.tpDay.Name = "tpDay";
            this.tpDay.Padding = new System.Windows.Forms.Padding(3);
            this.tpDay.Size = new System.Drawing.Size(792, 311);
            this.tpDay.TabIndex = 1;
            this.tpDay.Text = "Day";
            this.tpDay.UseVisualStyleBackColor = true;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(381, 27);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Today";
            // 
            // btnDayPrevious
            // 
            this.btnDayPrevious.Location = new System.Drawing.Point(1, 98);
            this.btnDayPrevious.Name = "btnDayPrevious";
            this.btnDayPrevious.Size = new System.Drawing.Size(36, 83);
            this.btnDayPrevious.TabIndex = 1;
            this.btnDayPrevious.Text = "button1";
            this.btnDayPrevious.UseVisualStyleBackColor = true;
            this.btnDayPrevious.Click += new System.EventHandler(this.btnDayPrevious_Click);
            // 
            // btnDayNext
            // 
            this.btnDayNext.Location = new System.Drawing.Point(753, 98);
            this.btnDayNext.Name = "btnDayNext";
            this.btnDayNext.Size = new System.Drawing.Size(36, 83);
            this.btnDayNext.TabIndex = 2;
            this.btnDayNext.Text = "button2";
            this.btnDayNext.UseVisualStyleBackColor = true;
            this.btnDayNext.Click += new System.EventHandler(this.btnDayNext_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(141, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(30, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // flpList
            // 
            this.flpList.Controls.Add(this.comboBox1);
            this.flpList.Controls.Add(this.numericUpDown1);
            this.flpList.Controls.Add(this.button1);
            this.flpList.Location = new System.Drawing.Point(283, 64);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(235, 230);
            this.flpList.TabIndex = 6;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(524, 272);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(20, 22);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "+";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcCalendar.ResumeLayout(false);
            this.tpWeek.ResumeLayout(false);
            this.tpWeek.PerformLayout();
            this.tpDay.ResumeLayout(false);
            this.tpDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.flpList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tcCalendar;
        private System.Windows.Forms.TabPage tpWeek;
        private System.Windows.Forms.TabPage tpDay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblSunday;
        private System.Windows.Forms.Button btnWeekNext;
        private System.Windows.Forms.Button btnWeekPrevious;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Button btnDayNext;
        private System.Windows.Forms.Button btnDayPrevious;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}