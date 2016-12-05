using System;

public class GameStart{

    public int health;
    private LevelBase Level = new LevelBase();
   public static PlayerCreator player = new PlayerCreator();
   public static WeaponSelect weapon = new WeaponSelect();
    public void Game(){
       player.whatGender();
       player.pickRace();
       player.whatsYourName(); 
       weapon.pickWeapon(); 
       Play();
    }      
    private string gameFunction = "Start";
    private GameFunction.GamePlay toEnum;
    public void Play(){

        switch (toEnum){
            case GameFunction.GamePlay.Start:
                Console.WriteLine("To Continue: Play, End, Attack");
                gameFunction = Console.ReadLine();
                Console.WriteLine(gameFunction);
                if(Enum.TryParse(gameFunction, out toEnum)){
                    Console.WriteLine(toEnum);
                }
            Play();

            break;

            case GameFunction.GamePlay.End:
                Console.WriteLine("Game Over");
            break;

            case GameFunction.GamePlay.Play:
            Level.enter();
            while (GameStart.canPlay){
                GameTimer();
                Play();

            }
            Play();
            break;

            default:
                Console.WriteLine("This is not a valid option");
                Play();
            break;
        }
    }
     public void GameTimer(){
            
            System.Threading.Thread.Sleep(2000);
        }
           public static bool canPlay = true;
        


    }