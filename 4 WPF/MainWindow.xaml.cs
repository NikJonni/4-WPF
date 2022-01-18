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

namespace _4_WPF
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

        private void Button_Click(object sender, RoutedEventArgs e)//Обработка доллара
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumRub = Convert.ToDouble(sum.Text);
            double result = rateDollar * sumRub;
            res.Text = result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)//Обработка евро
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumRub = Convert.ToDouble(sum1.Text);
            double result = rateEuro * sumRub;
            res1.Text = result.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)//Обработка доллара лиры
        {
            double rateLira = Convert.ToDouble(rate2.Text);
            double sumRub = Convert.ToDouble(sum2.Text);
            double result = rateLira * sumRub;
            res2.Text = result.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)//Обработка кроны
        {
            double rateCrona = Convert.ToDouble(rate3.Text);
            double sumRub = Convert.ToDouble(sum3.Text);
            double result = rateCrona * sumRub;
            res3.Text = result.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)//Обработка дюйма
        {
            double _inch = Convert.ToDouble(inch.Text);// ввод дюйма в текстовое окно
            double result = _inch * 0.025;
            resInch.Text = result.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double _ft = Convert.ToDouble(ft.Text);// ввод фута в текстовое окно
            double result = _ft * 0.3;
            resFt.Text = result.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double _miles = Convert.ToDouble(miles.Text);// ввод дюйма в текстовое окно
            double resultKm = _miles * 1.61;
            resKm.Text = resultKm.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double _verst = Convert.ToDouble(verst.Text);// ввод дюйма в текстовое окно
            double resultVr_Km = _verst * 1.07;
            resVr_Km.Text = resultVr_Km.ToString();
        }
    }
}
