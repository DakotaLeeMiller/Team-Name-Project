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
using Pokedata;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokeDex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChoosingPage : Page
    {
        private Pokedex pokedex = new Pokedex();

        public ChoosingPage()
        {
            this.InitializeComponent();
        }

        private void SelectPokemon_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SelectedPokemonPage), PokemonList.SelectedItem as Pokemon);
        }

        private void PokemonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayPokemon.Source = new BitmapImage(new Uri(pokedex.GetPokemon(PokemonList.SelectedIndex).ImageSource));
        }
    }
}
