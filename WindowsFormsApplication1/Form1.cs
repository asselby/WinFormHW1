/*Написать функцию, которая «угадывает» задуманное пользова-
телем число от 1 до 2000. Для запроса к пользователю использовать
MessageBox. После того, как число отгадано, необходимо вывести
количество запросов, потребовавшихся для этого, и предоставить
пользователю возможность сыграть еще раз, не выходя из программы
(MessageBox’ы оформляются кнопками и значками соответственно
ситуации).*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int number;
            int maxNumber = 2000;
            int minNumber = 1;
            int count = 0;
            for (;;)
            {
                MessageBox.Show("Загадайте число в диапазоне от 1 до 2000");
                DialogResult result = MessageBox.Show("Ваше число в диапазоне от 1 до 1999?", "", MessageBoxButtons.YesNo);
                                count++;
                if (result == DialogResult.No)
                {
                    number = maxNumber;
                    DialogResult resultNewGame = MessageBox.Show(String.Format("Числов загаданное Вами - 2000! Количество запросов -{0}! Начать игру заново?", 
                        count.ToString()), " ", MessageBoxButtons.YesNo);
                    if (resultNewGame == DialogResult.No)
                    {
                        break;
                        Environment.Exit(0);
                    }                    
                }
                if (result == DialogResult.Yes)
                {
                    DialogResult yesResult = MessageBox.Show(String.Format("Числов загаданное Вами - {0}?", minNumber, maxNumber), "", MessageBoxButtons.YesNo);
                    count++;
                    if (yesResult == DialogResult.Yes)
                        MessageBox.Show(String.Format("Количество запросов - {0}! Начать игру заново?", count));
                    else
                    {
                        maxNumber -= 1;
                        minNumber += 1;
                        DialogResult firstResult = MessageBox.Show(String.Format("Ваше число в диапазоне от {0} до {1}?", minNumber, maxNumber));
                        count++;
                        DialogResult secondResult = MessageBox.Show(String.Format("Ваше число в диапазоне от {0} до {1}?", minNumber, maxNumber));
                    }
                }
            }
        }
    }
}



