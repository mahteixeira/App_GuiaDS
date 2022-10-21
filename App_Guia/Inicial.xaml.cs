using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Guia
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicial : ContentPage
    {
        public class ImageInformation
        {
            public ImageSource _Image { get; set; }
        }
        private ObservableCollection<ImageInformation> imageCollection;

        public ObservableCollection<ImageInformation> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value;
                OnPropertyChanged();    
            }
        }
        public Inicial()
        {
            InitializeComponent();
            BindingContext = this;
            ImageCollection = new ObservableCollection<ImageInformation>
            {
                new ImageInformation{ _Image ="Imagens/foto1.png" },
                new ImageInformation{ _Image ="Imagens/foto2.png" },
                new ImageInformation{ _Image ="Imagens/foto3.png" },
		    new ImageInformation{ _Image ="Imagens/foto4.png" },
		    new ImageInformation{ _Image ="Imagens/foto5.png" },
		    new ImageInformation{ _Image ="Imagens/foto6.png" },
		    new ImageInformation{ _Image ="Imagens/foto7.png" }
            };
        }
    }
}