using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetailChainOfStores.UI
{
    public partial class MainUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public MainUserControl()
        {
            InitializeComponent();
            MenuStripInit();
        }

        ToolStripMenuItem _changePassItem;

        private void MenuStripInit()
        {
            string[] menuStripItems = new string[]
            {
                "Справка",
                "Справочники",
                "Документы",
                "Разное",
            };

            foreach (var value in menuStripItems)
            {
                var item = new ToolStripMenuItem(value);
                menuStrip.Items.Add(item);
            }

            ((ToolStripMenuItem)menuStrip.Items[3]).DropDownItems.Add("Настройка");
            //((ToolStripMenuItem)menuStrip.Items[3]).DropDownItems.Add("Сменить пароль");
            _changePassItem = new ToolStripMenuItem("Сменить пароль");
            ((ToolStripMenuItem)menuStrip.Items[3]).DropDownItems.Add(_changePassItem);
        }


        public System.Windows.Forms.MenuStrip MenuStrip
        {
            get {return this.menuStrip;}
            set { this.menuStrip = value;}
        }

        public System.Windows.Forms.ToolStripMenuItem ChangePasswordItem
        {
            get { return this._changePassItem; }
        }
    }
}
