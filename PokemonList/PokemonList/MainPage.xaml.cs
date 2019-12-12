using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace PokemonList
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private List<Pokemon> PokemonsValue = new List<Pokemon>();
        public List<Pokemon> Pokemons
        {
            get => PokemonsValue;
            set
            {
                PokemonsValue = value;
                OnPropertyChanged(nameof(Pokemons));
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            Pokemons = PokemonClient.GetAllPokemons().GetAwaiter().GetResult().Results;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailPage(e.SelectedItem));
        }
    }
}
