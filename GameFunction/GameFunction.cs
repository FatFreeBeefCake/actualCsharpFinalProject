using System;
using System.Collections.Generic;

public class GameFunction
{
    public static Return Health = new Return();
    public static string AttackLine;
    public static int OfHits = 3;
    public static void AttackFunction()
    
    { 
        Console.WriteLine("You have encountered an enemy!");
        Console.WriteLine("Will you Attack or Run?");
        AttackLine = Console.ReadLine();
        if (AttackLine == "Attack")
        {
            Console.WriteLine("You have attacked the Enemy!");
            while (OfHits > 0)
            {
                Console.WriteLine("You hit the beast!");
                OfHits--;
            }
            Console.WriteLine("You managed to kill the beast! but lost a little health!");
        }  else if (AttackLine == "Run")
        {
            Console.WriteLine("This is real life, you cant run from your problems!");
            Console.WriteLine("The Monster attacks from behind and you bleed out!");
            Console.WriteLine("You Died!");
            Console.WriteLine("Game Over");
            Environment.Exit(0);
        }
    }
    public enum GamePlay { Start, Play, End, Died }

    public static GamePlay currentGamePlay = GamePlay.Start;

}