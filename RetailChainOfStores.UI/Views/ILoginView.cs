using RetailChainOfStores.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.UI.Views
{
    public interface ILoginView : IView
    {
        string LoginUserName { get; }
        string LoginPassword { get; }
        string RegistUserName { get; }
        string RegistPassword { get; }
        string RepeatPassword { get; }  
        event Action Login;
        event Action Regist;
        event Action Exit;
        void ShowErrors(string paramName, bool isRegistration);
        void ShowReapeatPasswordError();
        void ShowLoginError();
        void ShowRegisterError();
    }
}
