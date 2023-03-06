using RetailChainOfStores.Model.Model;
using RetailChainOfStores.UI.Common;
using RetailChainOfStores.UI.Views;
using System;

namespace RetailChainOfStores.UI.Presenters
{
    public class MainPresenter : BasePresenter<IMainView, User>
    {
        private User _user;

        public MainPresenter(IApplicationController controller, IMainView view)
            : base(controller, view)
        {
            View.ChangePassword += () => ChangePassword();
        }

        private void ChangePassword()
        {
            Controller.Run<ChangePasswordPresenter, User>(_user);
        }

        public override void Run(User argument)
        {
            _user = argument;
            View.Show();
        }
    }
}
