using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VPN_Setup
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            NextButton.IsEnabled = false;
            DisagreeRB.IsChecked = true; 
            StreamReader sr = new StreamReader("Agreement.txt");
            AgreementSW.Content = sr.ReadToEnd();
            sr.Close();
            
        }

        private void AgreeRB_Checked(object sender, RoutedEventArgs e)
        {
            DisagreeRB.IsChecked = false;
            NextButton.IsEnabled = true;
        }

        private void DisagreeRB_Checked(object sender, RoutedEventArgs e)
        {
            AgreeRB.IsChecked = false;
            NextButton.IsEnabled = false;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {

            string text = "Setup is not complete. If you exit now< the program will not be installed. \n \n You may run Setup again at another time to complete the installation. \n \n Exit Setup?";
            MessageBoxResult result = MessageBox.Show( text, "Exit Setup", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
            else
            {
                
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            DestinationLocationWindow window = new DestinationLocationWindow();
            window.Owner = this;
            window.Show();
            this.Hide();
        }
    }
}
