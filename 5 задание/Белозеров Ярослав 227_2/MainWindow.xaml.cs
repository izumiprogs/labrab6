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
using static System.Math;

namespace Белозеров_Ярослав_227_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void Button_Click(object sender, EventArgs e)
        {

            double x = Convert.ToDouble(Rezult_a.Text);
            double y = Convert.ToDouble(Rezult_b.Text);
            double r = 12;
            if (x * x + y * y < r * r && y > x) { TextBlockAnswer.Text = "да"; }
            else if (x * x + y * y > r * r && y < x) { TextBlockAnswer.Text = "нет"; }
            else { TextBlockAnswer.Text = "на границе"; }
        }
    }
}
