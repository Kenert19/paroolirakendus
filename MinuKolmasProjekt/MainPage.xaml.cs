using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MinuKolmasProjekt
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        static int attempt = 3;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            string kasutajanimi = textBox3.Text;
            string password = passwordBox1.Password;

            if ((this.textBox3.Text == "Kasutaja") && (this.passwordBox1.Password == "Tere1234" && attempt == 0))
            {
                textBlock2.Text = "Sisselogimine õnnestus!";
            }
            else if (attempt <= 3)
            {
                textBlock2.Text = "Teil on veel " + Convert.ToString(attempt) + " katset järel!";
                attempt = attempt -1 ;
            }
            else if (attempt < 3)
            {
                textBlock2.Text = "Sisselogimiskatsed on otsas!" ;
            }
        }
    }
}