namespace WinFormsApp1
{
    partial class Form1
    {
        // Добавлен знак ?, чтобы убрать предупреждения о NULL значениях
        private System.ComponentModel.IContainer? components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            carsToolStripMenuItem = new ToolStripMenuItem();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusUser = new ToolStripStatusLabel();
            panelTop = new Panel();
            lblFilterStatus = new Label();
            cmbStatusFilter = new ComboBox();
            txtSearch = new TextBox();
            lblSearch = new Label();
            dgvOrders = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colClient = new DataGridViewTextBoxColumn();
            colCar = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            panelActions = new Panel();
            btnDeleteOrder = new Button();
            btnEditOrder = new Button();
            btnAddOrder = new Button();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            panelActions.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ordersToolStripMenuItem, clientsToolStripMenuItem, carsToolStripMenuItem, servicesToolStripMenuItem, usersToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1010, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(74, 24);
            ordersToolStripMenuItem.Text = "Заявки";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(83, 24);
            clientsToolStripMenuItem.Text = "Клиенты";
            // 
            // carsToolStripMenuItem
            // 
            carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            carsToolStripMenuItem.Size = new Size(111, 24);
            carsToolStripMenuItem.Text = "Автомобили";
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(147, 24);
            servicesToolStripMenuItem.Text = "Справочник услуг";
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            usersToolStripMenuItem.Size = new Size(122, 24);
            usersToolStripMenuItem.Text = "Пользователи";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusUser });
            statusStrip1.Location = new Point(0, 722);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1010, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusUser
            // 
            lblStatusUser.Name = "lblStatusUser";
            lblStatusUser.Size = new Size(240, 20);
            lblStatusUser.Text = "Вы вошли как: Оператор (Кеся В)";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblFilterStatus);
            panelTop.Controls.Add(cmbStatusFilter);
            panelTop.Controls.Add(txtSearch);
            panelTop.Controls.Add(lblSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 30);
            panelTop.Margin = new Padding(3, 4, 3, 4);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1010, 67);
            panelTop.TabIndex = 2;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(389, 24);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(55, 20);
            lblFilterStatus.TabIndex = 3;
            lblFilterStatus.Text = "Статус:";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "Все заявки", "Новая", "В работе", "Выполнена" });
            cmbStatusFilter.Location = new Point(448, 19);
            cmbStatusFilter.Margin = new Padding(3, 4, 3, 4);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(159, 28);
            cmbStatusFilter.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(126, 19);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Введите гос. номер или фамилию...";
            txtSearch.Size = new Size(228, 27);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(14, 24);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(119, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Быстрый поиск:";
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.BackgroundColor = SystemColors.Window;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { colId, colDate, colClient, colCar, colPrice, colStatus });
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 97);
            dgvOrders.Margin = new Padding(3, 4, 3, 4);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.RowTemplate.Height = 25;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1010, 545);
            dgvOrders.TabIndex = 3;
            // 
            // colId
            // 
            colId.FillWeight = 50F;
            colId.HeaderText = "№ Заявки";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.FillWeight = 90F;
            colDate.HeaderText = "Дата создания";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colClient
            // 
            colClient.HeaderText = "Клиент";
            colClient.MinimumWidth = 6;
            colClient.Name = "colClient";
            colClient.ReadOnly = true;
            // 
            // colCar
            // 
            colCar.HeaderText = "Автомобиль";
            colCar.MinimumWidth = 6;
            colCar.Name = "colCar";
            colCar.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.FillWeight = 80F;
            colPrice.HeaderText = "Стоимость (руб.)";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 80F;
            colStatus.HeaderText = "Статус";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(btnDeleteOrder);
            panelActions.Controls.Add(btnEditOrder);
            panelActions.Controls.Add(btnAddOrder);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 642);
            panelActions.Margin = new Padding(3, 4, 3, 4);
            panelActions.Name = "panelActions";
            panelActions.Size = new Size(1010, 80);
            panelActions.TabIndex = 4;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteOrder.BackColor = Color.MistyRose;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.Location = new Point(837, 19);
            btnDeleteOrder.Margin = new Padding(3, 4, 3, 4);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(160, 43);
            btnDeleteOrder.TabIndex = 2;
            btnDeleteOrder.Text = "❌ Удалить заявку";
            btnDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new Point(192, 19);
            btnEditOrder.Margin = new Padding(3, 4, 3, 4);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(206, 43);
            btnEditOrder.TabIndex = 1;
            btnEditOrder.Text = "✎ Изменить / Назначить мастера";
            btnEditOrder.UseVisualStyleBackColor = true;
            // 
            // btnAddOrder
            // 
            btnAddOrder.BackColor = Color.LightCyan;
            btnAddOrder.FlatStyle = FlatStyle.Flat;
            btnAddOrder.Location = new Point(14, 19);
            btnAddOrder.Margin = new Padding(3, 4, 3, 4);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(160, 43);
            btnAddOrder.TabIndex = 0;
            btnAddOrder.Text = "➕ Новая заявка";
            btnAddOrder.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 748);
            Controls.Add(dgvOrders);
            Controls.Add(panelActions);
            Controls.Add(panelTop);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1026, 784);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Автосервис — Панель управления заявками";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            panelActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1 = null!;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem = null!;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem = null!;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem = null!;
        private System.Windows.Forms.ToolStripMenuItem servicesToolStripMenuItem = null!;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem = null!;
        private System.Windows.Forms.StatusStrip statusStrip1 = null!;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUser = null!;
        private System.Windows.Forms.Panel panelTop = null!;
        private System.Windows.Forms.Label lblFilterStatus = null!;
        private System.Windows.Forms.ComboBox cmbStatusFilter = null!;
        private System.Windows.Forms.TextBox txtSearch = null!;
        private System.Windows.Forms.Label lblSearch = null!;
        private System.Windows.Forms.DataGridView dgvOrders = null!;
        private System.Windows.Forms.Panel panelActions = null!;
        private System.Windows.Forms.Button btnDeleteOrder = null!;
        private System.Windows.Forms.Button btnEditOrder = null!;
        private System.Windows.Forms.Button btnAddOrder = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClient = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCar = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice = null!;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus = null!;
    }
}