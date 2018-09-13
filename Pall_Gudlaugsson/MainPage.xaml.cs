using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pall_Gudlaugsson
{

    public partial class MainPage : ContentPage
    {
        int isOn = 1;
        double number, number1, number2;

        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            DisplayAlert("Alert", "None of the operators work!", "OK");

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            this.Total.Text = "0";
        }

        void PressedNum(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (this.Total.Text == "0" || isOn < 0)
            {
                this.Total.Text = "";
                if (isOn < 0)
                    isOn *= -1;
            }
            this.Total.Text += pressed;


            if (double.TryParse(this.Total.Text, out number))
            {
                this.Total.Text = number.ToString("N0");
                if (isOn == 1)
                {
                    number1 = number;
                }
                else
                {
                    number2 = number;
                }
            }
        }
    }
}



