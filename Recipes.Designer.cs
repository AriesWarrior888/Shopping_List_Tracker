
namespace Shopping_List_Tracker
{
    partial class Recipes
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
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateRow = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRec = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.Location = new System.Drawing.Point(12, 42);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(637, 396);
            this.flpList.TabIndex = 0;
            // 
            // btnCreateRow
            // 
            this.btnCreateRow.Location = new System.Drawing.Point(655, 202);
            this.btnCreateRow.Name = "btnCreateRow";
            this.btnCreateRow.Size = new System.Drawing.Size(139, 20);
            this.btnCreateRow.TabIndex = 1;
            this.btnCreateRow.Text = "Create Row";
            this.btnCreateRow.UseVisualStyleBackColor = true;
            this.btnCreateRow.Click += new System.EventHandler(this.btnCreateRow_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(321, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(46, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Recipes";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(673, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 48);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Location = new System.Drawing.Point(171, 28);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(41, 13);
            this.lblRec.TabIndex = 4;
            this.lblRec.Text = "Recipe";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(268, 26);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Description";
            // 
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCreateRow);
            this.Controls.Add(this.flpList);
            this.Name = "Recipes";
            this.Load += new System.EventHandler(this.Recipes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Button btnCreateRow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label lblDesc;
    }
}