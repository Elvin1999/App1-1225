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

namespace App1
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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                MessageBox.Show($"{btn.Content} clicked");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("WPF", "INNER BUTTON CLICKED", MessageBoxButton.OKCancel);
            var btn = sender as Button;
            if (result == MessageBoxResult.OK)
            {
                btn.Content = "OK";
            }
            else if (result == MessageBoxResult.Cancel)
            {
                btn.Content = "CANCEL";
            }
        }

        private void StackPanel_MouseMove(object sender, MouseEventArgs e)
        {
            //var x = e.GetPosition(this).X;
            //var y = e.GetPosition(this).Y;
            //myBtn.Content=$"X : {x}  Y : {y}";
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton== MouseButtonState.Pressed)
            {
               // myStackPanel.Background = Brushes.Red;
            }
            else if(e.RightButton== MouseButtonState.Pressed)
            {
                //myStackPanel.Background = Brushes.Yellow;
            }
        }
    }
}
