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

namespace Wpf1_participation1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //List<Application> user = new List<Application>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name, address;
            int zipcode;
            name = Namebox.Text;
            address = Addressbox.Text;
            zipcode = Convert.ToInt32(Zipcode.Text);
            bool isFormValid = true;
            if (name == "" || name == string.Empty)
            {
                MessageBox.Show("Please input your name");
                Namebox.Focus();
                //return;
                isFormValid = false;
            }

            else if (address == string.Empty)
            {
                MessageBox.Show("Please enter your address");
                isFormValid = false;
            }
            if (isFormValid == false)
            {
                return;
            }
            EntryForm ef = new EntryForm();
            ef.Namebox = name;
            ef.Addressbox = address;
            ef.ZipCode = zipcode;

            //string entryForm = ($"{name} lives at {address} {zipcode}");
            lstApplications.Items.Add(ef);
            //string name = Namebox.Text;
            //Application a = new Application();
            //a.Namebox = Convert.ToString(Name);
            //a.Address = Convert.ToString(Address);
            ////a.ZipCode = Convert.ToInt32(Zipcode);
            //user.Add(a);
            //MessageBox.Show($"Hello {name}");
            
        }

        private void Listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
