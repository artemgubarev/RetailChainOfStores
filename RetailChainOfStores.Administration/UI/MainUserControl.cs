using DevExpress.XtraEditors.Controls;
using RetailChainOfStores.Model.Model;
using RetailChainOfStores.Model.Repository;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RetailChainOfStores.Administration.UI
{
    public partial class MainUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        PostgresqlDataBase _postgresqlDataBase;
        DataTable _usersDataTable;
        private int _focusedRowHandle;

        public MainUserControl()
        {
            InitializeComponent();
            InitializeControlsProperties();

            _postgresqlDataBase = new PostgresqlDataBase();
            _usersDataTable = new DataTable();
            _focusedRowHandle = 0;

            gridViewUsers.ShowingEditor += GridViewUsers_ShowingEditor;
            gridViewUsers.FocusedRowChanged += GridViewUsers_FocusedRowChanged;
            btnRefresh.Click += btnRefresh_Click;
            btnSetAccessLevel.Click += BtnSetAccessLevel_Click;
            this.Disposed += MainUserControl_Disposed;

            UpdateUsersDataTable();
        }
        private void InitializeControlsProperties()
        {
            cmbBoxAccessLevel.DropDownStyle = ComboBoxStyle.DropDownList;

            gridViewUsers.OptionsView.ShowIndicator = false;
            gridViewUsers.OptionsView.ShowGroupPanel = false;
            gridViewUsers.Appearance.FocusedCell.BackColor = Color.LightBlue;
            gridViewUsers.RowHeight = 15;
            gridViewUsers.OptionsBehavior.AllowPartialRedrawOnScrolling = true;
            gridViewUsers.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            gridViewUsers.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            gridViewUsers.BorderStyle = BorderStyles.Simple;
            gridViewUsers.OptionsCustomization.AllowSort = false;

            cmbBoxAccessLevel.DataSource = new User.AccessLevel[]
            {
                User.AccessLevel.Read,
                User.AccessLevel.Write,
                User.AccessLevel.Edit,
                User.AccessLevel.Delete,
            };
        }

        #region Events
        private void GridViewUsers_ShowingEditor(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void GridViewUsers_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            _focusedRowHandle = gridViewUsers.FocusedRowHandle;
        }

        private void MainUserControl_Disposed(object sender, EventArgs e)
        {
            gridViewUsers.ShowingEditor -= GridViewUsers_ShowingEditor;
            gridViewUsers.FocusedRowChanged -= GridViewUsers_FocusedRowChanged;
            btnRefresh.Click -= btnRefresh_Click;
            btnSetAccessLevel.Click -= BtnSetAccessLevel_Click;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateUsersDataTable();
        }

        private void BtnSetAccessLevel_Click(object sender, EventArgs e)
        {
            // user id
            var columnUserId = gridViewUsers.Columns[0];
            var userId = int.Parse(gridViewUsers.GetFocusedRowCellValue(columnUserId).ToString());

            // access level
            var accessLevel_str = cmbBoxAccessLevel.SelectedValue.ToString();
            var accessLevel = User.AccessLevels[accessLevel_str];

            _postgresqlDataBase.SetUserAccessLevel(userId, accessLevel);

            gridViewUsers.FocusedRowChanged -= GridViewUsers_FocusedRowChanged;
            UpdateUsersDataTable();
            gridViewUsers.FocusedRowChanged += GridViewUsers_FocusedRowChanged;
        }

        #endregion

        private void UpdateUsersDataTable()
        {
            var users = _postgresqlDataBase.GetAllUsers();

            _usersDataTable.Clear();
            _usersDataTable.Columns.Clear();    
            _usersDataTable.Columns.Add(new DataColumn());
            _usersDataTable.Columns.Add(new DataColumn());
            _usersDataTable.Columns.Add(new DataColumn());
            foreach (var user in users)
            {
                _usersDataTable.Rows.Add(new string[] 
                { user.Id.ToString() ,user.UserName, user.UserAccessLevel.ToString() });
            }

            GridViewRefresh();
        }

        private void GridViewRefresh()
        {
            gridControlUsers.BeginUpdate();
            gridViewUsers.Columns.Clear();
            gridControlUsers.DataSource = null;
            GC.Collect();
            gridControlUsers.DataSource = _usersDataTable;

            // set columns  name
            gridViewUsers.Columns[0].Caption = "Id";
            gridViewUsers.Columns[1].Caption = "Логин";
            gridViewUsers.Columns[2].Caption = "Уровень доступа";
            // set columns width
            gridViewUsers.Columns[0].Width = 60;
            gridViewUsers.Columns[1].Width = 200;
            gridViewUsers.Columns[2].Width = 200;

            gridViewUsers.FocusedRowHandle = _focusedRowHandle;

            gridControlUsers.EndUpdate();
            gridViewUsers.LayoutChanged();
        }
    }
}
