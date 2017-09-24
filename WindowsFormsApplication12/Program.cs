/*1)Вывести на экран свое (краткое!!!) резюме с помощью последова-
тельности MessageBox’ов (числом не менее трех). Причем на заголовке
последнего должно отобразиться среднее число символов на странице
(общее количество символов в резюме / количество MessageBox’ов).
2)Написать функцию, которая «угадывает» задуманное пользова-
телем число от 1 до 2000. Для запроса к пользователю использовать
MessageBox. После того, как число отгадано, необходимо вывести
количество запросов, потребовавшихся для этого, и предоставить
пользователю возможность сыграть еще раз, не выходя из программы
(MessageBox’ы оформляются кнопками и значками соответственно
ситуации).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
