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
using WpfStudy.Models;
using WpfStudy.ViewModels;

namespace WpfStudy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel;
        public MainWindow()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
            mainViewModel.ProgressValue = 30;
            DataContext = mainViewModel;
        }

        private void btnTest1_Click(object sender, RoutedEventArgs e)
        {
            //List<User> myList1 = new List<User>();
            //labelTest1.Content = "내용변경완료";
            ////MessageBox.Show(textBox1.Text);
            //User userA = new User();
            //userA.UserImg = @"F:\projectc\WpfStudy\WpfStudy\Resources\photo1.jpg";
            //userA.Name = "Noah";
            //userA.UserAge = 15;

            //User userB = new User();
            //userB.UserImg = @"F:\projectc\WpfStudy\WpfStudy\Resources\photo1.jpg";
            //userB.Name = "Liam";
            //userB.UserAge = 35;

            //myList1.Add(userA);
            //myList1.Add(userB);

            //listView1.ItemsSource = myList1;
            mainViewModel.ProgressValue = 100;
        }

        private void ComboBox_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
