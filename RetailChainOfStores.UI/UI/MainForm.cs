using RetailChainOfStores.UI.Views;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace RetailChainOfStores.UI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm, IMainView
    {
        private readonly ApplicationContext _context;
        private MainUserControl _userControl;
        public MainForm(ApplicationContext context)
        {
            InitializeComponent();

            _context = context;

            this.StartPosition = FormStartPosition.CenterScreen;
            this._userControl = new MainUserControl();
            this._userControl.Dock = DockStyle.Fill;
            this.Controls.Add(this._userControl);

            this._userControl.ChangePasswordItem.Click += (sender, e) => Invoke(ChangePassword);
        }

        public event Action ChangePassword;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}