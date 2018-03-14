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
    using System;
    using System.Text.RegularExpressions;
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
          
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            string s = boks1.Text;
            string z = boks2.Text;
            a = int.Parse(s);
            b = int.Parse(z);
            c = a + b;
            
            MessageBox.Show(c.ToString());
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        
            
                {
                    string s = boks1.Text;
                
                    String pattern = @"(\d+)([-+*/])(\d+)";
                       foreach (Match m in Regex.Matches(s, pattern))
                    {
                        int value1 = Int32.Parse(m.Groups[1].Value);
                        int value2 = Int32.Parse(m.Groups[3].Value);
                        switch (m.Groups[2].Value)
                        {
                            case "+":
                                int d = value1 + value2;
                                MessageBox.Show(d.ToString());
                                break;
                            case "-":
                                int c = value1 - value2;
                                MessageBox.Show(c.ToString());
                                break;
                            case "*":
                                int b = value1 * value2;
                                MessageBox.Show(b.ToString());
                                break;
                            case "/":
                                int a = value1 / value2;
                                MessageBox.Show(a.ToString());
                                break;
                        }
                    }
                 
            
    }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
       
        }

        private void boks1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
