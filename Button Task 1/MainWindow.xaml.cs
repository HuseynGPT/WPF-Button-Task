
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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Button_Task_1
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

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {

            int r = Random.Shared.Next(0, 256);
            int g = Random.Shared.Next(0, 256);
            int b = Random.Shared.Next(0, 256);
            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb((byte)r, (byte)g, (byte)b)
            };


            MessageBox.Show("this is Button 1" + this.Background.ToString(), "Info");

        }

        private void Btn1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Btn1.Visibility = Visibility.Hidden;
            this.Title = Btn1.Content + "deleted";

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {


            int r = Random.Shared.Next(0, 256);
            int g = Random.Shared.Next(0, 256);
            int b = Random.Shared.Next(0, 256);
            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb((byte)r, (byte)g, (byte)b)
            };


            MessageBox.Show("this is Button 2" + this.Background.ToString(), "Info");
        }

        private void Btn2_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Btn2.Visibility = Visibility.Hidden;
            this.Title = Btn2.Content + "deleted";
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            int r = Random.Shared.Next(0, 256);
            int g = Random.Shared.Next(0, 256);
            int b = Random.Shared.Next(0, 256);
            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb((byte)r, (byte)g, (byte)b)
            };


            MessageBox.Show("this is Button 3" + this.Background.ToString(), "Info");
        }

        private void Btn3_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Btn3.Visibility = Visibility.Hidden;
            this.Title = Btn3.Content + "deleted";
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            int r = Random.Shared.Next(0, 256);
            int g = Random.Shared.Next(0, 256);
            int b = Random.Shared.Next(0, 256);
            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb((byte)r, (byte)g, (byte)b)
            };


            MessageBox.Show("this is Button 4" + this.Background.ToString(), "Info");
        }

        private void Btn4_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Btn4.Visibility = Visibility.Hidden;
            this.Title = Btn4.Content + "deleted";
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            int r = Random.Shared.Next(0, 256);
            int g = Random.Shared.Next(0, 256);
            int b = Random.Shared.Next(0, 256);
            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb((byte)r, (byte)g, (byte)b)
            };


            MessageBox.Show("this is Button 5" + this.Background.ToString(), "Info");
        }

        private void Btn5_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Btn5.Visibility = Visibility.Hidden;
            this.Title = Btn5.Content + "deleted";
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            int r = Random.Shared.Next(0, 256);
            int g = Random.Shared.Next(0, 256);
            int b = Random.Shared.Next(0, 256);
            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb((byte)r, (byte)g, (byte)b)
            };


            MessageBox.Show("this is Button 6" + this.Background.ToString(), "Info");
        }

        private void Btn6_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Btn6.Visibility = Visibility.Hidden;
            this.Title = Btn6.Content + " deleted";
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Her hansi bir buttonu silmek isteyirsinizse uzerine gelib mousenin sag duymesi ile asagi cekin\nRestore All Changes basdiqda etdiyimiz deyisiklikler geri alinir");
        }

        private void Restore_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush()
            {
                Color = Color.FromRgb(255, 255, 255)
            };
            this.Title = "Button Task";
            Btn1.Visibility = Visibility.Visible;
            Btn2.Visibility = Visibility.Visible;
            Btn3.Visibility = Visibility.Visible;
            Btn4.Visibility = Visibility.Visible;
            Btn5.Visibility = Visibility.Visible;
            Btn6.Visibility = Visibility.Visible;
        }
    }
}
