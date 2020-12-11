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

namespace WPFdemo
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

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            //Exempel på hur man kan skriva om o kolla om sender är en knapp
            //IS är ett nyckelord som kolar om det är av samma typ
            // if (e.Sourse is Button button) 
            //{
            //InOutField.Text += button.Content; //InOutField är namnet på textfältet 
            //}
            MyTextBlock.Text += "Clicked";

        }
    }
}
