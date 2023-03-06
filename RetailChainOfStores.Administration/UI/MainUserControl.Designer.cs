namespace RetailChainOfStores.Administration.UI
{
    partial class MainUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUsers = new DevExpress.XtraEditors.LabelControl();
            this.btnSetAccessLevel = new DevExpress.XtraEditors.SimpleButton();
            this.lbAccessLevel = new DevExpress.XtraEditors.LabelControl();
            this.cmbBoxAccessLevel = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlUsers = new DevExpress.XtraGrid.GridControl();
            this.gridViewUsers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControlSetAccessLevel = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSetAccessLevel)).BeginInit();
            this.groupControlSetAccessLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUsers
            // 
            this.lbUsers.Location = new System.Drawing.Point(29, 12);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(121, 13);
            this.lbUsers.TabIndex = 1;
            this.lbUsers.Text = "Пользователи системы:";
            // 
            // btnSetAccessLevel
            // 
            this.btnSetAccessLevel.Location = new System.Drawing.Point(122, 44);
            this.btnSetAccessLevel.Name = "btnSetAccessLevel";
            this.btnSetAccessLevel.Size = new System.Drawing.Size(164, 23);
            this.btnSetAccessLevel.TabIndex = 2;
            this.btnSetAccessLevel.Text = "Установить уровень доступа";
            // 
            // lbAccessLevel
            // 
            this.lbAccessLevel.Location = new System.Drawing.Point(5, 26);
            this.lbAccessLevel.Name = "lbAccessLevel";
            this.lbAccessLevel.Size = new System.Drawing.Size(92, 13);
            this.lbAccessLevel.TabIndex = 3;
            this.lbAccessLevel.Text = "Уровень доступа:";
            // 
            // cmbBoxAccessLevel
            // 
            this.cmbBoxAccessLevel.FormattingEnabled = true;
            this.cmbBoxAccessLevel.Location = new System.Drawing.Point(5, 46);
            this.cmbBoxAccessLevel.Name = "cmbBoxAccessLevel";
            this.cmbBoxAccessLevel.Size = new System.Drawing.Size(113, 21);
            this.cmbBoxAccessLevel.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(619, 153);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(171, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Обновить данные";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridControlUsers
            // 
            this.gridControlUsers.Location = new System.Drawing.Point(29, 30);
            this.gridControlUsers.MainView = this.gridViewUsers;
            this.gridControlUsers.Name = "gridControlUsers";
            this.gridControlUsers.Size = new System.Drawing.Size(460, 400);
            this.gridControlUsers.TabIndex = 6;
            this.gridControlUsers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsers});
            // 
            // gridViewUsers
            // 
            this.gridViewUsers.GridControl = this.gridControlUsers;
            this.gridViewUsers.Name = "gridViewUsers";
            // 
            // groupControlSetAccessLevel
            // 
            this.groupControlSetAccessLevel.Controls.Add(this.cmbBoxAccessLevel);
            this.groupControlSetAccessLevel.Controls.Add(this.lbAccessLevel);
            this.groupControlSetAccessLevel.Controls.Add(this.btnSetAccessLevel);
            this.groupControlSetAccessLevel.Location = new System.Drawing.Point(497, 30);
            this.groupControlSetAccessLevel.Name = "groupControlSetAccessLevel";
            this.groupControlSetAccessLevel.Size = new System.Drawing.Size(293, 108);
            this.groupControlSetAccessLevel.TabIndex = 7;
            this.groupControlSetAccessLevel.Text = "Установка уровня доступа для пользователя";
            // 
            // MainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControlSetAccessLevel);
            this.Controls.Add(this.gridControlUsers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbUsers);
            this.Name = "MainUserControl";
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlSetAccessLevel)).EndInit();
            this.groupControlSetAccessLevel.ResumeLayout(false);
            this.groupControlSetAccessLevel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lbUsers;
        private DevExpress.XtraEditors.SimpleButton btnSetAccessLevel;
        private DevExpress.XtraEditors.LabelControl lbAccessLevel;
        private System.Windows.Forms.ComboBox cmbBoxAccessLevel;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraGrid.GridControl gridControlUsers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsers;
        private DevExpress.XtraEditors.GroupControl groupControlSetAccessLevel;
    }
}
