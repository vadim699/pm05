#nullable disable

using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OrderEditForm : Form
    {
        private Label lblTitle = new Label();
        private Label lblClient = new Label();
        private ComboBox cmbClient = new ComboBox();
        private Label lblCar = new Label();
        private ComboBox cmbCar = new ComboBox();
        private Label lblService = new Label();
        private CheckedListBox clbServices = new CheckedListBox();
        private Label lblStatus = new Label();
        private ComboBox cmbStatus = new ComboBox();
        private Button btnSave = new Button();
        private Button btnCancel = new Button();

        public OrderEditForm()
        {
            // Настройка окна
            this.Size = new Size(400, 500);
            this.Text = "Оформление заявки на ремонт";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;

            BuildInterface();
            LoadDemoData();
        }

        private void BuildInterface()
        {
            // Заголовок
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 15);
            lblTitle.Size = new Size(360, 25);
            lblTitle.Text = "Новая заявка на обслуживание";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Выбор клиента
            lblClient.Text = "Выберите клиента:";
            lblClient.Location = new Point(25, 55);
            lblClient.AutoSize = true;

            cmbClient.Location = new Point(25, 73);
            cmbClient.Size = new Size(330, 23);
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;

            // Выбор авто
            lblCar.Text = "Автомобиль клиента:";
            lblCar.Location = new Point(25, 110);
            lblCar.AutoSize = true;

            cmbCar.Location = new Point(25, 128);
            cmbCar.Size = new Size(330, 23);
            cmbCar.DropDownStyle = ComboBoxStyle.DropDownList;

            // Выбор услуг
            lblService.Text = "Выберите оказываемые услуги:";
            lblService.Location = new Point(25, 165);
            lblService.AutoSize = true;

            clbServices.Location = new Point(25, 183);
            clbServices.Size = new Size(330, 140);

            // Статус
            lblStatus.Text = "Статус заявки:";
            lblStatus.Location = new Point(25, 335);
            lblStatus.AutoSize = true;

            cmbStatus.Location = new Point(25, 353);
            cmbStatus.Size = new Size(330, 23);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.AddRange(new object[] { "Новая", "В работе", "Выполнена" });
            cmbStatus.SelectedIndex = 0;

            // Кнопки
            btnSave.Text = "💾 Сохранить заказ";
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Location = new Point(25, 405);
            btnSave.Size = new Size(150, 35);
            btnSave.BackColor = Color.LightGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Click += (s, e) => {
                MessageBox.Show("Заявка успешно сохранена в базу данных!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnCancel.Text = "❌ Отмена";
            btnCancel.Location = new Point(205, 405);
            btnCancel.Size = new Size(150, 35);
            btnCancel.Click += (s, e) => this.Close();

            // Добавление элементов на форму
            this.Controls.AddRange(new Control[] {
                lblTitle, lblClient, cmbClient, lblCar, cmbCar,
                lblService, clbServices, lblStatus, cmbStatus, btnSave, btnCancel
            });
        }

        private void LoadDemoData()
        {
            // Наполнение выпадающих списков для красивого скриншота
            cmbClient.Items.AddRange(new object[] { "Иванов Иван Иванович", "Петров Сергей Владимирович", "Сидоров Алексей Михайлович" });
            cmbClient.SelectedIndex = 0;

            cmbCar.Items.AddRange(new object[] { "Toyota Camry (А123АА77)", "KIA Rio (В456ВВ99)", "BMW X5 (О777ОО177)" });
            cmbCar.SelectedIndex = 0;

            clbServices.Items.Add("Замена моторного масла и фильтра", true);
            clbServices.Items.Add("Диагностика тормозной системы", true);
            clbServices.Items.Add("Замена передних тормозных колодок", false);
            clbServices.Items.Add("Регулировка сход-развала", false);
            clbServices.Items.Add("Компьютерная диагностика ДВС", false);
        }
    }
}
