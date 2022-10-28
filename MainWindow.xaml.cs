using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace YP7_Cherednichenko402
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            if (tabcontrol.SelectedIndex < tabcontrol.Items.Count)
                tabcontrol.SelectedIndex++;
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void b101_Click(object sender, RoutedEventArgs e)
        {
            string a = "";

            //неправильные ответы на вопросы
            //на 1 вопрос (правильно 3)
            if (rb11.IsChecked == true || rb12.IsChecked == true)
            {
                a = a + tb11.Text + Environment.NewLine;
            }
            //на 2 вопрос (правильно 1)
            if (rb22.IsChecked == true || rb23.IsChecked == true)
            {
                a = a + tb21.Text + Environment.NewLine;
            }
            //на 3 вопрос (правильно 1)
            if (rb32.IsChecked == true || rb33.IsChecked == true)
            {
                a = a + tb31.Text + Environment.NewLine;
            }
            //на 4 вопрос (правильно 2)
            if (rb41.IsChecked == true || rb43.IsChecked == true)
            {
                a = a + tb41.Text + Environment.NewLine;
            }
            //на 5 вопрос (правильно 3)
            if (rb51.IsChecked == true || rb52.IsChecked == true)
            {
                a = a + tb51.Text + Environment.NewLine;
            }
            //на 6 вопрос (правильно 2)
            if (rb61.IsChecked == true || rb63.IsChecked == true)
            {
                a = a + tb61.Text + Environment.NewLine;
            }
            //на 7 вопрос (правильно 2)
            if (rb71.IsChecked == true || rb73.IsChecked == true)
            {
                a = a + tb71.Text + Environment.NewLine;
            }
            //на 8 вопрос (правильно 1)
            if (rb82.IsChecked == true || rb83.IsChecked == true)
            {
                a = a + tb81.Text + Environment.NewLine;
            }
            //на 9 вопрос (правильно 3)
            if (rb91.IsChecked == true || rb92.IsChecked == true)
            {
                a = a + tb91.Text + Environment.NewLine;
            }
            //на 10 вопрос (правильно 1)
            if (rb102.IsChecked == true || rb103.IsChecked == true)
            {
                a = a + tb101.Text + Environment.NewLine;
            }

            //если не ответили на вопрос
            string x = "";
            if (rb11.IsChecked == false && rb12.IsChecked == false && rb13.IsChecked == false)
                x = x + "Вопрос 1" + Environment.NewLine;
            if (rb21.IsChecked == false && rb22.IsChecked == false && rb23.IsChecked == false)
                x = x + "Вопрос 2" + Environment.NewLine;
            if (rb31.IsChecked == false && rb32.IsChecked == false && rb33.IsChecked == false)
                x = x + "Вопрос 3" + Environment.NewLine;
            if (rb41.IsChecked == false && rb42.IsChecked == false && rb43.IsChecked == false)
                x = x + "Вопрос 4" + Environment.NewLine;
            if (rb51.IsChecked == false && rb52.IsChecked == false && rb53.IsChecked == false)
                x = x + "Вопрос 5" + Environment.NewLine;
            if (rb61.IsChecked == false && rb62.IsChecked == false && rb63.IsChecked == false)
                x = x + "Вопрос 6" + Environment.NewLine;
            if (rb71.IsChecked == false && rb72.IsChecked == false && rb73.IsChecked == false)
                x = x + "Вопрос 7" + Environment.NewLine;
            if (rb81.IsChecked == false && rb82.IsChecked == false && rb83.IsChecked == false)
                x = x + "Вопрос 8" + Environment.NewLine;
            if (rb91.IsChecked == false && rb92.IsChecked == false && rb93.IsChecked == false)
                x = x + "Вопрос 9" + Environment.NewLine;
            if (rb101.IsChecked == false && rb102.IsChecked == false && rb103.IsChecked == false)
                x = x + "Вопрос 10" + Environment.NewLine;

            if (x != "")
            {
                MessageBox.Show("Вы не ответили вопросы:" + Environment.NewLine + x);
            }

            else if (a == "")
                MessageBox.Show("Вы ответили правильно на все вопросы!! :)", "Тестирование завершено");
            else
                MessageBox.Show("Вопросы, на которые вы ответили неверно:" + Environment.NewLine + a, "Тестирование завершено");


            float c = 0;
            //подсчет правильных ответов
            if (rb13.IsChecked == true)
                c = c + 1;
            if (rb21.IsChecked == true)
                c = c + 1;
            if (rb31.IsChecked == true)
                c = c + 1;
            if (rb42.IsChecked == true)
                c = c + 1;
            if (rb53.IsChecked == true)
                c = c + 1;
            if (rb62.IsChecked == true)
                c = c + 1;
            if (rb72.IsChecked == true)
                c = c + 1;
            if (rb81.IsChecked == true)
                c = c + 1;
            if (rb93.IsChecked == true)
                c = c + 1;
            if (rb101.IsChecked == true)
                c = c + 1;

            //расчет оценки
            float i = 0;
            i = c / 2;
            if (i < 2)
                i = 2;

            if (x == "")
                tabcontrol.SelectedIndex++;
            itog1.Text = "Правильных ответов: " + c;
            itog2.Text = "Оценка в пятибальной системе: " + i;

        }



        private void itogB1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }


    }
}
