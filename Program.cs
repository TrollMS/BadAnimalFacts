/**
    This garbage was  made on 11/24/2024
*/

using System; 

public class Program {
    static int Main(string[] args) {
    Console.Clear();
    Console.WriteLine("What animal do you want to know cool facts about? Type list to see all that are avalible.\n");
    
        while(true) {      

            string userInput = Console.ReadLine().ToLower(); // Deference of a possible null null reference, not sure what this means or how to fix it.

            Animal? animal = null; // Deference of a possible null null reference, vscode suggested to put ? in front of the Animal class, not sure what that does.

            switch(userInput) { // It felt natural to have it be "cats" rather than "cat" but im curious on how to make it work if the user only typed "cat" as well
                case "list":
                Console.Clear();
                Console.WriteLine("All Animals :\n\nCats\nDogs\nRats\n\nPlease type the name of the animal you are interested in, or type exit to quit.\n"); // I'd rather just make a for loop that would go through Animals subclass but not sure how to do that.
                break;

                case "cats" :
                Console.Clear();
                animal = new Cat("cat"); // I don't really know what the keyword new is doing, is it making a new object of the subclass Cat? 
                break;

                case "dogs" :
                Console.Clear();
                animal = new Dog("dog");
                break;

                case "rats" :
                Console.Clear();
                animal = new Rat("rat");
                break;

                case "exit":
                Console.Clear();
                Console.WriteLine("Bye!");
                return 0;

                default :
                Console.Clear();
                Console.WriteLine("I don't have information on that. Type list to see all avalible animals \n");
                break;
            }

            animal?.PrintInfo();
        }
    }
}