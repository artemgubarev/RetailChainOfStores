using RetailChainOfStores.UI.Views;
using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace RetailChainOfStores.UI.UI
{
    public partial class ChangePasswordForm : Form, IChangePasswordView
    {
        ChangePasswordUserControl _userControl;
        private readonly ApplicationContext _context;

        public ChangePasswordForm(ApplicationContext context)
        {
            InitializeComponent();

            _context = context;

            this.StartPosition = FormStartPosition.CenterScreen;
            _userControl = new ChangePasswordUserControl();
            this._userControl.Dock = DockStyle.Fill;
            this.Controls.Add(this._userControl);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public string OldPassword => throw new NotImplementedException();

        public string NewPassword => throw new NotImplementedException();

        public string RepeatNewPassword => throw new NotImplementedException();

        public event Action ChangePassword;
        public event Action Cancel;

        public void ShowPasswordsMathchError()
        {
            throw new NotImplementedException();
        }

        public void ShowRepeatPasswordError()
        {
            throw new NotImplementedException();
        }
    }
}
