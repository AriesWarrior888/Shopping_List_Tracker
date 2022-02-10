
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tcCalendar = new System.Windows.Forms.TabControl();
            this.tpWeek = new System.Windows.Forms.TabPage();
            this.tpDay = new System.Windows.Forms.TabPage();
            this.lblDay = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.btnWeekPrevious = new System.Windows.Forms.Button();
            this.btnWeekNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcCalendar.SuspendLayout();
            this.tpWeek.SuspendLayout();
            this.tpDay.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.tpWeek.Controls.Add(this.groupBox1);
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
            // tpDay
            // 
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
            this.lblDay.Location = new System.Drawing.Point(381, 48);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Today";
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
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Location = new System.Drawing.Point(14, 26);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(43, 13);
            this.lblSunday.TabIndex = 0;
            this.lblSunday.Text = "Sunday";
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
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(369, 51);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(64, 13);
            this.lblWednesday.TabIndex = 3;
            this.lblWednesday.Text = "Wednesday";
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
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(579, 51);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(35, 13);
            this.lblFriday.TabIndex = 5;
            this.lblFriday.Text = "Friday";
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
            // btnWeekPrevious
            // 
            this.btnWeekPrevious.Location = new System.Drawing.Point(1, 98);
            this.btnWeekPrevious.Name = "btnWeekPrevious";
            this.btnWeekPrevious.Size = new System.Drawing.Size(36, 83);
            this.btnWeekPrevious.TabIndex = 7;
            this.btnWeekPrevious.Text = "<";
            this.btnWeekPrevious.UseVisualStyleBackColor = true;
            // 
            // btnWeekNext
            // 
            this.btnWeekNext.Location = new System.Drawing.Point(753, 98);
            this.btnWeekNext.Name = "btnWeekNext";
            this.btnWeekNext.Size = new System.Drawing.Size(36, 83);
            this.btnWeekNext.TabIndex = 8;
            this.btnWeekNext.Text = ">";
            this.btnWeekNext.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblSunday);
            this.groupBox1.Location = new System.Drawing.Point(40, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 194);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(110, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 194);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunday";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(179, 51);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(45, 13);
            this.lblMonday.TabIndex = 1;
            this.lblMonday.Text = "Monday";
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}