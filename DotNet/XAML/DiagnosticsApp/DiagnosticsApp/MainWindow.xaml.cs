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

namespace DiagnosticsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        //    String s = "";
        //    private void TextBox_Changed(object sender, TextChangedEventArgs e)
        //    {
        //        if(tb_cpu.Text.Length!=0)
        //            btn_cpu.IsEnabled = true;
        //        else
        //            btn_cpu.IsEnabled = false;

        //    }



        //    private void SecondButton_Clicked(object sender, RoutedEventArgs e)
        //    {

        //    }

        //    private void IsChecked(object sender, RoutedEventArgs e)
        //    {

        //        tb_memory.IsReadOnly = false;
        //    }

        //    private void cpu_btn_clicked(object sender, RoutedEventArgs e)
        //    {
        //        MessageBox.Show(tb_cpu.Text);
        //    }

        //    private void memory_tb_changed(object sender, TextChangedEventArgs e)
        //    {

        //    }

        //    private void IsUnchecked(object sender, RoutedEventArgs e)
        //    {
        //        tb_memory.IsReadOnly = true;
        //    }

        //    private void IsUnchecked_2(object sender, RoutedEventArgs e)
        //    {
        //        tb_memory.Background = Brushes.Gray;
        //    }

        //    private void IsChecked_1(object sender, RoutedEventArgs e)
        //    {
        //        tb_memory.Background = Brushes.LightGreen;
        //    }
    }
}
