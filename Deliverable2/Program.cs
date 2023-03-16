// Deliverable 2 - The Coin Flip Challenge 

using System.ComponentModel.Design;

Console.WriteLine("Welcome to the Coin Flip Challenge!");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine(name + " would you like to do the Coin Flip Challenge? yes/no");
string dec = Console.ReadLine();

if (dec == "no") { 
    Console.WriteLine("You are a coward, " + name + ".");
} else if (dec == "yes") {
    int score = 0;
    
    for (int i = 0; i < 5; i++)
    {
        Random random = new Random();
        int rand = random.Next(0, 2); // Heads = 0, Tails = 1

        Console.WriteLine("Heads or Tails?");
        string answer = Console.ReadLine();

        if (answer == "Heads" && rand == 0) {
            Console.WriteLine("Correct!");
        score++; 
        }
        else if (answer == "Tails" && rand == 1)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else {
            Console.WriteLine("Wrong!");
        }

    }
    Console.WriteLine("Thank you, " + name + ", for completing the Coin Flip Challenge! You got a score of " + score + ".");


}







