using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Sv1.IsEnabled = Sv2.IsEnabled = Sv3.IsEnabled = false;
            rb1.IsEnabled = rb2.IsEnabled = rb3.IsEnabled = rb4.IsEnabled = rb5.IsEnabled = rb6.IsEnabled = false;
            Ch1.IsEnabled = Ch2.IsEnabled = Ch3.IsEnabled = false;

        }
        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            if(rb2.IsChecked == true) i = 24;
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            if(rb1.IsChecked == true) i = 21;
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            if (rb3.IsChecked == true) i = 25;
        }

        private void rb4_Checked(object sender, RoutedEventArgs e)
        {
            if (rb4.IsChecked == true) i = 23;
        }

        private void rb5_Checked(object sender, RoutedEventArgs e)
        {
            if(rb5.IsChecked == true) i = 23;
        }

        private void rb6_Checked(object sender, RoutedEventArgs e)
        {
            if(rb6.IsChecked == true) i = 0;
        }
        private void Ch1_Click(object sender, RoutedEventArgs e)
        {
            if (Ch1.IsChecked == true)
            {
                Sv1.IsEnabled = true;
            }
            else Sv1.IsEnabled = false;
        }

        private void Ch2_Click(object sender, RoutedEventArgs e)
        {
            if (Ch2.IsChecked == true)
            {
                Sv2.IsEnabled = true;
            }
            else Sv2.IsEnabled = false;
        }

        private void Ch3_Click(object sender, RoutedEventArgs e)
        {
            if (Ch3.IsChecked == true)
            {
                Sv3.IsEnabled = true;
            }
            else Sv3.IsEnabled = false;
        }
        private void Vi1_Click(object sender, RoutedEventArgs e)
        {
            if (Vi1.IsChecked == true)
            {
                Ch1.IsChecked = Ch2.IsChecked = Ch3.IsChecked = false;
                rb1.IsEnabled = rb2.IsEnabled = rb3.IsEnabled = rb4.IsEnabled = rb5.IsEnabled = rb6.IsEnabled = true;
                Ch1.IsEnabled = Ch2.IsEnabled = Ch3.IsEnabled = false;
                Sv1.IsEnabled = Sv2.IsEnabled = Sv3.IsEnabled = false;
            }

        }

        private void Vi2_Click(object sender, RoutedEventArgs e)
        {
            if (Vi2.IsChecked == true)
            {
                rb1.IsEnabled = rb2.IsEnabled = rb3.IsEnabled = rb4.IsEnabled = rb5.IsEnabled = rb6.IsEnabled = false;
                rb1.IsChecked = rb2.IsChecked = rb3.IsChecked = rb4.IsChecked = rb5.IsChecked = rb6.IsChecked = false;
                Ch1.IsEnabled = Ch2.IsEnabled = Ch3.IsEnabled = true;

            }
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool? j = Vi1.IsChecked;
                int z, x, c;
                Random rnd = new Random();
                z = x = c = 1;
                int p = rnd.Next(100);
                while (z == x || x == c || z == c)
                {
                    z = rnd.Next(6, 11);
                    x = rnd.Next(6, 11);
                    c = rnd.Next(6, 11);
                }
                switch (j)
                {
                    case true:
                        if (i > z + x + c)
                        {
                            Result.Text = "Вы выиграли";
                        }
                        else Result.Text = "Вы проиграли,шанс на победу " + p + "%";
                        break;
                    case false:
                        {
                            double k = 0;
                            if (Sv1.IsEnabled == true)
                            {

                                k += double.Parse(Sv1.Text);

                            }

                            if (Sv2.IsEnabled == true)
                            {
                                k += double.Parse(Sv2.Text);
                            }

                            if (Sv3.IsEnabled == true)
                            {
                                k += double.Parse(Sv3.Text);
                            }

                            if (k > z + x + c)
                            {
                                Result.Text = "Вы выиграли";
                            }
                            else Result.Text = "Вы проиграли,шанс на победу " + p + "%";


                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
    }
