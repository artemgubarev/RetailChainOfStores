namespace RetailChainOfStores.UI.UI
{
    partial class LogUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageRegist = new System.Windows.Forms.TabPage();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.lbRegistError = new DevExpress.XtraEditors.LabelControl();
            this.lbRegistRepeatPassError = new DevExpress.XtraEditors.LabelControl();
            this.lbRegistPassError = new DevExpress.XtraEditors.LabelControl();
            this.lbRegistUserNameError = new DevExpress.XtraEditors.LabelControl();
            this.btnRegist = new DevExpress.XtraEditors.SimpleButton();
            this.lbRegistRepeatPass = new DevExpress.XtraEditors.LabelControl();
            this.lbRegistPass = new DevExpress.XtraEditors.LabelControl();
            this.lbRegistUsername = new DevExpress.XtraEditors.LabelControl();
            this.txteditRegistPass = new DevExpress.XtraEditors.TextEdit();
            this.txteditRegistRepeatPass = new DevExpress.XtraEditors.TextEdit();
            this.txteditRegistUserName = new DevExpress.XtraEditors.TextEdit();
            this.lbLoginError = new DevExpress.XtraEditors.LabelControl();
            this.lbLoginPassError = new DevExpress.XtraEditors.LabelControl();
            this.lbLoginUsernameError = new DevExpress.XtraEditors.LabelControl();
            this.lbLogPass = new DevExpress.XtraEditors.LabelControl();
            this.lbLoginUsername = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txteditLoginPass = new DevExpress.XtraEditors.TextEdit();
            this.txteditLoginUsername = new DevExpress.XtraEditors.TextEdit();
            this.tabControl.SuspendLayout();
            this.tabPageRegist.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRegistPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRegistRepeatPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRegistUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditLoginPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditLoginUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageRegist);
            this.tabControl.Controls.Add(this.tabPageLogin);
            this.tabControl.Location = new System.Drawing.Point(3, 42);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(428, 355);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageRegist
            // 
            this.tabPageRegist.Controls.Add(this.lbRegistError);
            this.tabPageRegist.Controls.Add(this.lbRegistRepeatPassError);
            this.tabPageRegist.Controls.Add(this.lbRegistPassError);
            this.tabPageRegist.Controls.Add(this.lbRegistUserNameError);
            this.tabPageRegist.Controls.Add(this.btnRegist);
            this.tabPageRegist.Controls.Add(this.lbRegistRepeatPass);
            this.tabPageRegist.Controls.Add(this.lbRegistPass);
            this.tabPageRegist.Controls.Add(this.lbRegistUsername);
            this.tabPageRegist.Controls.Add(this.txteditRegistPass);
            this.tabPageRegist.Controls.Add(this.txteditRegistRepeatPass);
            this.tabPageRegist.Controls.Add(this.txteditRegistUserName);
            this.tabPageRegist.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegist.Name = "tabPageRegist";
            this.tabPageRegist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegist.Size = new System.Drawing.Size(420, 336);
            this.tabPageRegist.TabIndex = 0;
            this.tabPageRegist.Text = "Регистрация";
            this.tabPageRegist.UseVisualStyleBackColor = true;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.lbLoginError);
            this.tabPageLogin.Controls.Add(this.lbLoginPassError);
            this.tabPageLogin.Controls.Add(this.lbLoginUsernameError);
            this.tabPageLogin.Controls.Add(this.lbLogPass);
            this.tabPageLogin.Controls.Add(this.lbLoginUsername);
            this.tabPageLogin.Controls.Add(this.btnLogin);
            this.tabPageLogin.Controls.Add(this.txteditLoginPass);
            this.tabPageLogin.Controls.Add(this.txteditLoginUsername);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 22);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(420, 329);
            this.tabPageLogin.TabIndex = 1;
            this.tabPageLogin.Text = "Вход";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            // 
            // lbRegistError
            // 
            this.lbRegistError.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.lbRegistError.Appearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.lbRegistError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbRegistError.Appearance.Options.UseBackColor = true;
            this.lbRegistError.Appearance.Options.UseBorderColor = true;
            this.lbRegistError.Appearance.Options.UseForeColor = true;
            this.lbRegistError.Location = new System.Drawing.Point(88, 226);
            this.lbRegistError.Name = "lbRegistError";
            this.lbRegistError.Size = new System.Drawing.Size(239, 13);
            this.lbRegistError.TabIndex = 21;
            this.lbRegistError.Text = "Пользователь с таким именем уже существует";
            // 
            // lbRegistRepeatPassError
            // 
            this.lbRegistRepeatPassError.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.lbRegistRepeatPassError.Appearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.lbRegistRepeatPassError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbRegistRepeatPassError.Appearance.Options.UseBackColor = true;
            this.lbRegistRepeatPassError.Appearance.Options.UseBorderColor = true;
            this.lbRegistRepeatPassError.Appearance.Options.UseForeColor = true;
            this.lbRegistRepeatPassError.Location = new System.Drawing.Point(106, 151);
            this.lbRegistRepeatPassError.Name = "lbRegistRepeatPassError";
            this.lbRegistRepeatPassError.Size = new System.Drawing.Size(112, 13);
            this.lbRegistRepeatPassError.TabIndex = 20;
            this.lbRegistRepeatPassError.Text = "Пароли не совпадают";
            // 
            // lbRegistPassError
            // 
            this.lbRegistPassError.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.lbRegistPassError.Appearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.lbRegistPassError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbRegistPassError.Appearance.Options.UseBackColor = true;
            this.lbRegistPassError.Appearance.Options.UseBorderColor = true;
            this.lbRegistPassError.Appearance.Options.UseForeColor = true;
            this.lbRegistPassError.Location = new System.Drawing.Point(77, 79);
            this.lbRegistPassError.Name = "lbRegistPassError";
            this.lbRegistPassError.Size = new System.Drawing.Size(156, 13);
            this.lbRegistPassError.TabIndex = 19;
            this.lbRegistPassError.Text = "Пароль не может быть пустым";
            // 
            // lbRegistUserNameError
            // 
            this.lbRegistUserNameError.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.lbRegistUserNameError.Appearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.lbRegistUserNameError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbRegistUserNameError.Appearance.Options.UseBackColor = true;
            this.lbRegistUserNameError.Appearance.Options.UseBorderColor = true;
            this.lbRegistUserNameError.Appearance.Options.UseForeColor = true;
            this.lbRegistUserNameError.Location = new System.Drawing.Point(77, 6);
            this.lbRegistUserNameError.Name = "lbRegistUserNameError";
            this.lbRegistUserNameError.Size = new System.Drawing.Size(138, 13);
            this.lbRegistUserNameError.TabIndex = 18;
            this.lbRegistUserNameError.Text = "Имя не может быть пустым";
            // 
            // btnRegist
            // 
            this.btnRegist.Location = new System.Drawing.Point(97, 268);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(230, 30);
            this.btnRegist.TabIndex = 17;
            this.btnRegist.Text = "Зарегистрироваться";
            // 
            // lbRegistRepeatPass
            // 
            this.lbRegistRepeatPass.Location = new System.Drawing.Point(6, 150);
            this.lbRegistRepeatPass.Name = "lbRegistRepeatPass";
            this.lbRegistRepeatPass.Size = new System.Drawing.Size(94, 13);
            this.lbRegistRepeatPass.TabIndex = 16;
            this.lbRegistRepeatPass.Text = "Повторите пароль";
            // 
            // lbRegistPass
            // 
            this.lbRegistPass.Location = new System.Drawing.Point(6, 78);
            this.lbRegistPass.Name = "lbRegistPass";
            this.lbRegistPass.Size = new System.Drawing.Size(37, 13);
            this.lbRegistPass.TabIndex = 15;
            this.lbRegistPass.Text = "Пароль";
            // 
            // lbRegistUsername
            // 
            this.lbRegistUsername.Location = new System.Drawing.Point(6, 6);
            this.lbRegistUsername.Name = "lbRegistUsername";
            this.lbRegistUsername.Size = new System.Drawing.Size(30, 13);
            this.lbRegistUsername.TabIndex = 14;
            this.lbRegistUsername.Text = "Логин";
            // 
            // txteditRegistPass
            // 
            this.txteditRegistPass.Location = new System.Drawing.Point(6, 98);
            this.txteditRegistPass.Name = "txteditRegistPass";
            this.txteditRegistPass.Size = new System.Drawing.Size(408, 20);
            this.txteditRegistPass.TabIndex = 13;
            // 
            // txteditRegistRepeatPass
            // 
            this.txteditRegistRepeatPass.Location = new System.Drawing.Point(6, 170);
            this.txteditRegistRepeatPass.Name = "txteditRegistRepeatPass";
            this.txteditRegistRepeatPass.Size = new System.Drawing.Size(408, 20);
            this.txteditRegistRepeatPass.TabIndex = 12;
            // 
            // txteditRegistUserName
            // 
            this.txteditRegistUserName.Location = new System.Drawing.Point(6, 26);
            this.txteditRegistUserName.Name = "txteditRegistUserName";
            this.txteditRegistUserName.Size = new System.Drawing.Size(408, 20);
            this.txteditRegistUserName.TabIndex = 11;
            // 
            // lbLoginError
            // 
            this.lbLoginError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbLoginError.Appearance.Options.UseForeColor = true;
            this.lbLoginError.Location = new System.Drawing.Point(129, 194);
            this.lbLoginError.Name = "lbLoginError";
            this.lbLoginError.Size = new System.Drawing.Size(150, 13);
            this.lbLoginError.TabIndex = 15;
            this.lbLoginError.Text = "Неверный логин или пароль !";
            // 
            // lbLoginPassError
            // 
            this.lbLoginPassError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbLoginPassError.Appearance.Options.UseForeColor = true;
            this.lbLoginPassError.Location = new System.Drawing.Point(61, 114);
            this.lbLoginPassError.Name = "lbLoginPassError";
            this.lbLoginPassError.Size = new System.Drawing.Size(156, 13);
            this.lbLoginPassError.TabIndex = 14;
            this.lbLoginPassError.Text = "Пароль не может быть пустым";
            // 
            // lbLoginUsernameError
            // 
            this.lbLoginUsernameError.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.lbLoginUsernameError.Appearance.BorderColor = System.Drawing.SystemColors.Menu;
            this.lbLoginUsernameError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbLoginUsernameError.Appearance.Options.UseBackColor = true;
            this.lbLoginUsernameError.Appearance.Options.UseBorderColor = true;
            this.lbLoginUsernameError.Appearance.Options.UseForeColor = true;
            this.lbLoginUsernameError.Location = new System.Drawing.Point(61, 19);
            this.lbLoginUsernameError.Name = "lbLoginUsernameError";
            this.lbLoginUsernameError.Size = new System.Drawing.Size(138, 13);
            this.lbLoginUsernameError.TabIndex = 13;
            this.lbLoginUsernameError.Text = "Имя не может быть пустым";
            // 
            // lbLogPass
            // 
            this.lbLogPass.Location = new System.Drawing.Point(6, 114);
            this.lbLogPass.Name = "lbLogPass";
            this.lbLogPass.Size = new System.Drawing.Size(37, 13);
            this.lbLogPass.TabIndex = 12;
            this.lbLogPass.Text = "Пароль";
            // 
            // lbLoginUsername
            // 
            this.lbLoginUsername.Location = new System.Drawing.Point(6, 19);
            this.lbLoginUsername.Name = "lbLoginUsername";
            this.lbLoginUsername.Size = new System.Drawing.Size(30, 13);
            this.lbLoginUsername.TabIndex = 11;
            this.lbLoginUsername.Text = "Логин";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(102, 247);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(199, 30);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Войти";
            // 
            // txteditLoginPass
            // 
            this.txteditLoginPass.Location = new System.Drawing.Point(6, 134);
            this.txteditLoginPass.Name = "txteditLoginPass";
            this.txteditLoginPass.Size = new System.Drawing.Size(408, 20);
            this.txteditLoginPass.TabIndex = 9;
            // 
            // txteditLoginUsername
            // 
            this.txteditLoginUsername.Location = new System.Drawing.Point(6, 39);
            this.txteditLoginUsername.Name = "txteditLoginUsername";
            this.txteditLoginUsername.Size = new System.Drawing.Size(408, 20);
            this.txteditLoginUsername.TabIndex = 8;
            // 
            // LogUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl);
            this.Name = "LogUserControl";
            this.Size = new System.Drawing.Size(430, 400);
            this.tabControl.ResumeLayout(false);
            this.tabPageRegist.ResumeLayout(false);
            this.tabPageRegist.PerformLayout();
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRegistPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRegistRepeatPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRegistUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditLoginPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditLoginUsername.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageRegist;
        private System.Windows.Forms.TabPage tabPageLogin;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.LabelControl lbRegistError;
        private DevExpress.XtraEditors.LabelControl lbRegistRepeatPassError;
        private DevExpress.XtraEditors.LabelControl lbRegistPassError;
        private DevExpress.XtraEditors.LabelControl lbRegistUserNameError;
        private DevExpress.XtraEditors.SimpleButton btnRegist;
        private DevExpress.XtraEditors.LabelControl lbRegistRepeatPass;
        private DevExpress.XtraEditors.LabelControl lbRegistPass;
        private DevExpress.XtraEditors.LabelControl lbRegistUsername;
        private DevExpress.XtraEditors.TextEdit txteditRegistPass;
        private DevExpress.XtraEditors.TextEdit txteditRegistRepeatPass;
        private DevExpress.XtraEditors.TextEdit txteditRegistUserName;
        private DevExpress.XtraEditors.LabelControl lbLoginError;
        private DevExpress.XtraEditors.LabelControl lbLoginPassError;
        private DevExpress.XtraEditors.LabelControl lbLoginUsernameError;
        private DevExpress.XtraEditors.LabelControl lbLogPass;
        private DevExpress.XtraEditors.LabelControl lbLoginUsername;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txteditLoginPass;
        private DevExpress.XtraEditors.TextEdit txteditLoginUsername;
    }
}
