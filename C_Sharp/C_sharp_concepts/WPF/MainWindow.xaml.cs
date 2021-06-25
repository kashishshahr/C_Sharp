using System;
using System.Reflection;
using System.Windows;

namespace WPF
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

        private void btnDiscoveryTypeInformation_Click(object sender, RoutedEventArgs e)
        {
            string typeName = txtTypeName.Text;
            Type T = Type.GetType(typeName);
            if (T != null)
            {
                MethodInfo[] methods = T.GetMethods();
                foreach (var method in methods)
                {
                    
                    lstMethods.Items.Add(method.ReturnType.Name+" "+method.Name);
                }
                PropertyInfo[] properyInfos = T.GetProperties();
                foreach (var prop in properyInfos)
                {
                    lstProperties.Items.Add(prop.PropertyType.Name+" "+ prop.Name);
                }
                ConstructorInfo[] ctors= T.GetConstructors();
                foreach (var ctor in ctors)
                {
                    lstConstructors.Items.Add(ctor.ToString());
                }
            }
            else
            {
                MessageBox.Show("Invalid Type..Please enter Again");
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public Customer()
        {
            Id = -1;
            Name = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("ID={0}", Id);

        }
        public void PrintName()
        {
            Console.WriteLine("Name={1}", null, Name);

        }
    }
}
