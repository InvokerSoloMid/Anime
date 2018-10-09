using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Anime
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Image image = new Image { Source = "wtf.jpg" };
            this.Content = image;
            //InitializeComponent();
        }
    }
}
