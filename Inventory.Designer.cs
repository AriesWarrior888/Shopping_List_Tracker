﻿
namespace Shopping_List_Tracker
{
    partial class Inventory
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
            this.lblInventory = new System.Windows.Forms.Label();
            this.flpInventory = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Location = new System.Drawing.Point(387, 9);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(51, 13);
            this.lblInventory.TabIndex = 0;
            this.lblInventory.Text = "Inventory";
            // 
            // flpInventory
            // 
            this.flpInventory.AutoScroll = true;
            this.flpInventory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpInventory.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpInventory.Location = new System.Drawing.Point(97, 53);
            this.flpInventory.Name = "flpInventory";
            this.flpInventory.Size = new System.Drawing.Size(627, 343);
            this.flpInventory.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(649, 402);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(728, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.flpInventory);
            this.Controls.Add(this.lblInventory);
            this.Name = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.FlowLayoutPanel flpInventory;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}