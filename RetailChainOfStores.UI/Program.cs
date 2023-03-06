using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using RetailChainOfStores.Model.Services;
using RetailChainOfStores.UI.Common;
using RetailChainOfStores.UI.Presenters;
using RetailChainOfStores.UI.UI;
using RetailChainOfStores.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RetailChainOfStores.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<ILoginView, LoginForm>()
                .RegisterView<IMainView, MainForm>()
                .RegisterView<IChangePasswordView, ChangePasswordForm>()
                .RegisterService<ILoginService, LoginService>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<LoginPresenter>();
        }
    }
}
