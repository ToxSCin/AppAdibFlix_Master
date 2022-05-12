using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AppAdibFlix.Categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Aventura : ContentPage
    {
        public Aventura()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);


            Logo.Source = ImageSource.FromResource("AppAdibFlix.Img.tox.png");


            btnAmizades.Source = ImageSource.FromResource("AppAdibFlix.Posters.Amizades.jpg");
        }

        private async void btnAmizades_Click(object sender, EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Filmes.Amizades());
            }
            catch (Exception ex)
            {
                await DisplayAlert("erro", ex.Message.ToString(), "Ok");
            }
        }

    }
}