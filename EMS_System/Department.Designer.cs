namespace EMS_System
{
    partial class Department
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
            this.allEmpDep_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dispAllEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // allEmpDep_txt
            // 
            this.allEmpDep_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.allEmpDep_txt.Location = new System.Drawing.Point(265, 117);
            this.allEmpDep_txt.Margin = new System.Windows.Forms.Padding(4);
            this.allEmpDep_txt.Name = "allEmpDep_txt";
            this.allEmpDep_txt.Size = new System.Drawing.Size(288, 41);
            this.allEmpDep_txt.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Department";
            // 
            // btn_dispAllEmp
            // 
            this.btn_dispAllEmp.BackColor = System.Drawing.Color.Plum;
            this.btn_dispAllEmp.Font = new System.Drawing.Font("Goudy Old Style", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dispAllEmp.Location = new System.Drawing.Point(118, 269);
            this.btn_dispAllEmp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dispAllEmp.Name = "btn_dispAllEmp";
            this.btn_dispAllEmp.Size = new System.Drawing.Size(390, 86);
            this.btn_dispAllEmp.TabIndex = 22;
            this.btn_dispAllEmp.Text = "Display all Employees in the Department ";
            this.btn_dispAllEmp.UseVisualStyleBackColor = false;
            this.btn_dispAllEmp.Click += new System.EventHandler(this.btn_dispAllEmp_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dispAllEmp);
            this.Controls.Add(this.allEmpDep_txt);
            this.Controls.Add(this.label3);
            this.Name = "Department";
            this.Text = "Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox allEmpDep_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dispAllEmp;
    }
}