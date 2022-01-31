
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
            this.SuspendLayout();
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.Location = new System.Drawing.Point(12, 12);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(637, 426);
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
            // Recipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateRow);
            this.Controls.Add(this.flpList);
            this.Name = "Recipes";
            this.Load += new System.EventHandler(this.Recipes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Button btnCreateRow;
    }
}