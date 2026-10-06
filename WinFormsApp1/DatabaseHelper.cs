#nullable disable

using System;

namespace WinFormsApp1
{
    // Демонстрационный класс пользователя
    public class UserDummy
    {
        public string PasswordHash { get; set; } = "123";
        public string PasswordSalt { get; set; } = "abc";
        public int RoleId { get; set; } = 1;
        public int IsActive { get; set; } = 1;
    }

    // Класс-помощник базы данных, чтобы убрать ошибки в AuthService
    public static class DatabaseHelper
    {
        public static UserDummy GetUserByLogin(string login)
        {
            if (login == "admin") return new UserDummy();
            return null;
        }

        public static string GetRoleNameById(int roleId)
        {
            return "admin";
        }

        public static void LogLoginAttempt(string login, bool isSuccess, string message)
        {
            // Заглушка логирования
        }
    }

    // Тот самый AuthService с методом Login, который нужен для отчета
    public class AuthService
    {
        public static bool Login(string login, string password, out string userRole)
        {
            userRole = string.Empty;

            var user = DatabaseHelper.GetUserByLogin(login);
            if (user == null || user.IsActive == 0)
            {
                return false;
            }

            bool isPasswordCorrect = PasswordHasher.VerifyPassword(password, user.PasswordSalt, user.PasswordHash);

            if (isPasswordCorrect)
            {
                userRole = DatabaseHelper.GetRoleNameById(user.RoleId);
                DatabaseHelper.LogLoginAttempt(login, true, "Успешная авторизация");
                return true;
            }

            DatabaseHelper.LogLoginAttempt(login, false, "Неверный пароль");
            return false;
        }
    }
}
