using Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flights
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Создаем и показываем форму авторизации
            using (LoginForm loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Если аутентификация успешна, открываем основное окно
                    Application.Run(new Schedule());
                }
                else
                {
                    // Если аутентификация не удалась, закрываем приложение
                    Application.Exit();
                }
            }

        }
    }
}

     