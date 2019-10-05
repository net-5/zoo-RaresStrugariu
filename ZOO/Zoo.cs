using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{

   interface IZooActions
   {

      void TransferAnimal(Zoo ZooToTransfer, Animal _animal);


      void AddAnimal(Animal _animal);
   }
   class Zoo : IZooActions
   {
      private string zooName;
      private List<Animal> animals;

      public List<Animal> ListOfAnimals
      {
         get { return animals; }
         private set { animals = value; }
      }

      public string ZooName
      {
         get { return zooName; }
         private set { zooName = value; }
      }

      public Zoo(string _name )
      {
         ZooName = _name;
         ListOfAnimals = new List<Animal>();
      }
    
      public void AddAnimal(Animal _animal)
      {
         ListOfAnimals.Add(_animal);
         Console.WriteLine($"The animal  {_animal.AnimalType} was added to the {ZooName}");
      }


      public void TransferAnimal(Zoo ZooToTransfer, Animal _animal)
      {
         ZooToTransfer.ListOfAnimals.Add(_animal);
         ListOfAnimals.Remove(_animal);
         Console.WriteLine($"The animal {_animal.AnimalType} was transfered from {ZooName} to {ZooToTransfer.ZooName}");
      }

      public void AnimalList()
      {
         Console.WriteLine($"At the zoo {ZooName} there are {ListOfAnimals.Count} animals");
         foreach (Animal animal in ListOfAnimals)
         {
            Console.WriteLine(animal.AnimalDetails());
         }
         Console.WriteLine();
      }
   }
}
