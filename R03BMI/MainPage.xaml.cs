using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A36 三浦　友督";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double h = double.Parse(heighit.Text);
                double w = double.Parse(weighit.Text);
                string sin="m";
                string tai="kg";
                //身長がｃｍで入力されたとき
                if (h > 3)
                {
                    h = h / 100;
                    sin="cm";
                }
                //体重がｇで入力されたと
                if (w > 300)
                {
                    w = w / 1000;
                    tai="g";
                }
                //BMI導出
                double b = w / h / h;
                //桁落ち防止処理
                b = b * 10;
                //BMI四捨五入
                double bmi = Math.Round(b);
                //正常な数値へ戻す処理
                bmi /= 10;
                //printf("身長%5.2f m、体重%6.2f kgの人のBMI = %6.2f\n", height, weight, bmi);
                result.Text = "身長" + sin + h + "体重" + tai + w + "の人のBMIは" + bmi + "です。";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
