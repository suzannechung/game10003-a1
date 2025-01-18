//Welcome to Suzie's Haunted Manor - Escape Room Game

//Introduction to the Game
Console.WriteLine("Oh, look at you, brave enough to step into a crumbling, haunted estate, but not quite smart enough to turn around and leave. \n" +
    "Typical. But now that you're here, there's no going back. \n" +
    "Welcome to Suzie's Haunted Manor! \n" +
    "You'll need more than just a good attitude to make it out of here. \n" +
    "Solve riddles and dodge creepy spirits ... if you can. \n" +
    "One wrong move and you might end up TRAPPED, haunting the halls with the rest of the forgotten souls. \n" +
    "Go on! The manor’s got something special waiting for you MWHAHAHA");

Console.WriteLine("... \n" +
   "... \n" +
   "... \n" +
   "... \n");

Console.Write($"Tell us your name: ");
string playerName = Console.ReadLine();

Console.Write($"By the way.... How much gold do you have? ");
int goldMoney = int.Parse(Console.ReadLine());

Console.WriteLine("Hmmm I hope you have enough for what lies ahead...\n");

//Player now starts on their adventure to escape and must choose amongst 2 rooms - each has their own challenges
Console.WriteLine("You find yourself in the foyer of the manor and you see 2 entryways - one on the left and another on the right. \n" +
    "You notice that the entryway on the right has a cool breeze coming through....\n");
Console.Write($"Where do you want to go? ");
string foyerDecision = Console.ReadLine();

//The player enters the Living Room
if (foyerDecision.ToLower() == "left")
{
    Console.WriteLine($"You walk towards the room on the {foyerDecision}...\n");
    Console.WriteLine("The living room is cloaked in darkness, with only the faint glow of a broken lamp casting twisted shadows on the walls. \n" +
        "As you scan the room, you notice the living room leads to into a hallway. You have a choice to go either left or right. \n");
    Console.Write($"Where do you want to go? ");
    string livingroomDecision = Console.ReadLine();


    //The player must solve the math riddle to succeed in the escape. The player only gets one guess in order to successfully escape else they are trapped.
    if (livingroomDecision.ToLower() == "left")
    {
        Console.WriteLine($"As you enter the hallway, you decided to turn {livingroomDecision}.\n");
        Console.WriteLine("The hallway is narrow and dimly lit, its walls lined with peeling wallpaper that seems to pulse with a life of its own in the faint light.\n" +
            "At the end of the hall, on the cold dusty wooden floor, you see a riddle scratched into the floor. \n" +
            "You kneel down and take a closer look..... \n");
        
        Console.Write($"I am an odd number. Take away one letter, and I become even. What number am I? ");
        string hallwayRiddle = Console.ReadLine();

        //Player escapes the manor if they solve the riddle.
        if (hallwayRiddle.ToLower() == "seven")
        {
            Console.WriteLine($"Once you finish writing the word {hallwayRiddle} on the dusty floor, you suddenly hear a click sound and the door in front of you suddenly is unlocked.");
            Console.WriteLine("You open the door and bright light floods into the hallway! It appears to be a sunroom! \n" +
                "As you enter the room, you see that the room leads out of the manor! \n");
            Console.WriteLine("You've successfully escaped Suzie's Manor!");
        }

        //Player is trapped for not answering decypher the riddle correctly.
        else
        {
            Console.WriteLine("As you finish writing your answer on the dusty floor, you feel the floor underneath shake. \n" +
                "All of a sudden the floor cracks and breaks, you find yourself falling through! \n");
            Console.WriteLine($"Game Over {playerName}");
        }
    }
    //The doll is cursed. The player must solve the math problem correctly in order to successfuly escape else they are trapped.
    
    else if (livingroomDecision.ToLower() == "right")
    {
        Console.WriteLine($"As you enter the hallway, you decided to turn {livingroomDecision}. \n");
        Console.WriteLine("The hallway is narrow and dimly lit, its walls lined with peeling wallpaper that seems to pulse with a life of its own in the faint light. \n" +
            "At the end of the hallway, you find yourself in another room, it looks like a bedroom! \n" +
            "You find a creepy looking doll just sitting on the bed. \n" +
            "You have this sudden urge to pick up the doll. \n");

        
        Console.Write($"Do you want to pick up the doll? ");
        string doll = Console.ReadLine();

        //Player encounters a math problem to solve when they pick up the doll.
        if (doll.ToLower() == "yes")
        {
            Console.WriteLine("You find yourself in a weird hypnotic state and you hear a voice inside your head. \n" +
                "In order to leave this manor, you must solve this problem! \n");
            Console.Write($"What is (20 - 2) / 3 + 5? \n");
            int dollRiddle = int.Parse(Console.ReadLine());
            int dollRiddleAnswer = 11;

            //Player escapes the manor for calculating the correct answers to the math problem.
            if (dollRiddle == dollRiddleAnswer)
            {
                Console.WriteLine("Snap out of your hynpotic state and find yourself at home sitting on the couch. \n");
                Console.WriteLine("You've successfully escaped Suzie's Manor!");
            }
            //Player is trapped for not answering the math problem correctly.
            else
            {
                Console.WriteLine("All you hear is a little girl's voice: oh no.... \n");
                Console.WriteLine($"Game Over {playerName}");
            }   
        }

        //Player is trapped for not picking up the doll.
        else
        {
            Console.WriteLine("The bedroom door swings shut and everything goes completely dark and all you can hear are screams. \n");
            Console.WriteLine($"Game Over {playerName}");
        }
    }
}

//The player must remember their intial gold input to solve the math problem in this room to successfully escape else they are trapped.
else if (foyerDecision.ToLower() == "right")
{
    Console.WriteLine($"You walk towards the room on the {foyerDecision}... \n");
    Console.WriteLine("As you walk down the narrow, dimly lit staircase into the creepy basement, the air grows cold and heavy with the scent of dampness and decay. \n" +
        "\"The flickering light from a single bulb above casts long, unsettling shadows on the cracked stone walls. \n" +
        "Along the walls, you see a message.... \n" +
        $"You came into this manor with {goldMoney} gold. You can escape this manor if you can pay 5 Zenthos. \n" +
        $"Zenthos is worth 3 times the amount of gold. \n");
    Console.Write("How much gold would you need to pay the manor? ");
    int basementRiddle_Cost = int.Parse(Console.ReadLine());

    Console.Write("How much gold would you have left, if you paid the manor? ");
    int basementRiddle_GoldRemaining = int.Parse(Console.ReadLine());

    int basementRiddle_CostAnswer = 5 * 3;
    int basementRiddle_GoldRemainingAnswer = goldMoney - basementRiddle_CostAnswer;

    //Player escapes the manor for calculating the correct answers to the math problem.
    if ((basementRiddle_Cost == basementRiddle_CostAnswer) & (basementRiddle_GoldRemaining == basementRiddle_GoldRemainingAnswer))
    {
        Console.WriteLine("... \n" +
            "...\n" +
            "You suddenly find yourself in front of your favourite ice cream store. \n" +
            "You've successfully escaped Suzie's Manor!");
    }
    //Player is trapped for not answering the math problem correctly.
    else
    {
        Console.WriteLine("You start feeling dizzy and light headed ... You've fainted!");
        Console.WriteLine($"Game Over {playerName}");
    }
}
