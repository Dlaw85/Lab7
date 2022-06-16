using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
           Animal myAnimal = new Animal("Bird", 5, "male");
           myAnimal.animalObj();
          
           Dog myDog = new Dog("Bingo", 2, "female", "Woow-Woow");
           Console.WriteLine(myDog);

           Frog myFrog = new Frog("Binta", 5, "female", "Krow-Krow");
           Console.WriteLine(myFrog);

           Cat myCat = new Cat("Hoodenten", 3, "male", "Meew-Meew");
           Console.WriteLine(myCat);

           Kitten myKitten = new Kitten("SnoWhite", 1, "male", "mew-mew");
           Console.WriteLine(myKitten);

           Tomcat myTomcat = new Tomcat("Tommy", 10, "male", "MEEW-MEEW!");
           Console.WriteLine(myTomcat);

           string[] animArray = new string[] {"Bird, 5, male", 
                                                 "Bingo, 2, female, Woow-Woow", 
                                                 "Binta, 5, female, Krow-Krow",
                                                 "Hoodenten, 3, male, Meew-Meew", 
                                                 "SnoWhite, 1, male, mew-mew", 
                                                 "Tommy, 10, male, MEEW-MEEW!"};
            System.Console.WriteLine(animArray[5]);
            

            foreach(var anim in animArray) {
                Console.WriteLine(anim);
            }

            

            Console.ReadLine();
        }
    }

    class Animal {
        public string Name{ get; set; }
        public int Age{ get; set; }
        public string Gender{ get; set; }

        public Animal() { }

        public Animal(string name, int age, string gender) {
              this.Name = name;
              this.Age = age;
              this.Gender = gender;
        }

        public virtual void animalObj() {
            Console.WriteLine(" animal name: " + this.Name + " age: " + this.Age + " and gender " + this.Gender);
              
        }
    }

    class Dog : Animal {

        public string DogSound{ get; set; }

        public Dog() { }
        
        public Dog(string name, int age, string gender, string dogsound) : base(name, age, gender) {

                      this.DogSound = dogsound;
                   }
        public override string ToString() {
            return string.Format("(Dog, name: {0}, age: {1}, gender: {2}, sound: {3})", this.Name, this.Age, this.Gender, this.DogSound);
    
        }
    }

    class Frog : Animal {

        public string FrogSound { get; set; }

        public Frog() { }

        public Frog(string name, int age, string gender, string frogsound) : base(name, age, gender) {
            this.FrogSound = frogsound;
        }

        public override string ToString() {
            return string.Format("(Frog name: {0}, age: {1}, gender: {2}, sound: {3})", this.Name, this.Age, this.Gender, this.FrogSound);
        }
     }

    class Cat : Animal {
        public string CatSound{ get; set; }

        public Cat() { }

        public Cat(string name, int age, string gender, string catsound) : base(name, age, gender) {
            this.CatSound = catsound;
        }

        public override string ToString() {
            return string.Format("(Cat name: {0}, age: {1}, gender: {2}, sound: {3})", this.Name, this.Age, this.Gender, this.CatSound);
        }
     }

    class Kitten : Animal { 
        
        public string KittenSound{ get; set; }

        public Kitten() { }

        public Kitten(string name, int age, string gender, string kittensound) : base(name, age, gender) {
            this.KittenSound = kittensound;
        }

        public override string ToString() {
            return string.Format("(Kitten name: {0}, age: {1}, gender: {2}, kittensound: {3})", this.Name, this.Age, this.Gender, this.KittenSound);
        }
    }

    class Tomcat : Animal {

        public string TomcatSound{ get; set; }

        public Tomcat() { }

        public Tomcat(string name, int age, string gender, string tomcatsound) : base(name, age, gender) {
            this.TomcatSound = tomcatsound;
        }

        public override string ToString() {
            return string.Format("(Tomcat name: {0}, age: {1}, gender: {2}, sound: {3})", this.Name, this.Age, this.Gender, this.TomcatSound);
        }
     }
}
