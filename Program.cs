// See https://aka.ms/new-console-template for more information

/* In this dice game we will roll three dice numbered between 1-6. 
The objective is to roll 15 or greater. 
Doubles result in two extra bonus points. 
Triples result in six bonus points. 
*/

using System;

// Asking For Player Name: 
Console.WriteLine("Welcome to my die game. Please enter your name: ");
string playerName;



// Defining random varible (to be used later)
Random randomOne = new Random();
Random randomTwo = new Random();
Random randomThree = new Random();

// Assigning an integer value between and including 1-6
int randomNumberOne = randomOne.Next(1, 7);
int randomNumberTwo = randomTwo.Next(1, 7);
int randomNumberThree = randomThree.Next(1, 7);

// Total Sum of Dice: 
int diceTotal = (randomNumberOne + randomNumberTwo + randomNumberThree);

// Dice Roll Test:  
Console.WriteLine($"Dice One: {randomNumberOne}");
Console.WriteLine($"Dice One: {randomNumberTwo}");
Console.WriteLine($"Dice One: {randomNumberThree}");
Console.WriteLine($"Dice Total: {diceTotal}");

// DiceRollOne Doubles If Conditions: 
if (randomNumberOne == randomNumberTwo || randomNumberOne == randomNumberThree)
{
    diceTotal  ++; 
}
// DiceRollTwo Double IF Condition: 
if (randomNumberTwo == randomNumberOne || randomNumberTwo == randomNumberThree)
{
    diceTotal ++;
}
// DiceRollThree Double IF Conditon:
if (randomNumberThree == randomNumberOne || randomNumberThree == randomNumberTwo)
{
    diceTotal ++;
}
// Triples IF Condition (Unlikely to happen LOL):
if (randomNumberOne == randomNumberTwo && randomNumberTwo == randomNumberThree)
{
    diceTotal += 6;
}
// Displays New Dice Total (After above calculations)
Console.WriteLine($"New Dice Total: {diceTotal}");

// Winning/Lost IF Condition
if (diceTotal >= 15)
{
    Console.WriteLine($"Congratulations, you rolled {diceTotal}.");

}
else
{
    Console.WriteLine($"Tough Luck!! You scored {diceTotal}.");
}

