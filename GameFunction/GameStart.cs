using System;

public class GameStart
{
    private LevelBase Level = new LevelBase();
    public static PlayerCreator player = new PlayerCreator();
    public static WeaponSelect weapon = new WeaponSelect();
    public void Game()
    {
        player.whatGender();
        player.pickRace();
        player.whatsYourName();
        weapon.pickWeapon();
        // GameFunction.AttackFunction();
        Play();
    }
    private string gameFunction = "Start";
    private GameFunction.GamePlay toEnum;
    public void Play()
    {

        switch (toEnum)
        {
            case GameFunction.GamePlay.Start:
                Console.WriteLine("To Continue: Play, End");
                gameFunction = Console.ReadLine();
                Console.WriteLine(gameFunction);
                if (Enum.TryParse(gameFunction, out toEnum))
                {
                    Console.WriteLine(toEnum);
                }
                Play();

                break;

            case GameFunction.GamePlay.End:
                Console.WriteLine("Game Over");
                Console.WriteLine(" Type (dotnet run) to play again!");
                Environment.Exit(0);
                break;

            case GameFunction.GamePlay.Play:
                Level.enter();
                Level.Encounter(2);
                while (GameStart.canPlay)
                {
                    GameTimer();
                    Play();

                }
                Play();
                break;

            case GameFunction.GamePlay.Died:
                Console.WriteLine("You Died");
                Console.WriteLine("Game Over");
                break;

            default:
                Console.WriteLine("This is not a valid option");
                Play();
                break;
        }
        Random randomNum = new Random();
        Level.Encounter(randomNum.Next(0, Level.Enemies.Length));
    }
    public void GameTimer()
    {

        System.Threading.Thread.Sleep(2000);
    }
    public static bool canPlay = true;



}