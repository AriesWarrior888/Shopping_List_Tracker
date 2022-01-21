
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreateRow = new System.Windows.Forms.Button();
            this.flpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.Controls.Add(this.btnDelete);
            this.flpList.Controls.Add(this.btnRecipe);
            this.flpList.Controls.Add(this.txtDescription);
            this.flpList.Controls.Add(this.btnAdd);
            this.flpList.Location = new System.Drawing.Point(12, 12);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(637, 426);
            this.flpList.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(3, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 45);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRecipe
            // 
            this.btnRecipe.Location = new System.Drawing.Point(111, 3);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(145, 45);
            this.btnRecipe.TabIndex = 4;
            this.btnRecipe.Text = "Recipe";
            this.btnRecipe.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Arial Narrow", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(262, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(310, 45);
            this.txtDescription.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(578, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 45);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.flpList.ResumeLayout(false);
            this.flpList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreateRow;
        private System.Windows.Forms.Button btnRecipe;
        private System.Windows.Forms.TextBox txtDescription;
    }
}