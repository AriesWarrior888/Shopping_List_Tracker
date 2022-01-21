
namespace Shopping_List_Tracker
{
    partial class CreateRecipe
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtServingCount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.flpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(-2, 416);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(685, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(50, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(600, 31);
            this.txtName.TabIndex = 2;
            // 
            // txtServingCount
            // 
            this.txtServingCount.Location = new System.Drawing.Point(656, 22);
            this.txtServingCount.Name = "txtServingCount";
            this.txtServingCount.Size = new System.Drawing.Size(38, 20);
            this.txtServingCount.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(50, 61);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(644, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // flpList
            // 
            this.flpList.AutoScroll = true;
            this.flpList.Controls.Add(this.txtIngredient);
            this.flpList.Controls.Add(this.txtQTY);
            this.flpList.Controls.Add(this.btnCreate);
            this.flpList.Location = new System.Drawing.Point(50, 104);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(657, 307);
            this.flpList.TabIndex = 5;
            // 
            // txtIngredient
            // 
            this.txtIngredient.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredient.Location = new System.Drawing.Point(3, 3);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(565, 20);
            this.txtIngredient.TabIndex = 0;
            // 
            // txtQTY
            // 
            this.txtQTY.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTY.Location = new System.Drawing.Point(574, 3);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(64, 20);
            this.txtQTY.TabIndex = 1;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 29);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(635, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Create Row";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpList);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtServingCount);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "CreateRecipe";
            this.Text = "CreateRecipe";
            this.Load += new System.EventHandler(this.frmRecipe_Load);
            this.flpList.ResumeLayout(false);
            this.flpList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtServingCount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.Button btnCreate;
    }
}