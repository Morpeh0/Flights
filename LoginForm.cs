using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights

{
    public partial class LoginForm : Form
    {
        private List<User> users = new List<User>
        {
            new User { Username = "user1", PasswordHash = ComputeSha256Hash("password1") },
            new User { Username = "user2", PasswordHash = ComputeSha256Hash("password2") }
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private bool Authenticate(string username, string password)
        {
            string passwordHash = ComputeSha256Hash(password);
            foreach (var user in users)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.PasswordHash == passwordHash)
                {
                    return true;
                }
            }
            return false;
        }

        private static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Проверяем логин и пароль
            if (Authenticate(username, password)) // Замените на вашу логику аутентификации
            {
                MessageBox.Show("Аутентификация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Устанавливаем результат диалога
                this.Close(); // Закрываем форму
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public class User
        {
            public string Username { get; set; }
            public string PasswordHash { get; set; } // Хэш пароля
        }
    }
}



      
