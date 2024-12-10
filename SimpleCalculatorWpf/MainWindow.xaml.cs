using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleCalculatorWpf
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double ilk;
        double ikinci;
        char islem;
        bool varmi = false;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            textboxcevap.Text += btn.Content.ToString();
            varmi = false;
        }

        private void toplama_click(object sender, RoutedEventArgs e)
        {
            if (varmi == false)
            {
                ilk = Double.Parse(textboxcevap.Text);
                islem = '+';
                textboxcevap.Clear();
                varmi = true;
            }
            
        }

        private void cıkarma_click(object sender, RoutedEventArgs e)
        {
            if (varmi == false)
            {
                ilk = Double.Parse(textboxcevap.Text);
                islem = '-';
                textboxcevap.Clear();
                varmi = true;
            }
        }

        private void carpma_click(object sender, RoutedEventArgs e)
        {
            if (varmi == false)
            {
                ilk = Double.Parse(textboxcevap.Text);
            islem = '*';
            textboxcevap.Clear();
            varmi = true;
        }
    }

        private void bolme_click(object sender, RoutedEventArgs e)
        {
        if (varmi == false)
        {
            ilk = Double.Parse(textboxcevap.Text);
            islem = '/';
            textboxcevap.Clear();
            varmi = true;
        }
}

        private void cevap_click(object sender, RoutedEventArgs e)
        {
           
            ikinci = Double.Parse(textboxcevap.Text);

         
            double cevap = 0;

            
            if (islem == '+')
                cevap = ilk + ikinci;
            else if (islem == '-')
                cevap = ilk - ikinci;
            else if (islem == '*')
                cevap = ilk * ikinci;
            else if (islem == '/')
            {
                if (ikinci != 0)
                    cevap = ilk / ikinci;
                else
                {
                    textboxcevap.Text = "0'a Bölünemez!";
                    return;
                }
            }

           
            textboxcevap.Clear();
            textboxcevap.Text = cevap.ToString(); 
        }


        private void sil_click(object sender, RoutedEventArgs e)
        {
            textboxcevap.Clear();
        }
    }
}