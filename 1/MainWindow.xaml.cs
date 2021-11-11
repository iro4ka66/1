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
using ClassLibrary1;

namespace _1
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
        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнила студентка группы ИСП-31 Баева Ирина\n" +
                "Генерировать случайные числа Х, распределенные в диапазоне от - 4 до 7 и вычислять для чисел > 0 " +
                "X, а для чисел < 0 функцию x^2.Вычисления прекратить, когда подряд появится два одинаковых случайных числа." +
                "На экран необходимо выводить сгенерированное число и результат расчета функции наразных строках");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int n = random.Next(10);
            Class1.Start(n, out string str, out string str2 , out string str3); //используем функцию
            Zn.Text = str; //вывод сгенерированных чисел
            Rez1.Text = Convert.ToString(str2); //вывод str2(выводим результаты чисел)
            Rez2.Text = Convert.ToString(str3); //вывод str3(выводим результаты чисел)
        } 
    }
}
