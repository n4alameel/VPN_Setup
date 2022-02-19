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
using System.Windows.Shapes;

namespace VPN_Setup
{
    /// <summary>
    /// Логика взаимодействия для DestinationLocationWindow.xaml
    /// </summary>
    public partial class DestinationLocationWindow : Window
    {
        public DestinationLocationWindow()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                LocationTB.Text = filename;
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
                this.Close();
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.Owner.IsActive == false)
            {
                App.Current.Shutdown();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            ShortcutsWindow shortcutsWindow = new ShortcutsWindow();
            shortcutsWindow.Owner = this;
            this.Hide();
            shortcutsWindow.Show();
        }
    }
}
