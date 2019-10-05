using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO

   

{

   interface IAnimalActions
   {
      void Eat();
   }
   public enum Food { Peasents, Birds, Lava, snakes, Humans, Grass };
   public enum AnimalType {FlyingHorse, Hydra, Dragon, Chimera, Cerber, Centaur };
   class Animal : IAnimalActions
   {
      private AnimalType animalType;
      
     
      private Food favouriteFood;

     
      public Food FavouriteFood
      {
         get { return favouriteFood; }
         set { favouriteFood = value; }
      }

      

      

      public AnimalType AnimalType
      {
         get { return animalType; }
         private set { animalType = value; }
      }

      public Animal( AnimalType _animalType, Food _favouriteFood)
      {
         
         this.AnimalType = _animalType;
         
         this.FavouriteFood = _favouriteFood;
      }

      public void Eat()
      {
         Console.WriteLine($"This {AnimalType} eats {FavouriteFood}.");
      }

      
      public string AnimalDetails()
      {
         return $" This  {AnimalType}'s favourite food is {FavouriteFood}";
      }

   }
}
