#nullable disable // Отключает предупреждения о значениях NULL для совместимости

using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.Services;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        // Элементы управления создаем динамически в коде
        private Label lblTitle = new Label();
        private Label lblLogin = new Label();
        private TextBox txtLogin = new TextBox();
        private Label lblPassword = new Label();
        private TextBox txtPassword = new TextBox();
        private Panel panelCaptcha = new Panel();
        private Button btnRefreshCaptcha = new Button();
        private PictureBox pictureBoxCaptcha = new PictureBox();
        private TextBox txtCaptchaInput = new TextBox();
        private Label lblCaptchaHint = new Label();
        private Button btnLogin = new Button();
        private Label lblLockStatus = new Label();

        private readonly CaptchaService _captchaService = new CaptchaService();
        private string _currentCaptchaText = "";

        private int _failedAttempts = 0;
        private bool _isLocked = false;
        private int _lockTimerSeconds = 0;

        // Явно указываем System.Windows.Forms.Timer, чтобы убрать неоднозначность
        private System.Windows.Forms.Timer _lockTimer = new System.Windows.Forms.Timer();

        public LoginForm()
        {
            // Настройка самой формы входа
            this.Size = new Size(360, 420);
            this.Text = "Вход в систему";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Вызов ручной сборки интерфейса
            BuildInterface();

            _lockTimer.Interval = 1000;
            _lockTimer.Tick += LockTimer_Tick;
        }

        private void BuildInterface()
        {
            // Заголовок
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(12, 15);
            lblTitle.Size = new Size(320, 35);
            lblTitle.Text = "Авторизация";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // Логин
            lblLogin.Text = "Логин:";
            lblLogin.Location = new Point(35, 65);
            lblLogin.AutoSize = true;

            txtLogin.Location = new Point(35, 83);
            txtLogin.Size = new Size(270, 23);

            // Пароль
            lblPassword.Text = "Пароль:";
            lblPassword.Location = new Point(35, 119);
            lblPassword.AutoSize = true;

            txtPassword.Location = new Point(35, 137);
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(270, 23);

            // Панель CAPTCHA
            panelCaptcha.Location = new Point(35, 175);
            panelCaptcha.Size = new Size(270, 105);
            panelCaptcha.Visible = false;

            lblCaptchaHint.Text = "Введите код с картинки:";
            lblCaptchaHint.Location = new Point(0, 2);
            lblCaptchaHint.AutoSize = true;

            pictureBoxCaptcha.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxCaptcha.Location = new Point(0, 20);
            pictureBoxCaptcha.Size = new Size(140, 40);

            btnRefreshCaptcha.Text = "🔄";
            btnRefreshCaptcha.Location = new Point(145, 20);
            btnRefreshCaptcha.Size = new Size(30, 40);
            btnRefreshCaptcha.Click += (s, e) => GenerateNewCaptcha();

            txtCaptchaInput.Location = new Point(0, 78);
            txtCaptchaInput.Size = new Size(270, 23);

            panelCaptcha.Controls.AddRange(new Control[] { lblCaptchaHint, pictureBoxCaptcha, btnRefreshCaptcha, txtCaptchaInput });

            // Кнопка Вход
            btnLogin.Text = "Войти";
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.Location = new Point(35, 300);
            btnLogin.Size = new Size(270, 35);
            btnLogin.Click += btnLogin_Click;

            // Статус блокировки
            lblLockStatus.ForeColor = Color.Red;
            lblLockStatus.Location = new Point(12, 345);
            lblLockStatus.Size = new Size(320, 20);
            lblLockStatus.TextAlign = ContentAlignment.MiddleCenter;

            // Добавляем всё на форму
            this.Controls.AddRange(new Control[] { lblTitle, lblLogin, txtLogin, lblPassword, txtPassword, panelCaptcha, btnLogin, lblLockStatus });
        }

        private void GenerateNewCaptcha()
        {
            _currentCaptchaText = _captchaService.GenerateText(4);
            pictureBoxCaptcha.Image = _captchaService.GenerateImage(_currentCaptchaText, pictureBoxCaptcha.Width, pictureBoxCaptcha.Height);
            txtCaptchaInput.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_isLocked) return;

            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Заполните логин и пароль!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (panelCaptcha.Visible)
            {
                if (txtCaptchaInput.Text.Trim().ToUpper() != _currentCaptchaText)
                {
                    MessageBox.Show("Неверный код CAPTCHA!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HandleFailedAttempt();
                    return;
                }
            }

            if (txtLogin.Text == "admin" && txtPassword.Text == "admin123")
            {
                MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _failedAttempts = 0;
                panelCaptcha.Visible = false;

                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HandleFailedAttempt();
            }
        }

        private void HandleFailedAttempt()
        {
            _failedAttempts++;

            if (_failedAttempts >= 3)
            {
                StartLockout(10);
            }
            else if (_failedAttempts >= 1)
            {
                panelCaptcha.Visible = true;
                GenerateNewCaptcha();
            }
        }

        private void StartLockout(int seconds)
        {
            _isLocked = true;
            _lockTimerSeconds = seconds;
            btnLogin.Enabled = false;
            lblLockStatus.Text = $"Вход заблокирован на {_lockTimerSeconds} сек.";
            _lockTimer.Start();
        }

        private void LockTimer_Tick(object sender, EventArgs e)
        {
            _lockTimerSeconds--;
            if (_lockTimerSeconds <= 0)
            {
                _lockTimer.Stop();
                _isLocked = false;
                btnLogin.Enabled = true;
                lblLockStatus.Text = "";
                _failedAttempts = 0;
                GenerateNewCaptcha();
            }
            else
            {
                lblLockStatus.Text = $"Вход заблокирован на {_lockTimerSeconds} сек.";
            }
        }
    }
}
