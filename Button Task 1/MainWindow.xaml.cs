
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
            GridPanel.Children.Remove(Btn1);
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
            GridPanel.Children.Remove(Btn2);
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
            GridPanel.Children.Remove(Btn3);
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
            GridPanel.Children.Remove(Btn4);
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
            GridPanel.Children.Remove(Btn5);
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
            GridPanel.Children.Remove(Btn6);

            this.Title = Btn6.Content + " deleted";
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Her hansi bir buttonu silmek isteyirsinizse uzerine gelib mousenin sag duymesi ile asagi cekin\nRestore All Changes basdiqda etdiyimiz deyisiklikler geri alinir");
        }

      
    }
}
