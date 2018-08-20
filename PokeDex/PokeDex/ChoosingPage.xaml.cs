using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
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

        }
    }
}
