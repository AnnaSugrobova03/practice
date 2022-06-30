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
using System.IO.IsolatedStorage;
using Xceed.Wpf.Toolkit;
using System.IO;

namespace Задание4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForAssembly();
            string color;
            try
            {
                IsolatedStorageFileStream isfs = new IsolatedStorageFileStream("cf.cfg", FileMode.Open, FileAccess.Read, FileShare.Read);
                StreamReader sr = new StreamReader(isfs);
                color = sr.ReadLine();
                lb.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(color));
                lb.Content = color;
                sr.Close();
            }
            catch (Exception ex)
            {
                lb.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00000000"));
                lb.Content = "#00000000";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Сохранено!");
        }
        private void CP_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color?> e)
        {
            IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream("cf.cfg", FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(isolatedStorageFileStream);
            lb.Content = CP.SelectedColor.Value;
            lb.Background = new SolidColorBrush(CP.SelectedColor.Value);
            sw.WriteLine(lb.Background.ToString());
            sw.Close();
        }
    }
}
