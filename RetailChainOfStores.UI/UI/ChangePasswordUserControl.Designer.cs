namespace RetailChainOfStores.UI.UI
{
    partial class ChangePasswordUserControl
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
            this.txteditOldPass = new DevExpress.XtraEditors.TextEdit();
            this.txteditRepeatNewPass = new DevExpress.XtraEditors.TextEdit();
            this.txteditNewPass = new DevExpress.XtraEditors.TextEdit();
            this.btnChangePass = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lbOldPass = new DevExpress.XtraEditors.LabelControl();
            this.lbNewPass = new DevExpress.XtraEditors.LabelControl();
            this.lbRepeatNewPass = new DevExpress.XtraEditors.LabelControl();
            this.lbRepeatPassError = new DevExpress.XtraEditors.LabelControl();
            this.lbChangePassError = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txteditOldPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRepeatNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditNewPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txteditOldPass
            // 
            this.txteditOldPass.Location = new System.Drawing.Point(15, 50);
            this.txteditOldPass.Name = "txteditOldPass";
            this.txteditOldPass.Size = new System.Drawing.Size(309, 20);
            this.txteditOldPass.TabIndex = 1;
            // 
            // txteditRepeatNewPass
            // 
            this.txteditRepeatNewPass.Location = new System.Drawing.Point(15, 170);
            this.txteditRepeatNewPass.Name = "txteditRepeatNewPass";
            this.txteditRepeatNewPass.Size = new System.Drawing.Size(309, 20);
            this.txteditRepeatNewPass.TabIndex = 2;
            // 
            // txteditNewPass
            // 
            this.txteditNewPass.Location = new System.Drawing.Point(15, 110);
            this.txteditNewPass.Name = "txteditNewPass";
            this.txteditNewPass.Size = new System.Drawing.Size(309, 20);
            this.txteditNewPass.TabIndex = 3;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(15, 220);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(108, 23);
            this.btnChangePass.TabIndex = 4;
            this.btnChangePass.Text = "сменить пароль";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(215, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "отмена";
            // 
            // lbOldPass
            // 
            this.lbOldPass.Location = new System.Drawing.Point(15, 30);
            this.lbOldPass.Name = "lbOldPass";
            this.lbOldPass.Size = new System.Drawing.Size(84, 13);
            this.lbOldPass.TabIndex = 6;
            this.lbOldPass.Text = "Прежний пароль";
            // 
            // lbNewPass
            // 
            this.lbNewPass.Location = new System.Drawing.Point(15, 90);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(72, 13);
            this.lbNewPass.TabIndex = 7;
            this.lbNewPass.Text = "Новый пароль";
            // 
            // lbRepeatNewPass
            // 
            this.lbRepeatNewPass.Location = new System.Drawing.Point(15, 150);
            this.lbRepeatNewPass.Name = "lbRepeatNewPass";
            this.lbRepeatNewPass.Size = new System.Drawing.Size(129, 13);
            this.lbRepeatNewPass.TabIndex = 8;
            this.lbRepeatNewPass.Text = "Повторите новый пароль";
            // 
            // lbRepeatPassError
            // 
            this.lbRepeatPassError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbRepeatPassError.Appearance.Options.UseForeColor = true;
            this.lbRepeatPassError.Location = new System.Drawing.Point(150, 151);
            this.lbRepeatPassError.Name = "lbRepeatPassError";
            this.lbRepeatPassError.ShowLineShadow = false;
            this.lbRepeatPassError.Size = new System.Drawing.Size(106, 13);
            this.lbRepeatPassError.TabIndex = 9;
            this.lbRepeatPassError.Text = "Пароли не сопадают";
            // 
            // lbChangePassError
            // 
            this.lbChangePassError.Location = new System.Drawing.Point(94, 201);
            this.lbChangePassError.Name = "lbChangePassError";
            this.lbChangePassError.Size = new System.Drawing.Size(184, 13);
            this.lbChangePassError.TabIndex = 10;
            this.lbChangePassError.Text = "Новый пароль совпадает с прежним";
            // 
            // ChangePasswordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbChangePassError);
            this.Controls.Add(this.lbRepeatPassError);
            this.Controls.Add(this.lbRepeatNewPass);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.lbOldPass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangePass);
            this.Controls.Add(this.txteditNewPass);
            this.Controls.Add(this.txteditRepeatNewPass);
            this.Controls.Add(this.txteditOldPass);
            this.Name = "ChangePasswordUserControl";
            this.Size = new System.Drawing.Size(361, 299);
            ((System.ComponentModel.ISupportInitialize)(this.txteditOldPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditRepeatNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteditNewPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txteditOldPass;
        private DevExpress.XtraEditors.TextEdit txteditRepeatNewPass;
        private DevExpress.XtraEditors.TextEdit txteditNewPass;
        private DevExpress.XtraEditors.SimpleButton btnChangePass;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lbOldPass;
        private DevExpress.XtraEditors.LabelControl lbNewPass;
        private DevExpress.XtraEditors.LabelControl lbRepeatNewPass;
        private DevExpress.XtraEditors.LabelControl lbRepeatPassError;
        private DevExpress.XtraEditors.LabelControl lbChangePassError;
    }
}
