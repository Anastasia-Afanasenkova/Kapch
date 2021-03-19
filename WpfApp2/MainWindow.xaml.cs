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

namespace WpfApp2
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            capcha.Text = null;
            Random rnd = new Random();
            for (int i = 0; i < 16; i++)
                switch (rnd.Next(0, 3))
                {
                    case 0:
                        capcha.Text += (char)rnd.Next(48, 58);
                        break;
                    case 1:
                        capcha.Text += (char)rnd.Next(65, 91);
                        break;
                    case 2:
                        capcha.Text += (char)rnd.Next(97, 123);
                        break;
                }
        }
    }
}
