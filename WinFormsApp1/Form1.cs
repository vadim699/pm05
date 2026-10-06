#nullable disable // Отключает строгие предупреждения компилятора о NULL

using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Устанавливаем начальное значение фильтра
            cmbStatusFilter.SelectedIndex = 0;

            // Заполняем таблицу тестовыми данными для красивого скриншота в отчет
            dgvOrders.Rows.Add("1", "06.10.2026", "Иванов И.И.", "Toyota Camry (А123АА77)", "5 500", "В работе");
            dgvOrders.Rows.Add("2", "06.10.2026", "Петров С.В.", "KIA Rio (В456ВВ99)", "1 200", "Новая");
            dgvOrders.Rows.Add("3", "05.10.2026", "Сидоров А.М.", "BMW X5 (О777ОО177)", "24 000", "Выполнена");

            // Принудительно назначаем событие клика для кнопки добавления заявки
            btnAddOrder.Click += btnAddOrder_Click;
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            OrderEditForm editForm = new OrderEditForm();
            editForm.ShowDialog();
        }

        // Метод-заглушка, чтобы исправить ошибку «Имя menuStrip1_ItemClicked не существует»
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Оставляем пустым
        }
    }
}
