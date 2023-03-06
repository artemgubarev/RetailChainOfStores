using RetailChainOfStores.Model.Model;
using RetailChainOfStores.Model.Services;
using RetailChainOfStores.UI.Common;
using RetailChainOfStores.UI.Views;
using System;

namespace RetailChainOfStores.UI.Presenters
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly ILoginService _service;

        public LoginPresenter(IApplicationController controller, ILoginView view,ILoginService service) 
            : base(controller, view)
        {
            _service = service;

            view.Login += () => Login(View.LoginUserName, View.LoginPassword);
            view.Regist += () => Regist(View.RegistUserName, View.RegistPassword, View.RepeatPassword);
            view.Exit += () => Exit();
        }

        private void Exit()
        {
            View.Close();   
        }

        private void Login(string username, string password)
        {
            try
            {
                var user = new User(username, password);
                if (_service.Login(ref user))
                {
                    Controller.Run<MainPresenter, User>(user);
                    View.Close();
                }
                else
                {
                    View.ShowLoginError();
                }
            }
            catch (ArgumentNullException ex)
            {
                string paramName = ex.ParamName;
                View.ShowErrors(paramName, isRegistration: false);
            }
        }

        private void Regist(string username, string password, string repeatPassword)
        {
            bool isReapeatPassValid = true;

            if(!string.Equals(password, repeatPassword))
            {
                View.ShowReapeatPasswordError();
                isReapeatPassValid = false; 
            }

            try
            {
                var user = new User(username, password);
                if (isReapeatPassValid)
                {
                    if (_service.Regist(ref user))
                    {
                        Controller.Run<MainPresenter, User>(user);
                        View.Close();
                    }
                    else
                    {
                        View.ShowRegisterError();
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                string paramName = ex.ParamName;
                View.ShowErrors(paramName, isRegistration: true);
            }
        }

    }
}
