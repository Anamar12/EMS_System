namespace EMS_System
{
    partial class Employee
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
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.firstName_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.surname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dep_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salary_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.delEmp_btn = new System.Windows.Forms.Button();
            this.viewEmp_txt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Plum;
            this.btn_add.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(60, 472);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(221, 56);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "ADD EMPLOYEE";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txt_id.Location = new System.Drawing.Point(253, 30);
            this.txt_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(288, 41);
            this.txt_id.TabIndex = 12;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(37, 37);
            this.lbl_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(169, 31);
            this.lbl_id.TabIndex = 11;
            this.lbl_id.Text = "Employee ID";
            // 
            // firstName_txt
            // 
            this.firstName_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.firstName_txt.Location = new System.Drawing.Point(253, 107);
            this.firstName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.firstName_txt.Name = "firstName_txt";
            this.firstName_txt.Size = new System.Drawing.Size(288, 41);
            this.firstName_txt.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "First Name";
            // 
            // surname_txt
            // 
            this.surname_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.surname_txt.Location = new System.Drawing.Point(253, 191);
            this.surname_txt.Margin = new System.Windows.Forms.Padding(4);
            this.surname_txt.Name = "surname_txt";
            this.surname_txt.Size = new System.Drawing.Size(288, 41);
            this.surname_txt.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Surname";
            // 
            // dep_txt
            // 
            this.dep_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dep_txt.Location = new System.Drawing.Point(253, 269);
            this.dep_txt.Margin = new System.Windows.Forms.Padding(4);
            this.dep_txt.Name = "dep_txt";
            this.dep_txt.Size = new System.Drawing.Size(288, 41);
            this.dep_txt.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Department";
            // 
            // salary_txt
            // 
            this.salary_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.salary_txt.Location = new System.Drawing.Point(257, 351);
            this.salary_txt.Margin = new System.Windows.Forms.Padding(4);
            this.salary_txt.Name = "salary_txt";
            this.salary_txt.Size = new System.Drawing.Size(288, 41);
            this.salary_txt.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 358);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Salary";
            // 
            // delEmp_btn
            // 
            this.delEmp_btn.BackColor = System.Drawing.Color.Plum;
            this.delEmp_btn.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delEmp_btn.Location = new System.Drawing.Point(318, 472);
            this.delEmp_btn.Margin = new System.Windows.Forms.Padding(4);
            this.delEmp_btn.Name = "delEmp_btn";
            this.delEmp_btn.Size = new System.Drawing.Size(253, 56);
            this.delEmp_btn.TabIndex = 22;
            this.delEmp_btn.Text = "DELETE EMPLOYEE";
            this.delEmp_btn.UseVisualStyleBackColor = false;
            this.delEmp_btn.Click += new System.EventHandler(this.delEmp_btn_Click);
            // 
            // viewEmp_txt
            // 
            this.viewEmp_txt.BackColor = System.Drawing.Color.Plum;
            this.viewEmp_txt.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewEmp_txt.Location = new System.Drawing.Point(601, 472);
            this.viewEmp_txt.Margin = new System.Windows.Forms.Padding(4);
            this.viewEmp_txt.Name = "viewEmp_txt";
            this.viewEmp_txt.Size = new System.Drawing.Size(221, 56);
            this.viewEmp_txt.TabIndex = 23;
            this.viewEmp_txt.Text = "VIEW EMPLOYEE";
            this.viewEmp_txt.UseVisualStyleBackColor = false;
            this.viewEmp_txt.Click += new System.EventHandler(this.viewEmp_txt_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 588);
            this.Controls.Add(this.viewEmp_txt);
            this.Controls.Add(this.delEmp_btn);
            this.Controls.Add(this.salary_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dep_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surname_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstName_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_id);
            this.Name = "Employee";
            this.Text = "Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox firstName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dep_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salary_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button delEmp_btn;
        private System.Windows.Forms.Button viewEmp_txt;
    }
}