namespace Zayvki
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.iDuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpContainerItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.electronics_repairDataSet = new Zayvki.electronics_repairDataSet();
            this.ClientsTab = new System.Windows.Forms.TabPage();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.iDclientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephonenumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApplicationsTab = new System.Windows.Forms.TabPage();
            this.dataGridApplications = new System.Windows.Forms.DataGridView();
            this.iDapplicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devicetypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDMalfunctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.applicationsTableAdapter = new Zayvki.electronics_repairDataSetTableAdapters.ApplicationsTableAdapter();
            this.clientsTableAdapter = new Zayvki.electronics_repairDataSetTableAdapters.ClientsTableAdapter();
            this.usersTableAdapter = new Zayvki.electronics_repairDataSetTableAdapters.UsersTableAdapter();
            this.MalfunctionsTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.electronicsrepairDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malfunctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.malfunctionTableAdapter = new Zayvki.electronics_repairDataSetTableAdapters.MalfunctionTableAdapter();
            this.iDMalfunctionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malfunctionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malfunctiondescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronics_repairDataSet)).BeginInit();
            this.ClientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.ApplicationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.MalfunctionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicsrepairDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.malfunctionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.dataGridUsers);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(792, 424);
            this.UsersTab.TabIndex = 2;
            this.UsersTab.Text = "Пользователи";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AutoGenerateColumns = false;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDuserDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridUsers.DataSource = this.usersBindingSource;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.Size = new System.Drawing.Size(786, 418);
            this.dataGridUsers.TabIndex = 1;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_CellContentClick);
            // 
            // iDuserDataGridViewTextBoxColumn
            // 
            this.iDuserDataGridViewTextBoxColumn.DataPropertyName = "ID_user";
            this.iDuserDataGridViewTextBoxColumn.HeaderText = "ID_user";
            this.iDuserDataGridViewTextBoxColumn.Name = "iDuserDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteItem,
            this.ChangeItem,
            this.AddItem,
            this.HelpContainerItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 92);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(128, 22);
            this.DeleteItem.Text = "Удалить";
            this.DeleteItem.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ChangeItem
            // 
            this.ChangeItem.Name = "ChangeItem";
            this.ChangeItem.Size = new System.Drawing.Size(128, 22);
            this.ChangeItem.Text = "Изменить";
            this.ChangeItem.Click += new System.EventHandler(this.Change_Click);
            // 
            // AddItem
            // 
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(128, 22);
            this.AddItem.Text = "Добавить";
            this.AddItem.Click += new System.EventHandler(this.Add_Click);
            // 
            // HelpContainerItem
            // 
            this.HelpContainerItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpItem,
            this.AboutItem});
            this.HelpContainerItem.Name = "HelpContainerItem";
            this.HelpContainerItem.Size = new System.Drawing.Size(128, 22);
            this.HelpContainerItem.Text = "Справка";
            // 
            // HelpItem
            // 
            this.HelpItem.Name = "HelpItem";
            this.HelpItem.Size = new System.Drawing.Size(149, 22);
            this.HelpItem.Text = "Помощь";
            this.HelpItem.Click += new System.EventHandler(this.Help_Click);
            // 
            // AboutItem
            // 
            this.AboutItem.Name = "AboutItem";
            this.AboutItem.Size = new System.Drawing.Size(149, 22);
            this.AboutItem.Text = "О программе";
            this.AboutItem.Click += new System.EventHandler(this.About_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.electronics_repairDataSet;
            // 
            // electronics_repairDataSet
            // 
            this.electronics_repairDataSet.DataSetName = "electronics_repairDataSet";
            this.electronics_repairDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientsTab
            // 
            this.ClientsTab.Controls.Add(this.dataGridClients);
            this.ClientsTab.Location = new System.Drawing.Point(4, 22);
            this.ClientsTab.Name = "ClientsTab";
            this.ClientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ClientsTab.Size = new System.Drawing.Size(792, 424);
            this.ClientsTab.TabIndex = 1;
            this.ClientsTab.Text = "Клиенты";
            this.ClientsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridClients
            // 
            this.dataGridClients.AutoGenerateColumns = false;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDclientDataGridViewTextBoxColumn1,
            this.fullnameDataGridViewTextBoxColumn,
            this.telephonenumberDataGridViewTextBoxColumn});
            this.dataGridClients.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridClients.DataSource = this.clientsBindingSource;
            this.dataGridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridClients.Location = new System.Drawing.Point(3, 3);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.Size = new System.Drawing.Size(786, 418);
            this.dataGridClients.TabIndex = 1;
            this.dataGridClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Clients_CellContentClick);
            // 
            // iDclientDataGridViewTextBoxColumn1
            // 
            this.iDclientDataGridViewTextBoxColumn1.DataPropertyName = "ID_client";
            this.iDclientDataGridViewTextBoxColumn1.HeaderText = "ID_client";
            this.iDclientDataGridViewTextBoxColumn1.Name = "iDclientDataGridViewTextBoxColumn1";
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            // 
            // telephonenumberDataGridViewTextBoxColumn
            // 
            this.telephonenumberDataGridViewTextBoxColumn.DataPropertyName = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.HeaderText = "telephone_number";
            this.telephonenumberDataGridViewTextBoxColumn.Name = "telephonenumberDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.electronics_repairDataSet;
            // 
            // ApplicationsTab
            // 
            this.ApplicationsTab.Controls.Add(this.dataGridApplications);
            this.ApplicationsTab.Location = new System.Drawing.Point(4, 22);
            this.ApplicationsTab.Name = "ApplicationsTab";
            this.ApplicationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ApplicationsTab.Size = new System.Drawing.Size(792, 424);
            this.ApplicationsTab.TabIndex = 0;
            this.ApplicationsTab.Text = "Заявки";
            this.ApplicationsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridApplications
            // 
            this.dataGridApplications.AutoGenerateColumns = false;
            this.dataGridApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDapplicationDataGridViewTextBoxColumn,
            this.iDclientDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.devicetypeDataGridViewTextBoxColumn,
            this.iDMalfunctionDataGridViewTextBoxColumn});
            this.dataGridApplications.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridApplications.DataSource = this.applicationsBindingSource;
            this.dataGridApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridApplications.Location = new System.Drawing.Point(3, 3);
            this.dataGridApplications.Name = "dataGridApplications";
            this.dataGridApplications.Size = new System.Drawing.Size(786, 418);
            this.dataGridApplications.TabIndex = 0;
            this.dataGridApplications.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Applications_CellContentClick);
            // 
            // iDapplicationDataGridViewTextBoxColumn
            // 
            this.iDapplicationDataGridViewTextBoxColumn.DataPropertyName = "ID_application";
            this.iDapplicationDataGridViewTextBoxColumn.HeaderText = "ID_application";
            this.iDapplicationDataGridViewTextBoxColumn.Name = "iDapplicationDataGridViewTextBoxColumn";
            // 
            // iDclientDataGridViewTextBoxColumn
            // 
            this.iDclientDataGridViewTextBoxColumn.DataPropertyName = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.HeaderText = "ID_client";
            this.iDclientDataGridViewTextBoxColumn.Name = "iDclientDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // devicetypeDataGridViewTextBoxColumn
            // 
            this.devicetypeDataGridViewTextBoxColumn.DataPropertyName = "Device_type";
            this.devicetypeDataGridViewTextBoxColumn.HeaderText = "Device_type";
            this.devicetypeDataGridViewTextBoxColumn.Name = "devicetypeDataGridViewTextBoxColumn";
            // 
            // iDMalfunctionDataGridViewTextBoxColumn
            // 
            this.iDMalfunctionDataGridViewTextBoxColumn.DataPropertyName = "ID_Malfunction";
            this.iDMalfunctionDataGridViewTextBoxColumn.HeaderText = "ID_Malfunction";
            this.iDMalfunctionDataGridViewTextBoxColumn.Name = "iDMalfunctionDataGridViewTextBoxColumn";
            // 
            // applicationsBindingSource
            // 
            this.applicationsBindingSource.DataMember = "Applications";
            this.applicationsBindingSource.DataSource = this.electronics_repairDataSet;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.ApplicationsTab);
            this.TabControl1.Controls.Add(this.ClientsTab);
            this.TabControl1.Controls.Add(this.MalfunctionsTab);
            this.TabControl1.Controls.Add(this.UsersTab);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(800, 450);
            this.TabControl1.TabIndex = 0;
            // 
            // applicationsTableAdapter
            // 
            this.applicationsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // MalfunctionsTab
            // 
            this.MalfunctionsTab.Controls.Add(this.dataGridView1);
            this.MalfunctionsTab.Location = new System.Drawing.Point(4, 22);
            this.MalfunctionsTab.Name = "MalfunctionsTab";
            this.MalfunctionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.MalfunctionsTab.Size = new System.Drawing.Size(792, 424);
            this.MalfunctionsTab.TabIndex = 3;
            this.MalfunctionsTab.Text = "Неисправности";
            this.MalfunctionsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDMalfunctionDataGridViewTextBoxColumn1,
            this.malfunctionTypeDataGridViewTextBoxColumn,
            this.malfunctiondescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.malfunctionBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 418);
            this.dataGridView1.TabIndex = 1;
            // 
            // electronicsrepairDataSetBindingSource
            // 
            this.electronicsrepairDataSetBindingSource.DataSource = this.electronics_repairDataSet;
            this.electronicsrepairDataSetBindingSource.Position = 0;
            // 
            // malfunctionBindingSource
            // 
            this.malfunctionBindingSource.DataMember = "Malfunction";
            this.malfunctionBindingSource.DataSource = this.electronics_repairDataSet;
            // 
            // malfunctionTableAdapter
            // 
            this.malfunctionTableAdapter.ClearBeforeFill = true;
            // 
            // iDMalfunctionDataGridViewTextBoxColumn1
            // 
            this.iDMalfunctionDataGridViewTextBoxColumn1.DataPropertyName = "ID_Malfunction";
            this.iDMalfunctionDataGridViewTextBoxColumn1.HeaderText = "ID_Malfunction";
            this.iDMalfunctionDataGridViewTextBoxColumn1.Name = "iDMalfunctionDataGridViewTextBoxColumn1";
            // 
            // malfunctionTypeDataGridViewTextBoxColumn
            // 
            this.malfunctionTypeDataGridViewTextBoxColumn.DataPropertyName = "Malfunction_Type";
            this.malfunctionTypeDataGridViewTextBoxColumn.HeaderText = "Malfunction_Type";
            this.malfunctionTypeDataGridViewTextBoxColumn.Name = "malfunctionTypeDataGridViewTextBoxColumn";
            // 
            // malfunctiondescriptionDataGridViewTextBoxColumn
            // 
            this.malfunctiondescriptionDataGridViewTextBoxColumn.DataPropertyName = "Malfunction_description";
            this.malfunctiondescriptionDataGridViewTextBoxColumn.HeaderText = "Malfunction_description";
            this.malfunctiondescriptionDataGridViewTextBoxColumn.Name = "malfunctiondescriptionDataGridViewTextBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Таблицы";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.UsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronics_repairDataSet)).EndInit();
            this.ClientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ApplicationsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsBindingSource)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.MalfunctionsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.electronicsrepairDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.malfunctionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TabPage ClientsTab;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.TabPage ApplicationsTab;
        private System.Windows.Forms.DataGridView dataGridApplications;
        private System.Windows.Forms.TabControl TabControl1;
        private electronics_repairDataSet electronics_repairDataSet;
        private System.Windows.Forms.BindingSource applicationsBindingSource;
        private electronics_repairDataSetTableAdapters.ApplicationsTableAdapter applicationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDapplicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devicetypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMalfunctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private electronics_repairDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDclientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephonenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private electronics_repairDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeItem;
        private System.Windows.Forms.ToolStripMenuItem AddItem;
        private System.Windows.Forms.ToolStripMenuItem HelpContainerItem;
        private System.Windows.Forms.ToolStripMenuItem HelpItem;
        private System.Windows.Forms.ToolStripMenuItem AboutItem;
        private System.Windows.Forms.TabPage MalfunctionsTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource electronicsrepairDataSetBindingSource;
        private System.Windows.Forms.BindingSource malfunctionBindingSource;
        private electronics_repairDataSetTableAdapters.MalfunctionTableAdapter malfunctionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDMalfunctionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malfunctionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malfunctiondescriptionDataGridViewTextBoxColumn;
    }
}