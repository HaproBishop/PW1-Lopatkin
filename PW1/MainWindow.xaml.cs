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
using Lib_8;

//Разработчик студент группы ИСП-31 Лопаткин Сергей
//Практическая работа №1, вариант №8
//Поиск максимума из случайных чисел

namespace PW1
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

        private void AboutProgram_Button_Click(object sender, RoutedEventArgs e)
        {//Вывод задания и разработчика на экран :D
            MessageBox.Show("Лопаткин Сергей Михайлович (Hapro Bishop). Практическая работа №1. Задание №8. Найти максимум из n целых случайных чисел X, распределенных в диапазоне от 0 до n.Вывести на экран на одной строке сгенерированные числа, на другой строкерезультат.", "О программе", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void SetRange_Button_Click(object sender, RoutedEventArgs e)
        {                  
            Random_TextBox.Clear();
            Result_TextBox.Clear();
            bool prv = Int32.TryParse(Range_TextBox.Text, out int n); //Преобразование параметра Range_TextBox.Text в выходной параметр n с типом int             
            //Ввод новой переменной - "n", являющаяся диапазоном чисел, необходимых сгенерировать
            if (prv == true) //Проверка на успешность преобразования параметра Range_TextBox.Text, иначе - задание не будет выполняться
            {
                Random_TextBox.Text = Class_Lib_8.Find_MaxValue(n);
            }                            
        }

        private void Range_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {//Очистка значений, чтобы не путать пользователя
            Random_TextBox.Clear();
            Result_TextBox.Clear();
        }

        private void Find_Button_Click(object sender, RoutedEventArgs e)
        {//Добавление результата в строку, если пользователь захочет увидеть результат поиска            
            if (Random_TextBox.Text == "" || Random_TextBox.Text == null) MessageBox.Show("Сначала создайте список случайных чисел!","ВНИМАНИЕ!", MessageBoxButton.OK, MessageBoxImage.Error);
            else Result_TextBox.Text = Convert.ToString(Class_Lib_8.maxvalue);
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {//Кнопка закрытия программы :D
            this.Close();
        }
    }
}
