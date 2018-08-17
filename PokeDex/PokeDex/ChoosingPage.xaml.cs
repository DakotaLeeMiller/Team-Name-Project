using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokeDex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ImageSource Img { get; set; }

        private List<string> pokemonImageSources = new List<string>();
        private System.Text.StringBuilder sb = new System.Text.StringBuilder();

        public MainPage()
        {
            BitmapImage One = new BitmapImage(new Uri("ms-appx:///Assets/1.png"));

            this.InitializeComponent();

            for (int i = 0; i < 152; i++)
            {
                CreateListItems(i);

                ImageSpot.Source = One;

                //   BitmapImage bitmapImage = new BitmapImage();
                //   ImageSpot.Height = bitmapImage.DecodePixelHeight = 120;
                //   ImageSpot.Width = bitmapImage.DecodePixelWidth = 80; //natural px width of image source
                // don't need to set Height, system maintains aspect ratio, and calculates the other
                // dimension, so long as one dimension measurement is provided
                //   bitmapImage.UriSource = new Uri(ImageSpot.BaseUri, "C:/Users/Joshua Harrington/Desktop/GitHub/Team - Name - Project/Gen I Pics/Gen I Pics/004Charmander.png");


            }

<<<<<<< HEAD


=======
            InitializeImageSOurces();
>>>>>>> master
        }


        void Image_Loaded(object sender, RoutedEventArgs e)
        {
           // Image img = sender as Image;
            BitmapImage bitmapImage = new BitmapImage();
            ImageSpot.Width = bitmapImage.DecodePixelWidth = 80; //natural px width of image source
                                                           // don't need to set Height, system maintains aspect ratio, and calculates the other
                                                           // dimension, so long as one dimension measurement is provided
            bitmapImage.UriSource = new Uri(ImageSpot.BaseUri, "../Gen I Pics/Gen I Pics");
        }


        public void CreateListItems(int i)
        {
            ListBoxItem PokemonBar = new ListBoxItem();
            PokemonBar.Width = 400;
            PokemonBar.Background = new SolidColorBrush(Colors.Gray);
            PokemonBar.Content = $"Pokemon {i}";
            ThePokemon.Items.Add(PokemonBar);


            


        }

        private void SelectPokemon_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SelectedPokemonPage));
        }

        private void ThePokemon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int m = ThePokemon.SelectedIndex;

            Img = new BitmapImage(new Uri(pokemonImageSources[m]));

            DisplayPokemon.Source = Img;

            //DisplayPokemon.Source = new BitmapImage(new Uri(test[m]));
        }

        private void InitializeImageSOurces()
        {
            //Change to incorporate dll!!!
            for (int t = 0; t < 2; t++)
            {
                sb.Append("ms-appx:///");
                sb.Append("Assets/Gen_I/");

                if (t <= 9)
                {
                    sb.Append("00");
                }

                sb.Append(t);

                sb.Append(".png");

                pokemonImageSources.Add(sb.ToString());

                sb.Clear();
            }
        }
    }
}
