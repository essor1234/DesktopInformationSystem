﻿namespace DesktopInformationSystem
{
    partial class GetTeacherData
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
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNum)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(169, 206);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(245, 36);
            this.emailBox.TabIndex = 11;
            this.emailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 39);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email:";
            // 
            // teleBox
            // 
            this.teleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleBox.Location = new System.Drawing.Point(227, 122);
            this.teleBox.Margin = new System.Windows.Forms.Padding(4);
            this.teleBox.Name = "teleBox";
            this.teleBox.Size = new System.Drawing.Size(245, 36);
            this.teleBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Telephone:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(169, 34);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(245, 36);
            this.nameBox.TabIndex = 7;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(21, 30);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(117, 39);
            this.nameLbl.TabIndex = 6;
            this.nameLbl.Text = "Name:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MATH",
            "LITERATURE",
            "PHYSIC",
            "CHEMISTRY",
            "GEOMETRIC"});
            this.comboBox2.Location = new System.Drawing.Point(600, 303);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MATH",
            "LITERATURE",
            "PHYSIC",
            "CHEMISTRY",
            "GEOMETRIC"});
            this.comboBox1.Location = new System.Drawing.Point(389, 303);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Curent Subject (required 2): ";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(213, 367);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(335, 55);
            this.confirmBtn.TabIndex = 15;
            this.confirmBtn.Text = "CONFIRM";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "Salary:";
            // 
            // salaryNum
            // 
            this.salaryNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryNum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.salaryNum.Location = new System.Drawing.Point(605, 210);
            this.salaryNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryNum.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.salaryNum.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.salaryNum.Name = "salaryNum";
            this.salaryNum.Size = new System.Drawing.Size(180, 36);
            this.salaryNum.TabIndex = 22;
            this.salaryNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // GetTeacherData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.salaryNum);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetTeacherData";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GetTeacherData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown salaryNum;
    }
}