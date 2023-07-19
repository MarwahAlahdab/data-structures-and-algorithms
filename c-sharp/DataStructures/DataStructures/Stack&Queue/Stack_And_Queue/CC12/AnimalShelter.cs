using System;
using System.Xml.Linq;
using Stack_And_Queue.CC12;

namespace Stack_And_Queue
{
  public class AnimalShelter
  {
    public Stack_And_Queue.Queue <Animal> dogs;
    public Stack_And_Queue.Queue<Animal> cats;

    public AnimalShelter()
    {
      dogs = new Stack_And_Queue.Queue<Animal>();
      cats = new Stack_And_Queue.Queue<Animal>();
    }

    public void Enqueue(Animal animal)
    {
      if (animal.Species != "dog" && animal.Species != "cat")
      {
        throw new InvalidOperationException("Shelter Has only cats and dogs!");
      }

      if (animal.Species.ToLower() == "dog")
      {
        dogs.Enqueue(animal);
      }
      else if (animal.Species.ToLower() == "cat")
      {
        cats.Enqueue(animal);
      }
      

    }

    public Animal Dequeue(string pref)
    {
      //if (pref.ToLower() != "dog" && pref.ToLower() != "cat")
      //{
      //  return null; 
      //}

      if (pref == "dog" && !(dogs.IsEmpty()))
      {
        return dogs.Dequeue();
      }

      if (pref == "cat" && !(cats.IsEmpty()))
      {
        return cats.Dequeue();
      }

      // strech goal: If the preferred animal is not available, return the oldest animal
      return !dogs.IsEmpty() ? dogs.Dequeue() : !cats.IsEmpty() ? cats.Dequeue() : null;
    }




  }






}

