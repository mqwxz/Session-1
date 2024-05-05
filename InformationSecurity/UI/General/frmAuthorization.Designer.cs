namespace InformationSecurity.UI.General
{
    partial class frmAuthorization
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.Label();
            this.btnAuth = new System.Windows.Forms.Button();
            this.picCaptcha = new System.Windows.Forms.PictureBox();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.btnCaptcha = new System.Windows.Forms.Button();
            this.btnRefreshCaptcha = new System.Windows.Forms.Button();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Turquoise;
            this.pnlTop.Controls.Add(this.lblName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(333, 45);
            this.pnlTop.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(250, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Информационная безопасность";
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(138, 48);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(58, 23);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.Location = new System.Drawing.Point(46, 74);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(246, 30);
            this.txtLogin.TabIndex = 3;
            this.txtLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(46, 134);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 30);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // a
            // 
            this.a.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(131, 107);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(69, 23);
            this.a.TabIndex = 4;
            this.a.Text = "Пароль";
            // 
            // btnAuth
            // 
            this.btnAuth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAuth.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuth.Location = new System.Drawing.Point(46, 376);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(246, 30);
            this.btnAuth.TabIndex = 6;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = false;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // picCaptcha
            // 
            this.picCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picCaptcha.Location = new System.Drawing.Point(46, 170);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(246, 137);
            this.picCaptcha.TabIndex = 7;
            this.picCaptcha.TabStop = false;
            this.picCaptcha.Visible = false;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaptcha.Location = new System.Drawing.Point(46, 340);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(246, 30);
            this.txtCaptcha.TabIndex = 9;
            this.txtCaptcha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCaptcha.Visible = false;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Location = new System.Drawing.Point(141, 314);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(55, 23);
            this.lblCaptcha.TabIndex = 8;
            this.lblCaptcha.Text = "Капча";
            this.lblCaptcha.Visible = false;
            // 
            // btnCaptcha
            // 
            this.btnCaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptcha.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptcha.Location = new System.Drawing.Point(46, 412);
            this.btnCaptcha.Name = "btnCaptcha";
            this.btnCaptcha.Size = new System.Drawing.Size(246, 30);
            this.btnCaptcha.TabIndex = 10;
            this.btnCaptcha.Text = "Проверить капчу";
            this.btnCaptcha.UseVisualStyleBackColor = false;
            this.btnCaptcha.Visible = false;
            this.btnCaptcha.Click += new System.EventHandler(this.btnCaptcha_Click);
            // 
            // btnRefreshCaptcha
            // 
            this.btnRefreshCaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshCaptcha.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRefreshCaptcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCaptcha.Location = new System.Drawing.Point(46, 448);
            this.btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            this.btnRefreshCaptcha.Size = new System.Drawing.Size(246, 30);
            this.btnRefreshCaptcha.TabIndex = 11;
            this.btnRefreshCaptcha.Text = "Обновить капчу";
            this.btnRefreshCaptcha.UseVisualStyleBackColor = false;
            this.btnRefreshCaptcha.Visible = false;
            this.btnRefreshCaptcha.Click += new System.EventHandler(this.btnRefreshCaptcha_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Location = new System.Drawing.Point(9, 513);
            this.chkRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(155, 27);
            this.chkRememberMe.TabIndex = 12;
            this.chkRememberMe.Text = "Запомнить меня";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            this.chkRememberMe.CheckedChanged += new System.EventHandler(this.chkRememberMe_CheckedChanged);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(196, 510);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 30);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 546);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.btnRefreshCaptcha);
            this.Controls.Add(this.btnCaptcha);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.picCaptcha);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.a);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(349, 545);
            this.Name = "frmAuthorization";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.PictureBox picCaptcha;
        private System.Windows.Forms.TextBox txtCaptcha;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Button btnCaptcha;
        private System.Windows.Forms.Button btnRefreshCaptcha;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.Button btnBack;
    }
}