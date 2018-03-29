using System;
using System.Collections.Generic;

namespace CrackingTheCode6th.Chapter3 {
    public class Q3_6 : Quiz {

        public override void Test () {
            Random rnd = new Random ();
            int counter = 1;

            Shelter shelter = new Shelter ();
            for (int i = 0; i < 10; i++) {
                if (rnd.Next (0, 2) == 0) {
                    shelter.Enqueue (new Dog (counter++));
                } else {
                    shelter.Enqueue (new Cat (counter++));
                }

            }
            System.Console.WriteLine ();
            shelter.DequeAny ();
            shelter.DequeAny ();
            shelter.DequeDog ();
            shelter.DequeCat ();
        }
    }

    internal class Shelter {
        Queue<Animal> cat = new Queue<Animal> ();
        Queue<Animal> dog = new Queue<Animal> ();

        internal void DequeAny () {

            int? dogID = null, catID = null;
            if (dog.Count != 0) {
                dogID = dog.Peek ().ID;
            }
            if (cat.Count != 0) {
                catID = cat.Peek ().ID;
            }
            if (dogID != null && catID != null) {
                if (dogID < catID) {
                    DequeDog ();
                } else {
                    DequeCat ();
                }
            } else if (dogID == null && catID != null) {
                DequeCat ();
            } else if (dogID != null && catID == null) {
                DequeDog ();
            }

        }

        internal void DequeCat () {
            if (cat.Count != 0) {
                Animal animal = cat.Dequeue ();
                System.Console.WriteLine (animal.Name);
            }
        }

        internal void DequeDog () {
            if (dog.Count != 0) {
                Animal animal = dog.Dequeue ();
                System.Console.WriteLine (animal.Name);
            }
        }

        internal void Enqueue (Animal animal) {
            System.Console.Write (animal.Name + " ");
            switch (animal.animalType) {
                case "Dog":
                    dog.Enqueue (animal);
                    break;
                case "Cat":
                    cat.Enqueue (animal);
                    break;
            }
        }
    }

    internal class Animal {
        public string animalType { get; set; }
        public int ID { get; set; }

        public string Name { get { return animalType + ID; } }
        public Animal (string type, int sequence) {
            this.animalType = type;
            this.ID = sequence;
        }
    }
    internal class Dog : Animal {
        public Dog (int sequence) : base ("Dog", sequence) { }
    }
    internal class Cat : Animal {
        public Cat (int sequence) : base ("Cat", sequence) { }
    }
}