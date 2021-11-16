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
                string him ="";
                //身長がｃｍで入力されたとき
                if (h > 3)
                {
                    h = h / 100;
                }
                //体重がｇで入力されたと
                if (w > 300)
                {
                    w = w / 1000;
                }
                //BMI導出
                double b = w / h / h;
                //桁落ち防止処理
                b = b * 10;
                //BMI四捨五入
                double bmi = Math.Round(b);
                //正常な数値へ戻す処理
                bmi /= 10;
                //肥満度計算
                if (bmi < 18.50)
                {
                    him = "低体重 (痩せ)";
                }else if (bmi < 25.00)
                {
                    him = "普通体重";
                }else if (bmi < 30.00)
                {
                    him = "肥満 (1度)";
                }else if (bmi < 35.00)
                {
                    him = "肥満 (2度)";
                }else if (bmi < 40.00)
                {
                    him = "肥満 (3度)";
                }else
                {
                    him = "肥満 (4度)";
                }
                //printf("身長%5.2f m、体重%6.2f kgの人のBMI = %6.2f\n", height, weight, bmi);
                result.Text = "身長" + h + "m 体重"  + w + "kg の人のBMIは" + bmi + "肥満度は" + him + "です。";
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
