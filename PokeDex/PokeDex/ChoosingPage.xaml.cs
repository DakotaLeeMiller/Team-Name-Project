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
<<<<<<< HEAD
        List<string> Pokemon = new List<string>();
=======
        public ImageSource Img { get; set; }

        private List<string> pokemonImageSources = new List<string>();
        private System.Text.StringBuilder sb = new System.Text.StringBuilder();

>>>>>>> master
        public MainPage()
        {
            this.InitializeComponent();

            for (int i = 0; i < 152; i++)
            {
                CreateListItems(i);
            }

<<<<<<< HEAD
            ThePokemon.ItemsSource = Pokemon;
=======
            InitializeImageSOurces();
>>>>>>> master
        }

        public void CreateListItems(int i)
        {
            Pokemon.Add($"Pokemon {i}");
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
