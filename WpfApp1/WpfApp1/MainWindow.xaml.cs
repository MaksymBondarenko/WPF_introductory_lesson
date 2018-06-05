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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Buf=null;
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Click_Cut(object sender, RoutedEventArgs e)
        {
            Buf = richTextBox1.Selection.Text;
            richTextBox1.Selection.Text = "";
            Console.WriteLine(Buf);
        }

        private void Click_Paste(object sender, RoutedEventArgs e)
        {
            richTextBox1.Selection.Text = Buf;
           
        }

        private void Click_Copy(object sender, RoutedEventArgs e)
        {
            Buf = richTextBox1.Selection.Text;
        }

        private void Click_User1(object sender, RoutedEventArgs e)
        {
            stackPanel.Background = new LinearGradientBrush(Colors.LightBlue, Colors.SlateBlue, 90);
            User1.Background = new LinearGradientBrush(Colors.Coral, Colors.Cyan, 10);
        }

        private void Click_User3(object sender, RoutedEventArgs e)
        {
            stackPanel.Background = new LinearGradientBrush(Colors.Azure, Colors.Blue, 90);
            User3.Background = new LinearGradientBrush(Colors.Coral, Colors.DarkBlue, 50);
        }

        private void Click_User2(object sender, RoutedEventArgs e)
        {
            stackPanel.Background = new LinearGradientBrush(Colors.Cyan, Colors.Blue, 90);
            User2.Background = new LinearGradientBrush(Colors.Coral, Colors.Gold, 200);
        }

        private void Click_User4(object sender, RoutedEventArgs e)
        {
            stackPanel.Background = new LinearGradientBrush(Colors.LightYellow, Colors.Maroon, 100);
            User4.Background = new LinearGradientBrush(Colors.Coral, Colors.LimeGreen, 100);
        }

        private void Click_User5(object sender, RoutedEventArgs e)
        {
            stackPanel.Background = new LinearGradientBrush(Colors.OrangeRed, Colors.PeachPuff, 50);
            User5.Background = new LinearGradientBrush(Colors.Pink, Colors.LimeGreen, 80);
        }

        private void Click_User6(object sender, RoutedEventArgs e)
        {
            stackPanel.Background = new LinearGradientBrush(Colors.Yellow, Colors.Blue, 90);
            User6.Background = new LinearGradientBrush(Colors.Yellow, Colors.Blue, 120);
        }

        private void MouseMove_button_10(object sender, MouseEventArgs e)
        {
            button_10.Background = new LinearGradientBrush(Colors.Yellow, Colors.Blue, 120);
            Random RND = new Random();
            button_10.Margin = new Thickness(RND.Next(0, 400), RND.Next(0, 400), 0, 0);
        }
    }
}
