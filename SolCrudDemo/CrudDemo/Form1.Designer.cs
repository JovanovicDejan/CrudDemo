﻿namespace CrudDemo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.chkDiscontinued = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInsertForm = new System.Windows.Forms.Button();
            this.txtProductIdentif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Naziv proizvoda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(125, 30);
            this.txtNaziv.MaxLength = 40;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(121, 20);
            this.txtNaziv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "&Unit price";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(125, 70);
            this.txtSupplier.MaxLength = 40;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(121, 20);
            this.txtSupplier.TabIndex = 8;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(125, 108);
            this.txtCategory.MaxLength = 40;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(121, 20);
            this.txtCategory.TabIndex = 9;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(125, 149);
            this.txtUnitPrice.MaxLength = 40;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(121, 20);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.AutoSize = true;
            this.chkDiscontinued.Location = new System.Drawing.Point(125, 201);
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Size = new System.Drawing.Size(88, 17);
            this.chkDiscontinued.TabIndex = 11;
            this.chkDiscontinued.Text = "Discontinued";
            this.chkDiscontinued.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(57, 242);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(223, 74);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert Product";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnInsertForm
            // 
            this.btnInsertForm.Location = new System.Drawing.Point(57, 372);
            this.btnInsertForm.Name = "btnInsertForm";
            this.btnInsertForm.Size = new System.Drawing.Size(223, 59);
            this.btnInsertForm.TabIndex = 13;
            this.btnInsertForm.Text = "Open new form";
            this.btnInsertForm.UseVisualStyleBackColor = true;
            this.btnInsertForm.Click += new System.EventHandler(this.btnInsertForm_Click);
            // 
            // txtProductIdentif
            // 
            this.txtProductIdentif.Location = new System.Drawing.Point(431, 313);
            this.txtProductIdentif.MaxLength = 40;
            this.txtProductIdentif.Name = "txtProductIdentif";
            this.txtProductIdentif.Size = new System.Drawing.Size(121, 20);
            this.txtProductIdentif.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "&Productid";
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(332, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(223, 74);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnUpdate.Location = new System.Drawing.Point(630, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(223, 74);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 653);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtProductIdentif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertForm);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.chkDiscontinued);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.CheckBox chkDiscontinued;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnInsertForm;
        private System.Windows.Forms.TextBox txtProductIdentif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}

