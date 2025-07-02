namespace EMS_System
{
    partial class EMS_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMS_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.emp_button = new System.Windows.Forms.Button();
            this.dep_btn = new System.Windows.Forms.Button();
            this.rep_btn = new System.Windows.Forms.Button();
            this.emp_img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.emp_img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Font = new System.Drawing.Font("Acuta Medium", 26F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Thistle;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(762, 55);
            this.label1.TabIndex = 21;
            this.label1.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            // 
            // emp_button
            // 
            this.emp_button.BackColor = System.Drawing.Color.Thistle;
            this.emp_button.Font = new System.Drawing.Font("Acuta Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_button.Location = new System.Drawing.Point(96, 156);
            this.emp_button.Name = "emp_button";
            this.emp_button.Size = new System.Drawing.Size(196, 71);
            this.emp_button.TabIndex = 23;
            this.emp_button.Text = "EMPLOYEE";
            this.emp_button.UseVisualStyleBackColor = false;
            this.emp_button.Click += new System.EventHandler(this.emp_button_Click);
            // 
            // dep_btn
            // 
            this.dep_btn.BackColor = System.Drawing.Color.Thistle;
            this.dep_btn.Font = new System.Drawing.Font("Acuta Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_btn.Location = new System.Drawing.Point(343, 156);
            this.dep_btn.Name = "dep_btn";
            this.dep_btn.Size = new System.Drawing.Size(196, 71);
            this.dep_btn.TabIndex = 24;
            this.dep_btn.Text = "DEPARTMENT";
            this.dep_btn.UseVisualStyleBackColor = false;
            this.dep_btn.Click += new System.EventHandler(this.dep_btn_Click);
            // 
            // rep_btn
            // 
            this.rep_btn.BackColor = System.Drawing.Color.Thistle;
            this.rep_btn.Font = new System.Drawing.Font("Acuta Medium", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rep_btn.Location = new System.Drawing.Point(607, 156);
            this.rep_btn.Name = "rep_btn";
            this.rep_btn.Size = new System.Drawing.Size(196, 71);
            this.rep_btn.TabIndex = 25;
            this.rep_btn.Text = "REPORTS";
            this.rep_btn.UseVisualStyleBackColor = false;
            this.rep_btn.Click += new System.EventHandler(this.rep_btn_Click);
            // 
            // emp_img
            // 
            this.emp_img.Image = ((System.Drawing.Image)(resources.GetObject("emp_img.Image")));
            this.emp_img.Location = new System.Drawing.Point(160, 270);
            this.emp_img.Name = "emp_img";
            this.emp_img.Size = new System.Drawing.Size(595, 397);
            this.emp_img.TabIndex = 26;
            this.emp_img.TabStop = false;
            // 
            // EMS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 692);
            this.Controls.Add(this.emp_img);
            this.Controls.Add(this.rep_btn);
            this.Controls.Add(this.dep_btn);
            this.Controls.Add(this.emp_button);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EMS_Form";
            this.Text = "Employee Management System";
            ((System.ComponentModel.ISupportInitialize)(this.emp_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emp_button;
        private System.Windows.Forms.Button dep_btn;
        private System.Windows.Forms.Button rep_btn;
        private System.Windows.Forms.PictureBox emp_img;
    }
}

