using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmonicMobil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            img1.Source =ImageSource.FromResource("AmonicMobil.img.png");
            


        }
        
        private async void  but1_Clicked(object sender, EventArgs e)
        {
            Page os = new Page1();
            
            await Navigation.PushAsync(os);
        }
    }
}
