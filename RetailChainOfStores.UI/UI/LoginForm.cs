using RetailChainOfStores.UI.UI;
using RetailChainOfStores.UI.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RetailChainOfStores.UI
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm, ILoginView
    {
        private LogUserControl _userControl;
        private readonly ApplicationContext _context;
        public LoginForm(ApplicationContext context)
        {
            _context= context;

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            this._userControl = new LogUserControl();
            this._userControl.Dock = DockStyle.Fill;
            this._userControl.ParentForm = this;

            this.Controls.Add(_userControl);

            _userControl.LoginButton.Click += (sender, args) => Invoke(Login);
            _userControl.RegistButton.Click += (sender, args) => Invoke(Regist);
            _userControl.ExitButton.Click += (sender, args) => Invoke(Exit);
        }

       

        public new void Show()
        {
            _context.MainForm = this;
            Application.Run(_context);
        }

        #region User control properties
        public string LoginUserName { get { return _userControl.GetLoginUserName(); } }
        public string LoginPassword { get { return _userControl.GetLoginPassword(); } }
        public string RepeatPassword { get { return _userControl.GetRegistRepeatPassword(); } }
        public string RegistUserName { get { return _userControl.GetRegistUserName(); } }
        public string RegistPassword { get { return _userControl.GetRegistPassword(); } }
        #endregion

        public event Action Login;
        public event Action Regist;
        public event Action Exit;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public void ShowErrors(string paramName, bool isRegistration)
        {
            if (isRegistration)
            {
                if (paramName == "Username")
                {
                    this._userControl.LabelRegistUserNameError.Visible = true;
                    this._userControl.LabelRegistPassError.Visible = false;
                }
                else if (paramName == "Password")
                {
                    this._userControl.LabelRegistUserNameError.Visible = false;
                    this._userControl.LabelRegistPassError.Visible = true;
                }
            }
            else
            {
                if (paramName == "Username")
                {
                    this._userControl.LalebLoginUserNameError.Visible = true;
                    this._userControl.LabelLoginPassError.Visible = false;
                }
                else if (paramName == "Password")
                {
                    this._userControl.LabelLoginPassError.Visible = true;
                    this._userControl.LalebLoginUserNameError.Visible = false;
                }
            }
        }

        public void ShowReapeatPasswordError()
        {
            this._userControl.LabelRegistRepeatPassError.Visible = true;
        }

        public void ShowLoginError()
        {
            this._userControl.LabelLoginError.Visible = true;   
        }

        public void ShowRegisterError()
        {
            this._userControl.LabelRegistError.Visible = true;
        }
    }
}
