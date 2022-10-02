
namespace school_management_system
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
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.tbfathername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbrollno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbcnic = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "  STUDENT NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbfirstname
            // 
            this.tbfirstname.Location = new System.Drawing.Point(294, 40);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(100, 22);
            this.tbfirstname.TabIndex = 1;
            // 
            // tbfathername
            // 
            this.tbfathername.Location = new System.Drawing.Point(294, 81);
            this.tbfathername.Name = "tbfathername";
            this.tbfathername.Size = new System.Drawing.Size(100, 22);
            this.tbfathername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FATHER NAME";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbrollno
            // 
            this.tbrollno.Location = new System.Drawing.Point(294, 126);
            this.tbrollno.Name = "tbrollno";
            this.tbrollno.Size = new System.Drawing.Size(100, 22);
            this.tbrollno.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ROLL NO";
            // 
            // tbcnic
            // 
            this.tbcnic.Location = new System.Drawing.Point(294, 172);
            this.tbcnic.Name = "tbcnic";
            this.tbcnic.Size = new System.Drawing.Size(100, 22);
            this.tbcnic.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = " CNIC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcnic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbrollno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbfathername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbfirstname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbfirstname;
        private System.Windows.Forms.TextBox tbfathername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbrollno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbcnic;
        private System.Windows.Forms.Label label4;
    }
}

