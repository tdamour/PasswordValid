namespace PassWordProgram
{
    partial class PasswordDataForm
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
            this.checkPasswordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.txtPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFullNameTextBox = new System.Windows.Forms.TextBox();
            this.txtUserNameTextBox = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(916, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter your UserName, Full Name, and Password : ";
            // 
            // checkPasswordButton
            // 
            this.checkPasswordButton.Location = new System.Drawing.Point(341, 701);
            this.checkPasswordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkPasswordButton.Name = "checkPasswordButton";
            this.checkPasswordButton.Size = new System.Drawing.Size(280, 117);
            this.checkPasswordButton.TabIndex = 1;
            this.checkPasswordButton.Text = "Check Password";
            this.checkPasswordButton.UseVisualStyleBackColor = true;
            this.checkPasswordButton.Click += new System.EventHandler(this.checkPasswordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(731, 701);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(280, 117);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // txtPasswordTextBox
            // 
            this.txtPasswordTextBox.Location = new System.Drawing.Point(311, 547);
            this.txtPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordTextBox.Name = "txtPasswordTextBox";
            this.txtPasswordTextBox.Size = new System.Drawing.Size(735, 38);
            this.txtPasswordTextBox.TabIndex = 3;
            this.txtPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 484);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter A Password : ";
            // 
            // txtFullNameTextBox
            // 
            this.txtFullNameTextBox.Location = new System.Drawing.Point(311, 371);
            this.txtFullNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtFullNameTextBox.Name = "txtFullNameTextBox";
            this.txtFullNameTextBox.Size = new System.Drawing.Size(735, 38);
            this.txtFullNameTextBox.TabIndex = 4;
            // 
            // txtUserNameTextBox
            // 
            this.txtUserNameTextBox.Location = new System.Drawing.Point(311, 221);
            this.txtUserNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtUserNameTextBox.Name = "txtUserNameTextBox";
            this.txtUserNameTextBox.Size = new System.Drawing.Size(735, 38);
            this.txtUserNameTextBox.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(303, 149);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(272, 32);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "Enter A UserName : ";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(303, 315);
            this.lblFullName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(308, 32);
            this.lblFullName.TabIndex = 8;
            this.lblFullName.Text = "Enter Your Full Name : ";
            // 
            // PasswordDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 863);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullNameTextBox);
            this.Controls.Add(this.txtPasswordTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.checkPasswordButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PasswordDataForm";
            this.Text = "Password Data";
            this.Load += new System.EventHandler(this.PasswordDataForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkPasswordButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox txtPasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFullNameTextBox;
        private System.Windows.Forms.TextBox txtUserNameTextBox;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblFullName;
    }
}

