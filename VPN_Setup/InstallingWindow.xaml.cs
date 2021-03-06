using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VPN_Setup
{
    /// <summary>
    /// Логика взаимодействия для InstallingWindow.xaml
    /// </summary>
    public partial class InstallingWindow : Window
    {
        public InstallingWindow()
        {
            InitializeComponent();
            
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progbar.Value++;
                Thread.Sleep(100);
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Owner.IsActive == false)
            {
                App.Current.Shutdown();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            string text = "Setup is not complete. If you exit now< the program will not be installed. \n \n You may run Setup again at another time to complete the installation. \n \n Exit Setup?";
            MessageBoxResult result = MessageBox.Show(text, "Exit Setup", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.Current.Shutdown();
            }
            else
            {

            }
        }
    }
}
