namespace QLGara
{
    partial class FormUsersList
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlUsers = new System.Windows.Forms.TableLayoutPanel();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.USER_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ROLE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIRTHDAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULL_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PHONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUsers
            // 
            this.pnlUsers.ColumnCount = 1;
            this.pnlUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlUsers.Controls.Add(this.gvUsers, 0, 0);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsers.Location = new System.Drawing.Point(0, 0);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.RowCount = 2;
            this.pnlUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlUsers.Size = new System.Drawing.Size(656, 457);
            this.pnlUsers.TabIndex = 0;
            // 
            // gvUsers
            // 
            this.gvUsers.AllowUserToAddRows = false;
            this.gvUsers.AllowUserToDeleteRows = false;
            this.gvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USER_ID,
            this.USERNAME,
            this.EMAIL,
            this.ROLE_ID,
            this.GENDER,
            this.BIRTHDAY,
            this.FULL_NAME,
            this.PHONE,
            this.DIRECTION,
            this.PASS});
            this.gvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvUsers.Location = new System.Drawing.Point(3, 3);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.ReadOnly = true;
            this.gvUsers.Size = new System.Drawing.Size(650, 222);
            this.gvUsers.TabIndex = 0;
            // 
            // USER_ID
            // 
            this.USER_ID.DataPropertyName = "USER_ID";
            this.USER_ID.HeaderText = "ID";
            this.USER_ID.Name = "USER_ID";
            this.USER_ID.ReadOnly = true;
            // 
            // USERNAME
            // 
            this.USERNAME.DataPropertyName = "USERNAME";
            this.USERNAME.HeaderText = "Tên đăng nhập";
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.ReadOnly = true;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "EMAIL";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            // 
            // ROLE_ID
            // 
            this.ROLE_ID.DataPropertyName = "ROLE_ID";
            this.ROLE_ID.HeaderText = "Quyền";
            this.ROLE_ID.Name = "ROLE_ID";
            this.ROLE_ID.ReadOnly = true;
            // 
            // GENDER
            // 
            this.GENDER.DataPropertyName = "GENDER";
            this.GENDER.HeaderText = "Giới tính";
            this.GENDER.Name = "GENDER";
            this.GENDER.ReadOnly = true;
            // 
            // BIRTHDAY
            // 
            this.BIRTHDAY.DataPropertyName = "BIRTHDAY";
            this.BIRTHDAY.HeaderText = "Ngày sinh";
            this.BIRTHDAY.Name = "BIRTHDAY";
            this.BIRTHDAY.ReadOnly = true;
            // 
            // FULL_NAME
            // 
            this.FULL_NAME.DataPropertyName = "FULL_NAME";
            this.FULL_NAME.HeaderText = "Họ tên";
            this.FULL_NAME.Name = "FULL_NAME";
            this.FULL_NAME.ReadOnly = true;
            // 
            // PHONE
            // 
            this.PHONE.DataPropertyName = "PHONE";
            this.PHONE.HeaderText = "Điện thoại";
            this.PHONE.Name = "PHONE";
            this.PHONE.ReadOnly = true;
            // 
            // DIRECTION
            // 
            this.DIRECTION.DataPropertyName = "DIRECTION";
            this.DIRECTION.HeaderText = "Địa chỉ";
            this.DIRECTION.Name = "DIRECTION";
            this.DIRECTION.ReadOnly = true;
            // 
            // PASS
            // 
            this.PASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PASS.DataPropertyName = "PASS";
            this.PASS.HeaderText = "Password";
            this.PASS.Name = "PASS";
            this.PASS.ReadOnly = true;
            this.PASS.ToolTipText = "******";
            this.PASS.Visible = false;
            // 
            // FormUsersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 457);
            this.Controls.Add(this.pnlUsers);
            this.Name = "FormUsersList";
            this.Text = "FormUsersList";
            this.pnlUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlUsers;
        private System.Windows.Forms.DataGridView gvUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROLE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn GENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIRTHDAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULL_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn PHONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
    }
}