using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAdibFlix
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Logo.Source = ImageSource.FromResource("AppAdibFlix.Img.tox.png");
        }

        private async void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message.ToString(), "Ok");

            }
        }
        private async void Btn_Open_Comedia(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message.ToString(), "Ok");

            }
        }
        private async void Btn_Open_Romance(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message.ToString(), "Ok");

            }
        }
        private async void Btn_Open_Terror(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Categorias.Aventura());
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops, ocorreu um erro", ex.Message.ToString(), "Ok");

            }
        }

        private void cu(object sender, EventArgs e)
        {

        }

        private void cu1(object sender, EventArgs e)
        {

        }

        private void cu2(object sender, EventArgs e)
        {

        }

        private void cu3(object sender, EventArgs e)
        {

        }
    }
}
