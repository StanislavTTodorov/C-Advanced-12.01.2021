using System;
using System.Collections.Generic;
using System.Linq;

namespace _9PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string input = Console.ReadLine();
            while (input != "Tournament")
            {
                string[] trainerInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string element = trainerInfo[2];
                double health = double.Parse(trainerInfo[3]);
                Trainer trainer = trainers.FirstOrDefault(n => n.Name == name);
                if (trainer != null)
                {
                    trainer.Pokemon.Add(new Pokemon(pokemonName, element, health));
                }
                else
                {
                    Trainer newTrainer = new Trainer(name);
                    newTrainer.Pokemon.Add(new Pokemon(pokemonName, element, health));
                    trainers.Add(newTrainer);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                if (input == "Fire" || input == "Water" || input == "Electricity")
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Pokemon.Any(n => n.Element == input))
                        {
                            trainer.Badges++;
                        }
                        else
                        {
                            foreach (var item in trainer.Pokemon)
                            {
                                item.Health -= 10;
                            }
                        }
                    }
                }
                foreach (var item in trainers)
                {
                    item.Pokemon.RemoveAll(n => n.Health <= 0);
                }
                input = Console.ReadLine();
            }
            foreach (var item in trainers.OrderByDescending(n => n.Badges))
            {
                Console.WriteLine($"{item.Name} {item.Badges} {item.Pokemon.Count}");
            }
        }
    }
}
