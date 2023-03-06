using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailChainOfStores.UI.UI
{
    public partial class LogUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public DevExpress.XtraEditors.XtraForm ParentForm { get; set; }

        public LogUserControl()
        {
            InitializeComponent();

            this.txteditLoginPass.Properties.PasswordChar = '*';
            this.txteditRegistPass.Properties.PasswordChar = '*';
            this.txteditRegistRepeatPass.Properties.PasswordChar = '*';

            this.LabelLoginPassError.Visible = false;
            this.LalebLoginUserNameError.Visible = false;
            this.LabelRegistUserNameError.Visible = false;
            this.LabelRegistPassError.Visible = false;
            this.LabelRegistRepeatPassError.Visible = false;
            this.LabelRegistError.Visible = false;
            this.LabelLoginError.Visible = false;
        }

        

        #region Text Fields
        public string GetLoginUserName()
        {
            return txteditLoginUsername.Text;
        }

        public string GetLoginPassword()
        {
            return txteditLoginPass.Text;
        }

        public string GetRegistUserName()
        {
            return txteditRegistUserName.Text;
        }

        public string GetRegistPassword()
        {
            return txteditRegistPass.Text;
        }

        public string GetRegistRepeatPassword()
        {
            return txteditRegistRepeatPass.Text;
        }
        #endregion

        #region Buttons
        public DevExpress.XtraEditors.SimpleButton LoginButton
        {
            get { return this.btnLogin; }
            set { this.btnLogin = value; }
        }

        public DevExpress.XtraEditors.SimpleButton RegistButton
        {
            get { return this.btnRegist; }
            set { this.btnRegist = value; }
        }

        public DevExpress.XtraEditors.SimpleButton ExitButton
        {
            get { return this.btnExit; }
            set { this.btnExit = value; }
        }
        #endregion

        #region Error lables
        public DevExpress.XtraEditors.LabelControl LalebLoginUserNameError
        {
            get { return this.lbLoginUsernameError; }
            set { this.lbLoginUsernameError = value; }
        }

        public DevExpress.XtraEditors.LabelControl LabelLoginPassError
        {
            get { return this.lbLoginPassError; }
            set { this.lbLoginPassError = value; }
        }

        public DevExpress.XtraEditors.LabelControl LabelRegistUserNameError
        {
            get { return this.lbRegistUserNameError; }
            set { this.lbRegistUserNameError = value; }
        }

        public DevExpress.XtraEditors.LabelControl LabelRegistPassError
        {
            get { return this.lbRegistPassError; }
            set { this.lbRegistPassError = value; }
        }

        public DevExpress.XtraEditors.LabelControl LabelRegistRepeatPassError
        {
            get { return this.lbRegistRepeatPassError; }
            set { this.lbRegistRepeatPassError = value; }
        }

        public DevExpress.XtraEditors.LabelControl LabelRegistError
        {
            get { return this.lbRegistError; }
            set { this.lbRegistError = value; }
        }

        public DevExpress.XtraEditors.LabelControl LabelLoginError
        {
            get { return this.lbLoginError; }
            set { this.lbLoginError = value; }
        }
        #endregion

        #region Form drag and drop
        //private Point _location;

        //private void Form_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == System.Windows.Forms.MouseButtons.Left && ParentForm != null)
        //    {
        //        ParentForm.Location =
        //            new System.Drawing.Point(ParentForm.Location.X + (e.X - _location.X),
        //                                     ParentForm.Location.Y + (e.Y - _location.Y));
        //    }
        //}

        //private void Form_MouseDown(object sender, MouseEventArgs e)
        //{
        //    _location.X = e.X;
        //    _location.Y = e.Y;
        //}
        #endregion
    }
}
