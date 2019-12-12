
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokemonList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {

        private Pokemon PokemonValue = new Pokemon();
        public Pokemon Pokemon
        {
            get => PokemonValue;
            set
            {
                PokemonValue = value;
                OnPropertyChanged(nameof(Pokemons));
            }
        }

        public DetailPage(object selectedPokemon)
        {
            Pokemon = (Pokemon)selectedPokemon;

            InitializeComponent();
            BindingContext = this;

        }
    }
}