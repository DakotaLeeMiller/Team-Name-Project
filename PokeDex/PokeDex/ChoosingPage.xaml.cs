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
        public ScrollViewer scrollViewer;
        private double scrollOffset;

        private Pokedex pokedex = new Pokedex();

        public ChoosingPage()
        {
            this.InitializeComponent();

            PokemonList.Loaded += PokemonList_Loaded;
        }

        private void PokemonList_Loaded(object sender, RoutedEventArgs e)
        {
            scrollViewer = GetScrollViewer(PokemonList);

            scrollViewer.ViewChanged += Scrolled;
            scrollViewer.ViewChanging += Scrolling;
            if (scrollViewer != null)
            {
                var itemGrid = (PokemonList.ItemTemplate.LoadContent() as Grid);
                var itemHeight = itemGrid.Height + itemGrid.Margin.Top + itemGrid.Margin.Bottom;
                PokemonList.SelectedIndex = (int)((scrollOffset + itemHeight / 2.0) / itemHeight) + (int)((PokemonList.Height / itemHeight) / 2.0);
                scrollViewer.ChangeView(null, (int)((PokemonList.SelectedIndex - (int)((PokemonList.Height / itemHeight) / 2.0)) * itemHeight), null);
                scrollOffset = scrollViewer.VerticalOffset;
            }
        }

        private void SelectPokemon_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SelectedPokemonPage), PokemonList.SelectedItem as Pokemon);
        }

        private void PokemonList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DisplayPokemon.Fill as ImageBrush).ImageSource = new BitmapImage(new Uri((PokemonList.SelectedItem as Pokemon).ImageSource));
        }


        private void Scrolled(object sender, ScrollViewerViewChangedEventArgs e)
        {
            var itemGrid = (PokemonList.ItemTemplate.LoadContent() as Grid);
            var itemHeight = itemGrid.Height + itemGrid.Margin.Top + itemGrid.Margin.Bottom;

            if (!e.IsIntermediate)
            {
                scrollViewer.ChangeView(null, (int)((PokemonList.SelectedIndex - (int)((PokemonList.Height / itemHeight) / 2.0)) * itemHeight), null);
            }
        }
        private void Scrolling(object sender, ScrollViewerViewChangingEventArgs e)
        {
            scrollOffset = scrollViewer.VerticalOffset;
            var itemGrid = (PokemonList.ItemTemplate.LoadContent() as Grid);
            var itemHeight = itemGrid.Height + 10.0;
            

            PokemonList.SelectedIndex = (int)((scrollOffset + itemHeight / 2.0) / itemHeight) + (int)((PokemonList.Height / itemHeight) / 2.0);
        }

        public static ScrollViewer GetScrollViewer(DependencyObject o)
        {
            // Return the DependencyObject if it is a ScrollViewer
            if (o is ScrollViewer)
            {
                return o as ScrollViewer;
            }

            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(o); i++)
            {
                var child = VisualTreeHelper.GetChild(o, i);

                var result = GetScrollViewer(child);
                if (result == null)
                {
                    continue;
                }
                else
                {
                    return result;
                }
            }
            return null;
        }
    }
}
