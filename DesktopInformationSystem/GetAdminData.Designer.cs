namespace DesktopInformationSystem
{
    partial class GetAdminData
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
            this.confirmBtn = new System.Windows.Forms.Button();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.teleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.salaryNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.positionCombo = new System.Windows.Forms.ComboBox();
            this.workBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNum)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmBtn
            // 
            this.confirmBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmBtn.Location = new System.Drawing.Point(235, 478);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(335, 55);
            this.confirmBtn.TabIndex = 13;
            this.confirmBtn.Text = "CONFIRM";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(160, 219);
            this.emailBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(245, 36);
            this.emailBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email:";
            // 
            // teleBox
            // 
            this.teleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleBox.Location = new System.Drawing.Point(219, 135);
            this.teleBox.Margin = new System.Windows.Forms.Padding(4);
            this.teleBox.Name = "teleBox";
            this.teleBox.Size = new System.Drawing.Size(205, 36);
            this.teleBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 16;
            this.label1.Text = "Telephone:";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(160, 47);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(245, 36);
            this.nameBox.TabIndex = 15;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(12, 42);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(117, 39);
            this.nameLbl.TabIndex = 14;
            this.nameLbl.Text = "Name:";
            // 
            // salaryNum
            // 
            this.salaryNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryNum.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.salaryNum.Location = new System.Drawing.Point(572, 290);
            this.salaryNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salaryNum.Maximum = new decimal(new int[] {
            500000,
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
            this.salaryNum.TabIndex = 20;
            this.salaryNum.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 39);
            this.label4.TabIndex = 22;
            this.label4.Text = "Working Hours:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 39);
            this.label5.TabIndex = 23;
            this.label5.Text = "Position:";
            // 
            // positionCombo
            // 
            this.positionCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionCombo.FormattingEnabled = true;
            this.positionCombo.Items.AddRange(new object[] {
            "Full-TIme",
            "Part-Time"});
            this.positionCombo.Location = new System.Drawing.Point(165, 294);
            this.positionCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.positionCombo.Name = "positionCombo";
            this.positionCombo.Size = new System.Drawing.Size(177, 37);
            this.positionCombo.TabIndex = 24;
            // 
            // workBox
            // 
            this.workBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workBox.Location = new System.Drawing.Point(289, 382);
            this.workBox.Margin = new System.Windows.Forms.Padding(4);
            this.workBox.Name = "workBox";
            this.workBox.Size = new System.Drawing.Size(205, 36);
            this.workBox.TabIndex = 25;
            // 
            // GetAdminData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.workBox);
            this.Controls.Add(this.positionCombo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.salaryNum);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teleBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.confirmBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetAdminData";
            this.Text = "GetAdminData";
            ((System.ComponentModel.ISupportInitialize)(this.salaryNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.NumericUpDown salaryNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox positionCombo;
        private System.Windows.Forms.TextBox workBox;
    }
}