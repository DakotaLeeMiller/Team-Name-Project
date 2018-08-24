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
<<<<<<< HEAD
using Windows.UI.Xaml.Media.Imaging;
<<<<<<< HEAD
using Pokedata;
=======
>>>>>>> parent of 488a051... Merge branch 'master' into Alices_Work
=======
>>>>>>> parent of a055d3a... Merge branch 'master' into Alices_Work

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokeDex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        List<string> Pokemon = new List<string>();
>>>>>>> parent of a055d3a... Merge branch 'master' into Alices_Work
=======
>>>>>>> parent of 488a051... Merge branch 'master' into Alices_Work
        List<string> Pokemon = new List<string>();
        public MainPage()
        {
            this.InitializeComponent();
            for(int i = 0; i < 152; i++)
            {
                CreateListItems(i);
            }

            ThePokemon.ItemsSource = Pokemon;
        }

        public void CreateListItems(int i)
        {
            Pokemon.Add($"Pokemon {i}");
<<<<<<< HEAD
<<<<<<< HEAD
=======
        private Pokedex pokedex = new Pokedex();
=======
        }
>>>>>>> parent of a055d3a... Merge branch 'master' into Alices_Work

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
<<<<<<< HEAD
            DisplayPokemon.Source = new BitmapImage(new Uri(pokedex.GetPokemon(PokemonList.SelectedIndex).ImageSource));
=======
>>>>>>> parent of 488a051... Merge branch 'master' into Alices_Work
=======
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
>>>>>>> parent of a055d3a... Merge branch 'master' into Alices_Work
        }
    }
}
