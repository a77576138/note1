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

namespace note
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string homework1 = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void new_MouseDown(object sender, RoutedEventArgs e)
        {
            block.Clear();
        }

        private void plus_MouseDown(object sender, MouseButtonEventArgs e)
        {
            block.FontSize += 5;

            if (block.FontSize > 5)
                diss.IsEnabled = true;
        }

        private void open_MouseDown(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog aaa = new Microsoft.Win32.OpenFileDialog();

            Nullable<bool> result = aaa.ShowDialog();

            if (result == true)
            {
                homework1 = aaa.FileName;

                block.Text = System.IO.File.ReadAllText(homework1);
            }
        }

        private void save_MouseDown(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog aaa = new Microsoft.Win32.SaveFileDialog();

            Nullable<bool> result = aaa.ShowDialog();

            if (result == true)
            {
                homework1 = aaa.FileName;

                System.IO.File.WriteAllText(homework1, block.Text);
            }
        }

        private void diss_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (block.FontSize > 5)
                block.FontSize -= 5;
            else
                diss.IsEnabled = false;
        }

        private void gray_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (gray.Fill == Brushes.Gray)
            {
                gray.Fill = Brushes.White;
                block.Foreground = Brushes.White;
            }
            else
            {
                gray.Fill = Brushes.Gray;
                block.Foreground = Brushes.Black;
            }
        }

        private void white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (white.Fill == Brushes.White)
            {
                white.Fill = Brushes.Gray;
                block.Background = Brushes.Gray;
            }
            else
            {
                white.Fill = Brushes.White;
                block.Background = Brushes.White;
            }
        }
    }
}
