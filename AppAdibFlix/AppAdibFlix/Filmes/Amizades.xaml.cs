using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAdibFlix.Filmes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Amizades : ContentPage
    {
        public Amizades()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            logo.Source = ImageSource.FromResource("AppAdibFlix.Img.tox.png");
            poster.Source = ImageSource.FromResource("AppAdibFlix.Posters.Amizades.jpg");

            //var htmlSource = new HtmlWebViewSource();
            //htmlSource.Html = @"<iframe width='400'
                                        //height='300'
                                        //scr='https://www.youtube.com/watch?v=0gbJbdoBv1E'
                                        //frameborder='0'
                                       // allow='accelerometer; autoplay; encrypted-media; gyroscope;
                                                //picture-in-picture'
                                       // allowfullscreen
                               // </iframe>"

            //visualizador.Source = htmlSource;
        }
    }
}