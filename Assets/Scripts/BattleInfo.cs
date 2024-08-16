using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleInfo : MonoBehaviour
{
    public float playerMaxHp;
    public float playerHp;
    public float playerHpPerLvl;
    public float playerLvl;
    public float playerXp;
    public float playerGold;
    public float playerArmor;
    public float playerBarrier;
    public float playerBlock;
    public float playerStr;
    public float playerWeak;
    public float playerBleed;
    public float playerBurn;
    public float playerFreez;
    public float playerReg;
    public string playerClass;
    public string enemy;
    public string currentZone;
    public int bossKilled = 0;
    public int existingRun = 0;
    public int battle = 0;
    public int bestscore = 0;
    public int score = 0;
    public string activity;
    public PlayerData PlayerData;

    //public string[] deck = new string[50];
    public List<string> deck = new List<string>();
    public List<string> currentLocation = new List<string>();
    //public List<string> warriorStarterDeck = new List<string>();
    public List<string> mageStarterDeck = new List<string>();
    public List<string> ForestCards = new List<string>();


    public List<string> warriorStarterDeck = new List<string> { "Punch", "Punch", "Punch", "Slash", "Slash", "Slash", "PowerSlash", "PowerSlash", "PowerSlash", "Amulet", "LightArmor","Power","Shout","Bandage","Bandage"};
    //public List<string> mageStarterDeck = new List<string>{"Punch", "Punch","Staff", "Staff", "Staff","Bandage", "Bandage", "Fireball", "Fireball","SnowBall", "SnowBall","ArcaneMissiles", "ArcaneMissiles","Frostbite","Ignition"};

    public List<string> warriorCards = new List<string> {"Amulet","Aura","AuraBlade","Bandage","BloodDrinker","HealingPotion","HeavyArmor","HeavyShield","Hemorrhage","HolyBlade","LightArmor","MagicBlade","PiercingAttack","Plan","Power","PowerSlash","Punch","QuickDraw","Rend","ShieldBlock","Shout","Slash","Wall" };
    public List<string> mageCards = new List<string> {"ArcaneMissiles","ArcaneBlast","Bandage","Blizzard","BodyOfFlames","BodyOfIce","CounterSpell","Fireball","FireNova","Firestorm","Frostbite","Frostbolt","HealingPotion","IceLance","Ignition","Inferno","InstantFreeze","MoltenArmor","PotionOfStrength","Punch","Pyroblast","Shater","SnowBall","Staff","TimeWarp" };

    //public List<string> ForestCards = new List<string> { "GoblinFight", "OrcFight", "EarthElementalFight","GoblinFight", "OrcFight", "EarthElementalFight", "GoblinFight", "OrcFight", "EarthElementalFight", "GoblinFight", "OrcFight", "EarthElementalFight", "GoblinFight", "OrcFight", "EarthElementalFight", "EliteOrcFight", "EliteOrcFight", "EliteOrcFight","Chest", "Chest", "Chest","Tavern", "Tavern", "Tavern","Shop", "Shop", "Shop","Rest", "Rest", "Rest"};
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Start()
    {
        PlayerData = FindObjectOfType<PlayerData>();
        
        string[] myArray = { "GoblinFight", "OrcFight", "EarthElementalFight", "GoblinFight", "OrcFight", "EarthElementalFight", "GoblinFight", "OrcFight", "EarthElementalFight", "GoblinFight", "OrcFight", "EarthElementalFight", "GoblinFight", "OrcFight", "EarthElementalFight", "EliteOrcFight", "EliteOrcFight", "EliteOrcFight", "Chest", "Chest", "Chest", "Tavern", "Tavern", "Tavern", "Shop", "Shop", "Shop", "Rest", "Rest", "Rest" };
        ForestCards.AddRange(myArray);
        
        string[] myArray2 = { "Punch", "Punch", "Staff", "Staff", "Staff", "Bandage", "Bandage", "Fireball", "Fireball", "SnowBall", "SnowBall", "ArcaneMissiles", "ArcaneMissiles", "Frostbite", "Ignition" };
        mageStarterDeck.AddRange(myArray2);
        
        //string[] myArray3 = { "Shop", "Shop", "Shop", "Shop", "Shop", "Shop","Rest", "Rest", "Rest" };
        //ForestCards.AddRange(myArray3);
        //string[] myArray4 = { "Punch", "Punch", "Staff", "Staff", "Staff", "Bandage", "Bandage", "Fireball", "Fireball", "SnowBall", "SnowBall", "ArcaneMissiles", "ArcaneMissiles", "Frostbite", "Ignition" };
        //mageStarterDeck.AddRange(myArray4);
        //warriorStarterDeck.Add("Slash", "PowerSlash", "Amulet", "LightArmor", "HolyBlade");
        //public List<string> warriorStarterDeck = new List<string> { "Slash","PowerSlash","Amulet","LightArmor","HolyBlade" };
    }

    public void LevelUp()
    {
        if (playerLvl == 1)
        {
            if (playerClass == "Warrior")
            {
                playerMaxHp += playerHpPerLvl;
                playerHp += playerHpPerLvl;
                playerArmor += 1;
            }
            else if(playerClass == "Mage")
            {
                playerMaxHp += playerHpPerLvl;
                playerHp += playerHpPerLvl;
                playerBarrier += 1;
            }
            playerLvl += 1;
        }
        else if(playerLvl == 2)
        {
            if (playerClass == "Warrior")
            {
                playerMaxHp += playerHpPerLvl;
                playerHp += playerHpPerLvl;
                playerArmor += 1;
                playerStr += 1;
            }
            else if (playerClass == "Mage")
            {
                playerMaxHp += playerHpPerLvl;
                playerHp += playerHpPerLvl;
                playerBarrier += 1;
                playerReg += 1;
            }
            playerLvl += 1;
        }
    }
}

