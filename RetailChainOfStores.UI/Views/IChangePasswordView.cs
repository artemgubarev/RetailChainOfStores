using RetailChainOfStores.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.UI.Views
{
    public interface IChangePasswordView : IView
    {
        string OldPassword { get; }
        string NewPassword { get; } 
        string RepeatNewPassword { get; }
        event Action ChangePassword;
        event Action Cancel;
        void ShowRepeatPasswordError();
        void ShowPasswordsMathchError();
    }
}
