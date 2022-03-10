namespace Prettybike
{
    partial class Login
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
            this.lbl_Connection = new System.Windows.Forms.Label();
            this.txtbox_Passwd = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txtbox_ID = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_Identif = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Connection
            // 
            this.lbl_Connection.AutoSize = true;
            this.lbl_Connection.Location = new System.Drawing.Point(619, 252);
            this.lbl_Connection.Name = "lbl_Connection";
            this.lbl_Connection.Size = new System.Drawing.Size(0, 25);
            this.lbl_Connection.TabIndex = 14;
            // 
            // txtbox_Passwd
            // 
            this.txtbox_Passwd.Location = new System.Drawing.Point(357, 276);
            this.txtbox_Passwd.Name = "txtbox_Passwd";
            this.txtbox_Passwd.Size = new System.Drawing.Size(150, 31);
            this.txtbox_Passwd.TabIndex = 13;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.Location = new System.Drawing.Point(215, 276);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(111, 32);
            this.lbl_password.TabIndex = 12;
            this.lbl_password.Text = "Password";
            this.lbl_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ID.Location = new System.Drawing.Point(263, 214);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(37, 32);
            this.lbl_ID.TabIndex = 11;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_ID
            // 
            this.txtbox_ID.Location = new System.Drawing.Point(357, 214);
            this.txtbox_ID.Name = "txtbox_ID";
            this.txtbox_ID.Size = new System.Drawing.Size(150, 31);
            this.txtbox_ID.TabIndex = 10;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_login.Location = new System.Drawing.Point(376, 349);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(112, 46);
            this.btn_login.TabIndex = 9;
            this.btn_login.Text = "LOG IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_Identif
            // 
            this.lbl_Identif.AutoSize = true;
            this.lbl_Identif.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Identif.Location = new System.Drawing.Point(152, 56);
            this.lbl_Identif.Name = "lbl_Identif";
            this.lbl_Identif.Size = new System.Drawing.Size(497, 96);
            this.lbl_Identif.TabIndex = 8;
            this.lbl_Identif.Text = "Identification";
            this.lbl_Identif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Identif.Click += new System.EventHandler(this.lbl_Identif_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Connection);
            this.Controls.Add(this.txtbox_Passwd);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txtbox_ID);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_Identif);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Connection;
        private TextBox txtbox_Passwd;
        private Label lbl_password;
        private Label lbl_ID;
        public TextBox txtbox_ID;
        private Button btn_login;
        private Label lbl_Identif;
    }
}