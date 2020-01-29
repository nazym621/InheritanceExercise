using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var parrot = new Bird();
            parrot.Beak = true;
            parrot.CanTalk = "yes";
            parrot.Feathers = true;

            var parakeet = new Bird();
            parakeet.Tongue = true;
            parakeet.Legs = 2;



            var snake = new Reptile();
            snake.ProduceEggs = true;
            snake.Tongue = true;
            snake.Scales = true;

            var alligater = new Reptile();
            alligater.Eyes = true;
            alligater.Scales = true;

            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
