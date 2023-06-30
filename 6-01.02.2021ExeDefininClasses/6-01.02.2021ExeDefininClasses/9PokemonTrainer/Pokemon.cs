using System;
using System.Collections.Generic;
using System.Text;

namespace _9PokemonTrainer
{
    class Pokemon
    {
        public Pokemon(string pokemonName, string element, double health)
        {
            PokemonName = pokemonName;
            Element = element;
            Health = health;
        }

        public string PokemonName { get; set; }

        public string Element { get; set; }

        public double Health { get; set; }
    }
}
