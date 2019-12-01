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

namespace RegisterScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int username;
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have loged in");
        }

        private void text_Change(object sender, EventArgs e)
        {
                TextBox txtBox = sender as TextBox;
                if (txtBox.Text == "USERNAME")
                    txtBox.Text = string.Empty;
            }

        ////private void text_Change2(object sender, EventArgs e)
        //{
        //    PasswordBox passwordBox = sender as PasswordBox;
        //    if (passwordBox.Equals()
        //        passwordBox.Text = string.Empty;
        //}
    }
}
