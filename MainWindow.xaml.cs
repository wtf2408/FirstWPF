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

namespace FirstWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] words;
        public MainWindow()
        {
            
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            words = inputText.Text.Split(' ');
            foreach (string word in words)
            {
                listBox.Items.Add(word);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            label.Content = ReversText(inputText.Text);
        }
        string ReversText(string text)
        {
            string[] tempText = text.Split(' ');
            text = string.Empty;
            foreach (string word in tempText)
            {
                text = $" {word}" + text; 
            }
            return text;
        }
    }
}
