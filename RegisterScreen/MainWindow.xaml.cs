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
            
        }

       
        private void text_Change(object sender, EventArgs e)
        {
           
                if (Username.Text == "USERNAME")
                    Username.Text = string.Empty;
            }



        //private void text_Change2(object sender, EventArgs e)
        //{
            

        //    //MessageBox.Show("Done"); 
        //}

        //private void user_Input()
        //{
        //    if (!String.IsNullOrWhiteSpace(Username.Text.Trim()) && !String.IsNullOrWhiteSpace(Password.Password.Trim()))
        //    {
        //        canProceedUserPass = true;
        //    }
        //    else
        //    {
        //        canProceedUserPass = false;
        //        MessageBox.Show("You haven't filled out all the required fields.");
        //    }
        //}
        private void button_Click(object sender, EventArgs e)
        {
           

            MessageBox.Show("You have loged in");
        }

        private void Password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Password == "PASSWORD")
                Password.Clear();
        }
    }
}
