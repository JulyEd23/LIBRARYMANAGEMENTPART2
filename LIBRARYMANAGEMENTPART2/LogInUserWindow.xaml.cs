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

namespace LIBRARYMANAGEMENTPART2
{
    /// <summary>
    /// Interaction logic for LogInUserWindow.xaml
    /// </summary>
    public partial class LogInUserWindow : Window
    {
        public LogInUserWindow()
        {
            InitializeComponent();
        }

        private void buttonexitloginwndow_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonlogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtbxusername.Text == "" && psswrdbx.Password == "")
            {
                MessageBox.Show("kindly fill up the username and password");
            }
            else
            {
                if (txtbxusername.Text == "igit" && psswrdbx.Password == "wew")
                {
                    txtbxusername.Text = "";
                    psswrdbx.Password = "";
                    var mainwindow = new MainWindow();
                    mainwindow.Show();
                }
                else
                {
                    MessageBox.Show("wrong username or password");
                }
            }
        }
    }
}
