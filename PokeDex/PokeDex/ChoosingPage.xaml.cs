using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using Pokemon.Database;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokeDex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
           

            this.InitializeComponent();

            for(int i = 0; i < 152; i++)
            {
                CreateListItems(i);



 
            }


        }



        public void CreateListItems(int i)
        {


            ListBoxItem PokemonBar = new ListBoxItem();
            PokemonBar.Width = 400;
            PokemonBar.Background = new SolidColorBrush(Colors.Gray);
            PokemonBar.Content = $"Pokemon {i}";
            ThePokemon.Items.Add(PokemonBar);

            ImageBrush source = new ImageBrush();
            source.ImageSource = new BitmapImage(new Uri("appx://Assets/Gen I Pics/001Bulbasaur.png"));
            pokemonImage.Fill = source;
            //string source = Pokemon.Database.Pokemon.Blastoise.GetDexPictureSource();
            //pokemonImage.Source = new BitmapImage(new Uri("appx://Assets/Gen I Pics/001Bulbasaur.png"));
        }
    }
}
