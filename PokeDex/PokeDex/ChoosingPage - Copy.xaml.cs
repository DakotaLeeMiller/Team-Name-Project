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
<<<<<<< HEAD:PokeDex/PokeDex/ChoosingPage - Copy.xaml.cs
=======
using Pokedata;
using System.Threading.Tasks;
using Windows.Storage;
>>>>>>> 24a0a5be09b997e737cd21d5a9755aa9b6fb841c:PokeDex/PokeDex/SelectedPokemonPage.xaml.cs

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PokeDex
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
<<<<<<< HEAD:PokeDex/PokeDex/ChoosingPage - Copy.xaml.cs
<<<<<<< HEAD:PokeDex/PokeDex/ChoosingPage - Copy.xaml.cs
<<<<<<< HEAD:PokeDex/PokeDex/SelectedPokemonPage.xaml.cs
        private Pokemon SelectedPokemon { get; set; }
=======
        private Pokemon selectedPokemon;
        public Pokemon SelectedPokemon
        {
            get => selectedPokemon;
            set
            {
                selectedPokemon = value;
                if (selectedPokemon.GenderRatio == null)
                {
                    maleRatio.Text = "NaN";
                    femaleRatio.Text = "NaN";
                }
                if (selectedPokemon.EvolveFrom == null) evolveFromPokemonButton.IsEnabled = false;
                if (selectedPokemon.EvolveTo == null) evolveToPokemonButton.IsEnabled = false;
            }
        }
>>>>>>> 24a0a5be09b997e737cd21d5a9755aa9b6fb841c:PokeDex/PokeDex/SelectedPokemonPage.xaml.cs

=======
>>>>>>> parent of a055d3a... Merge branch 'master' into Alices_Work:PokeDex/PokeDex/SelectedPokemonPage.xaml.cs
        public SelectedPokemonPage()
        {
            this.InitializeComponent();
            this.Height = 720.0;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
=======
        public MainPage()
        {
            this.InitializeComponent();
        }
<<<<<<< HEAD:PokeDex/PokeDex/ChoosingPage - Copy.xaml.cs
>>>>>>> parent of 488a051... Merge branch 'master' into Alices_Work:PokeDex/PokeDex/ChoosingPage - Copy.xaml.cs
=======

        private async void playCrySound_Click(object sender, RoutedEventArgs e)
        {
            await PlayPokemonCry();
            playCrySound.IsEnabled = false;
            await Task.Delay(1000);
            playCrySound.IsEnabled = true;
        }

        public async Task PlayPokemonCry()
        {
            IStorageFile mediaFile = await StorageFile.GetFileFromApplicationUriAsync(new Uri(SelectedPokemon.CrySoundSource));
            var stream = await mediaFile.OpenAsync(FileAccessMode.Read).AsTask();
            var mediaControl = new MediaElement();
            mediaControl.SetSource(stream, mediaFile.ContentType);
            mediaControl.Play();
        }
>>>>>>> 24a0a5be09b997e737cd21d5a9755aa9b6fb841c:PokeDex/PokeDex/SelectedPokemonPage.xaml.cs
    }
}
