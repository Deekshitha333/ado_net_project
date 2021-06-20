namespace ADO_NET_PROJECT
{
    partial class Form5
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
            this.btncheck = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.tbdid = new System.Windows.Forms.TextBox();
            this.tbsal = new System.Windows.Forms.TextBox();
            this.tbmail = new System.Windows.Forms.TextBox();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbdob = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btncheck.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(543, 315);
            this.btncheck.Margin = new System.Windows.Forms.Padding(4);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(106, 43);
            this.btncheck.TabIndex = 2;
            this.btncheck.Text = "CHECK";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnupdate.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(699, 315);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(113, 43);
            this.btnupdate.TabIndex = 4;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // tbdid
            // 
            this.tbdid.Location = new System.Drawing.Point(348, 315);
            this.tbdid.Margin = new System.Windows.Forms.Padding(4);
            this.tbdid.Name = "tbdid";
            this.tbdid.Size = new System.Drawing.Size(132, 22);
            this.tbdid.TabIndex = 31;
            // 
            // tbsal
            // 
            this.tbsal.Location = new System.Drawing.Point(348, 274);
            this.tbsal.Margin = new System.Windows.Forms.Padding(4);
            this.tbsal.Name = "tbsal";
            this.tbsal.Size = new System.Drawing.Size(132, 22);
            this.tbsal.TabIndex = 30;
            // 
            // tbmail
            // 
            this.tbmail.Location = new System.Drawing.Point(348, 229);
            this.tbmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbmail.Name = "tbmail";
            this.tbmail.Size = new System.Drawing.Size(132, 22);
            this.tbmail.TabIndex = 29;
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(348, 182);
            this.tbphone.Margin = new System.Windows.Forms.Padding(4);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(132, 22);
            this.tbphone.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "DEPTID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 278);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "SALARY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(220, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "MAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "PHONE";
            // 
            // tbdob
            // 
            this.tbdob.Location = new System.Drawing.Point(348, 137);
            this.tbdob.Margin = new System.Windows.Forms.Padding(4);
            this.tbdob.Name = "tbdob";
            this.tbdob.Size = new System.Drawing.Size(132, 22);
            this.tbdob.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "DOB";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(348, 91);
            this.tbname.Margin = new System.Windows.Forms.Padding(4);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(132, 22);
            this.tbname.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "EMPNAME";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 366);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 91);
            this.dataGridView1.TabIndex = 19;
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(348, 43);
            this.tbid.Margin = new System.Windows.Forms.Padding(4);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(132, 22);
            this.tbid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "EMPID";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 556);
            this.Controls.Add(this.tbdid);
            this.Controls.Add(this.tbsal);
            this.Controls.Add(this.tbmail);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbdob);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btncheck);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox tbdid;
        private System.Windows.Forms.TextBox tbsal;
        private System.Windows.Forms.TextBox tbmail;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbdob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label1;
    }
}