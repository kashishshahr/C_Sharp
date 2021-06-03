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

namespace WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += button_MyClick;
            myLabel1.Content = "Hello World";
        }

        

        bool flag = true;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (flag)
            {
                flag = false;
                myLabel.Content = "Hello World";
            }
            else
            {
                flag = true;
                myLabel.Content = "";
            }
        }
        bool flag1 = true;
        private void button_MyClick(object sender, RoutedEventArgs e)
        {
            if (!flag1)
            {
                flag1 = true;
                myLabel1.Content = "Hello World";
            }
            else
            {
                flag1 = false;
                myLabel1.Content = "";
            }
        }
    }
}
