namespace StudentsManagementSystem.Forms
{
    partial class StudentRegistrationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.conformPasswordValidationLabel = new System.Windows.Forms.Label();
            this.passwordValidationLabel = new System.Windows.Forms.Label();
            this.emailValidationLabel = new System.Windows.Forms.Label();
            this.departmentValidationLabel = new System.Windows.Forms.Label();
            this.rollNumberValidationLabel = new System.Windows.Forms.Label();
            this.nameValidationLabel = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.departmentCBox = new System.Windows.Forms.ComboBox();
            this.conformPasswordTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.rollNumberTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Details Correctly";
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(0, 750);
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.conformPasswordValidationLabel);
            this.panel1.Controls.Add(this.passwordValidationLabel);
            this.panel1.Controls.Add(this.emailValidationLabel);
            this.panel1.Controls.Add(this.departmentValidationLabel);
            this.panel1.Controls.Add(this.rollNumberValidationLabel);
            this.panel1.Controls.Add(this.nameValidationLabel);
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.departmentCBox);
            this.panel1.Controls.Add(this.conformPasswordTxt);
            this.panel1.Controls.Add(this.passwordTxt);
            this.panel1.Controls.Add(this.emailTxt);
            this.panel1.Controls.Add(this.rollNumberTxt);
            this.panel1.Controls.Add(this.nameTxt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 500);
            this.panel1.TabIndex = 1;
            // 
            // conformPasswordValidationLabel
            // 
            this.conformPasswordValidationLabel.AutoSize = true;
            this.conformPasswordValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conformPasswordValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.conformPasswordValidationLabel.Location = new System.Drawing.Point(64, 605);
            this.conformPasswordValidationLabel.Name = "conformPasswordValidationLabel";
            this.conformPasswordValidationLabel.Size = new System.Drawing.Size(153, 16);
            this.conformPasswordValidationLabel.TabIndex = 19;
            this.conformPasswordValidationLabel.Text = "Password doesn\'t match";
            this.conformPasswordValidationLabel.Visible = false;
            // 
            // passwordValidationLabel
            // 
            this.passwordValidationLabel.AutoSize = true;
            this.passwordValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordValidationLabel.Location = new System.Drawing.Point(64, 508);
            this.passwordValidationLabel.Name = "passwordValidationLabel";
            this.passwordValidationLabel.Size = new System.Drawing.Size(191, 16);
            this.passwordValidationLabel.TabIndex = 18;
            this.passwordValidationLabel.Text = "Password must 5 - 20 character";
            this.passwordValidationLabel.Visible = false;
            // 
            // emailValidationLabel
            // 
            this.emailValidationLabel.AutoSize = true;
            this.emailValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.emailValidationLabel.Location = new System.Drawing.Point(64, 408);
            this.emailValidationLabel.Name = "emailValidationLabel";
            this.emailValidationLabel.Size = new System.Drawing.Size(128, 16);
            this.emailValidationLabel.TabIndex = 17;
            this.emailValidationLabel.Text = "Email doesn\'t empty";
            this.emailValidationLabel.Visible = false;
            // 
            // departmentValidationLabel
            // 
            this.departmentValidationLabel.AutoSize = true;
            this.departmentValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.departmentValidationLabel.Location = new System.Drawing.Point(64, 324);
            this.departmentValidationLabel.Name = "departmentValidationLabel";
            this.departmentValidationLabel.Size = new System.Drawing.Size(327, 16);
            this.departmentValidationLabel.TabIndex = 16;
            this.departmentValidationLabel.Text = "Please Select Department. Department doesn\'t empty";
            this.departmentValidationLabel.Visible = false;
            // 
            // rollNumberValidationLabel
            // 
            this.rollNumberValidationLabel.AutoSize = true;
            this.rollNumberValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollNumberValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.rollNumberValidationLabel.Location = new System.Drawing.Point(64, 234);
            this.rollNumberValidationLabel.Name = "rollNumberValidationLabel";
            this.rollNumberValidationLabel.Size = new System.Drawing.Size(169, 16);
            this.rollNumberValidationLabel.TabIndex = 15;
            this.rollNumberValidationLabel.Text = "Roll Number doesn\'t empty";
            this.rollNumberValidationLabel.Visible = false;
            // 
            // nameValidationLabel
            // 
            this.nameValidationLabel.AutoSize = true;
            this.nameValidationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValidationLabel.ForeColor = System.Drawing.Color.Red;
            this.nameValidationLabel.Location = new System.Drawing.Point(64, 139);
            this.nameValidationLabel.Name = "nameValidationLabel";
            this.nameValidationLabel.Size = new System.Drawing.Size(131, 16);
            this.nameValidationLabel.TabIndex = 14;
            this.nameValidationLabel.Text = "Name doesn\'t empty";
            this.nameValidationLabel.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(260, 669);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(100, 30);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.Blue;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.ForeColor = System.Drawing.Color.White;
            this.submitBtn.Location = new System.Drawing.Point(366, 669);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(100, 30);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // departmentCBox
            // 
            this.departmentCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentCBox.FormattingEnabled = true;
            this.departmentCBox.Items.AddRange(new object[] {
            "BCA",
            "BBA",
            "BSCIT",
            "BCOM",
            "ISC"});
            this.departmentCBox.Location = new System.Drawing.Point(66, 293);
            this.departmentCBox.Name = "departmentCBox";
            this.departmentCBox.Size = new System.Drawing.Size(150, 28);
            this.departmentCBox.TabIndex = 3;
            // 
            // conformPasswordTxt
            // 
            this.conformPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conformPasswordTxt.Location = new System.Drawing.Point(66, 576);
            this.conformPasswordTxt.Name = "conformPasswordTxt";
            this.conformPasswordTxt.Size = new System.Drawing.Size(400, 26);
            this.conformPasswordTxt.TabIndex = 6;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(66, 479);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(400, 26);
            this.passwordTxt.TabIndex = 5;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(66, 379);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(400, 26);
            this.emailTxt.TabIndex = 4;
            // 
            // rollNumberTxt
            // 
            this.rollNumberTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollNumberTxt.Location = new System.Drawing.Point(66, 205);
            this.rollNumberTxt.Name = "rollNumberTxt";
            this.rollNumberTxt.Size = new System.Drawing.Size(400, 26);
            this.rollNumberTxt.TabIndex = 2;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(66, 110);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(400, 26);
            this.nameTxt.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Conform Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Select Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Roll Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "StudentRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox departmentCBox;
        private System.Windows.Forms.TextBox conformPasswordTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox rollNumberTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label nameValidationLabel;
        private System.Windows.Forms.Label conformPasswordValidationLabel;
        private System.Windows.Forms.Label passwordValidationLabel;
        private System.Windows.Forms.Label emailValidationLabel;
        private System.Windows.Forms.Label departmentValidationLabel;
        private System.Windows.Forms.Label rollNumberValidationLabel;
    }
}