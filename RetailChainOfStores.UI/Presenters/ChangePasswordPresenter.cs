using RetailChainOfStores.Model.Model;
using RetailChainOfStores.UI.Common;
using RetailChainOfStores.UI.Views;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.UI.Presenters
{
    public class ChangePasswordPresenter : BasePresenter<IChangePasswordView, User>
    {
        private User _user;

        public ChangePasswordPresenter(IApplicationController controller, IChangePasswordView view):
            base(controller, view)
        {

        }

        public override void Run(User argument)
        {
            _user = argument;
            View.Show();
        }
    }
}
