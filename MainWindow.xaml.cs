using first_work;
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

namespace Equestion
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
        private void WriteLine(string text)
        {
            Result.Text += text + "\n";
            
        }
        private void ShowInfo_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        private void MakeResult_Click(object sender, RoutedEventArgs e)
        {
           


            Result.Text = "";
            int a, b, c;
            if(!int.TryParse(CoeffA.Text, out a))
            {
                CoeffA.Foreground = new SolidColorBrush(Color.FromRgb(239, 50, 76));
                return;
            }
            
            if (!int.TryParse(CoeffB.Text, out b))
            {
                CoeffB.Foreground = new SolidColorBrush(Color.FromRgb(239, 50, 76));
                return;
            }
            if (!int.TryParse(CoeffC.Text, out c))
            {
                CoeffC.Foreground = new SolidColorBrush(Color.FromRgb(239, 50, 76));
                return;
            }
            double x;

            if (a != 0)
            {
                int D = (int)Math.Pow(b, 2) - 4 * a * c;

                if (D < 0)
                {
                    WriteLine("Не має коренів");
                    WriteLine("D<0");
                    return;
                }
                else if (D > 0)
                {
                    WriteLine("D>0");

                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    WriteLine($"x1: {x1:0.0}");


                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    WriteLine($"x2: {x2:0.0} ");
                   
                    return;
                }
                else
                {
                    WriteLine("Має 1 корінь:");

                    double x1 = -b / (2 * a);
                    WriteLine($"x1: {x1:0.0}");
                    return;
                }


            }
            else if (b != 0 && c != 0)
            {
                x = (double)-c / b;
                WriteLine($"x: {x:0.0} ");
            }
            else if (c == 0)
            {
                WriteLine("x належить множині всіх дійсних чисел");

            }
            else
            {
                WriteLine("немає розв'язків");

            }



        }
    }
}