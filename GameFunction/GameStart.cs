using System;

public class GameStart{

    public int health;
    LevelBase Level = new LevelBase();
   public static PlayerCreator player = new PlayerCreator();
    public void Game(){
       player.whatGender();
       player.pickRace();
       player.whatsYourName(); 
        
        

    }
    
}