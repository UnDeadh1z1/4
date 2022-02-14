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

namespace WpfApplication1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pas.Text == log.Text)
            {
                MessageBox.Show("Ошибка - Логин не может быть равень паролю");
                log.Text = "";
                pas.Text = "";
                return;

            }
            {
                if (pas.MaxLength > 20 && log.MaxLength > 20)
                {
                    MessageBox.Show("Ошибка - Логин или пароль больше 20 символов");
                    log.Text = "";
                    pas.Text = "";
                    return;
                }
                {
                    if (pas.Text.Length < 5 && log.Text.Length < 5)
                    {
                        MessageBox.Show("Ошибка - Логин или пароль меньше 5 символов");
                        log.Text = "";
                        pas.Text = "";
                        return;
                    }
                    {
                        int p = 0;
                        for (int i = 0; i < pas.Text.Length; i++)
                        {
                            if (char.IsLower(pas.Text[i]))
                            {
                                p = 1;
                            }
                        }
                        if (p == 0)
                        {
                            MessageBox.Show("Должна быть хоть одна маленькая буква");
                            log.Text = "";
                            pas.Text = "";
                            return;
                        }
                        {
                            int l = 0;
                            for (int i = 0; i < pas.Text.Length; i++)
                            {
                                if (char.IsUpper(pas.Text[i]))
                                {
                                    l = 1;
                                }
                            }
                            if (l == 0)
                            {
                                MessageBox.Show("Должна быть хоть одна заглавная буква");
                                log.Text = "";
                                pas.Text = "";
                                return;
                            }
                            {
                                int[] Arrey = { 1, 2, 3, 4, 5, 6, 7, 8 };
                                if (Arrey.Any(X => X % 2 == 0))
                                {
                                    MessageBox.Show("yes");
                                }
                                MessageBox.Show("Ok");
                                string s = "QWERTYasdfzxcv";
                                bool z = s.All(x => char.IsUpper(x));
                                int k = s.Count(x => char.IsUpper(x));
                                bool u = s.Any(x => char.IsUpper(x));
                                s.Any(x => new [] { '&', ';', ',' }.Contains(x));

                                MessageBox.Show(z.ToString());
                                MessageBox.Show(k.ToString());
                                MessageBox.Show(u.ToString());
                                MessageBox.Show("Okey");
                            }
                        }

                    }
                }
            }
        }


        private void can_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cllog_Click(object sender, RoutedEventArgs e)
        {
            log.Text = "";
        }

        private void clpas_Click(object sender, RoutedEventArgs e)
        {
            pas.Text = "";
        }
    }
}
