using System;

namespace ZOO
{
   class Program
   {
      static void Main(string[] args)
      {
         Zoo zoo1 = new Zoo("MythicZoo1");
         Zoo zoo2 = new Zoo("MythicZoo2");        
         Animal animal1 = new Animal( AnimalType.FlyingHorse,Food.Birds);
         Animal animal2 = new Animal( AnimalType.Cerber,Food.Humans);
         Animal animal3 = new Animal( AnimalType.Chimera,Food.Peasents);
         Animal animal4 = new Animal( AnimalType.Cerber,Food.Grass);
         
         zoo1.AddAnimal(animal1);
         zoo1.AddAnimal(animal2);
         zoo1.AddAnimal(animal3);
         zoo1.AddAnimal(animal4);
         animal2.Eat();
         animal4.Eat();
         animal1.Eat();
         animal3.Eat();                 
         zoo1.TransferAnimal(zoo2, animal1);       
         zoo2.AnimalList();       
         zoo1.AnimalList();        
         zoo1.TransferAnimal(zoo2, animal2);        
         zoo2.AnimalList();
         zoo1.AnimalList();
      }
   }
}
