using RetailChainOfStores.UI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.UI.Views
{
    public interface IMainView : IView
    {
        event Action ChangePassword;
    }
}
