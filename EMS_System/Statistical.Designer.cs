namespace EMS_System
{
    partial class Statistical
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
            this.salRep_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDisplayAllEmp = new System.Windows.Forms.Button();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.gender_label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // salRep_comboBox
            // 
            this.salRep_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.salRep_comboBox.FormattingEnabled = true;
            this.salRep_comboBox.Location = new System.Drawing.Point(42, 105);
            this.salRep_comboBox.Name = "salRep_comboBox";
            this.salRep_comboBox.Size = new System.Drawing.Size(367, 37);
            this.salRep_comboBox.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Department Salary Report";
            // 
            // btnDisplayAllEmp
            // 
            this.btnDisplayAllEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDisplayAllEmp.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.btnDisplayAllEmp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDisplayAllEmp.Location = new System.Drawing.Point(281, 342);
            this.btnDisplayAllEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplayAllEmp.Name = "btnDisplayAllEmp";
            this.btnDisplayAllEmp.Size = new System.Drawing.Size(218, 43);
            this.btnDisplayAllEmp.TabIndex = 45;
            this.btnDisplayAllEmp.Text = "GENERATE REPORT";
            this.btnDisplayAllEmp.UseVisualStyleBackColor = false;
            // 
            // genderCmb
            // 
            this.genderCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Location = new System.Drawing.Point(42, 221);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(367, 37);
            this.genderCmb.TabIndex = 49;
            // 
            // gender_label1
            // 
            this.gender_label1.AutoSize = true;
            this.gender_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_label1.Location = new System.Drawing.Point(37, 172);
            this.gender_label1.Name = "gender_label1";
            this.gender_label1.Size = new System.Drawing.Size(372, 29);
            this.gender_label1.TabIndex = 48;
            this.gender_label1.Text = "Gender Ratio Department  Report";
            // 
            // Statistical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.genderCmb);
            this.Controls.Add(this.gender_label1);
            this.Controls.Add(this.salRep_comboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDisplayAllEmp);
            this.Name = "Statistical";
            this.Text = "StatisticalReportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox salRep_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDisplayAllEmp;
        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.Label gender_label1;
    }
}