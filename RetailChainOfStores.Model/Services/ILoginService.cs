using RetailChainOfStores.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailChainOfStores.Model.Services
{
    public interface ILoginService
    {
        bool Login(ref User user);
        bool Regist(ref User user);
    }
}
