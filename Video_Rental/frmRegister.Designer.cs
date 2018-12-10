namespace Video_Rental
{
    partial class frmRegister
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.enterage_lable = new System.Windows.Forms.Label();
            this.entername_label = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsrName = new System.Windows.Forms.TextBox();
            this.enterpassword_label = new System.Windows.Forms.Label();
            this.enterusername_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(181, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registeration Area";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(389, 377);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(164, 52);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnregister
            // 
            this.btnregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.Location = new System.Drawing.Point(165, 383);
            this.btnregister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(164, 52);
            this.btnregister.TabIndex = 14;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(389, 170);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(233, 37);
            this.txtAge.TabIndex = 13;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(389, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 37);
            this.txtName.TabIndex = 12;
            // 
            // enterage_lable
            // 
            this.enterage_lable.AutoSize = true;
            this.enterage_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterage_lable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterage_lable.Location = new System.Drawing.Point(96, 170);
            this.enterage_lable.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.enterage_lable.Name = "enterage_lable";
            this.enterage_lable.Size = new System.Drawing.Size(143, 31);
            this.enterage_lable.TabIndex = 11;
            this.enterage_lable.Text = "Enter Age";
            // 
            // entername_label
            // 
            this.entername_label.AutoSize = true;
            this.entername_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entername_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.entername_label.Location = new System.Drawing.Point(96, 105);
            this.entername_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.entername_label.Name = "entername_label";
            this.entername_label.Size = new System.Drawing.Size(168, 31);
            this.entername_label.TabIndex = 10;
            this.entername_label.Text = "Enter Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(389, 293);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(233, 37);
            this.txtPassword.TabIndex = 19;
            // 
            // txtUsrName
            // 
            this.txtUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsrName.Location = new System.Drawing.Point(389, 230);
            this.txtUsrName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsrName.Name = "txtUsrName";
            this.txtUsrName.Size = new System.Drawing.Size(233, 37);
            this.txtUsrName.TabIndex = 18;
            // 
            // enterpassword_label
            // 
            this.enterpassword_label.AutoSize = true;
            this.enterpassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterpassword_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterpassword_label.Location = new System.Drawing.Point(96, 293);
            this.enterpassword_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.enterpassword_label.Name = "enterpassword_label";
            this.enterpassword_label.Size = new System.Drawing.Size(220, 31);
            this.enterpassword_label.TabIndex = 17;
            this.enterpassword_label.Text = "Enter Password";
            // 
            // enterusername_label
            // 
            this.enterusername_label.AutoSize = true;
            this.enterusername_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterusername_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.enterusername_label.Location = new System.Drawing.Point(96, 228);
            this.enterusername_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.enterusername_label.Name = "enterusername_label";
            this.enterusername_label.Size = new System.Drawing.Size(238, 31);
            this.enterusername_label.TabIndex = 16;
            this.enterusername_label.Text = "Enter User Name";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(744, 503);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsrName);
            this.Controls.Add(this.enterpassword_label);
            this.Controls.Add(this.enterusername_label);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.enterage_lable);
            this.Controls.Add(this.entername_label);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label enterage_lable;
        private System.Windows.Forms.Label entername_label;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsrName;
        private System.Windows.Forms.Label enterpassword_label;
        private System.Windows.Forms.Label enterusername_label;
    }
}