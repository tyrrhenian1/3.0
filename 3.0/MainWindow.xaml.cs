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

namespace _3._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int i;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void CheckBox2_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int z = rnd.Next(6, 11);
            int x = rnd.Next(6, 11);
            int c = rnd.Next(6, 11);
            int p = rnd.Next(100);
            while (z == x || x == c || z == c)
            {
                z = rnd.Next(6, 11);
                x = rnd.Next(6, 11);
                c = rnd.Next(6, 11);
            }
            if (i > z + x + c)
            {
                Result.Text = "Вы выиграли"+z+x+c;
            }
            else Result.Text = "Вы проиграли,шанс на победу "+p+"%";


        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            i = 24;
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            i = 21;
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            i = 25;
        }

        private void rb4_Checked(object sender, RoutedEventArgs e)
        {
            i = 23;
        }

        private void rb5_Checked(object sender, RoutedEventArgs e)
        {
            i = 23;
        }

        private void rb6_Checked(object sender, RoutedEventArgs e)
        {
            i = 0;
        }
    }
}