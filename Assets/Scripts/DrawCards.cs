using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Amulet;
    public GameObject ArcaneBlast;
    public GameObject ArcaneMissiles;
    public GameObject Aura;
    public GameObject AuraBlade;
    public GameObject Bandage;
    public GameObject Blizzard;
    public GameObject BloodDrinker;
    public GameObject BodyOfFlames;
    public GameObject BodyOfIce;
    public GameObject CounterSpell;
    public GameObject CrimsonCurse;
    public GameObject Fireball;
    public GameObject FireNova;
    public GameObject Firestorm;
    public GameObject Frostbite;
    public GameObject Frostbolt;
    public GameObject HealingPotion;
    public GameObject HeavyArmor;
    public GameObject HeavyShield;
    public GameObject Hemorrhage;
    public GameObject HolyBlade;
    public GameObject IceLance;
    public GameObject Ignition;
    public GameObject Inferno;
    public GameObject InstantFreeze;
    public GameObject LightArmor;
    public GameObject MagicBlade;
    public GameObject MoltenArmor;
    public GameObject PiercingAttack;
    public GameObject Plan;
    public GameObject PotionOfStrength;
    public GameObject Power;
    public GameObject PowerSlash;
    public GameObject Punch;
    public GameObject Pyroblast;
    public GameObject QuickDraw;
    public GameObject Rend;
    public GameObject Shater;
    public GameObject ShieldBlock;
    public GameObject Shout;
    public GameObject Slash;
    public GameObject SnowBall;
    public GameObject Staff;
    public GameObject TimeWarp;
    public GameObject Wall;
    public Dictionary<string, GameObject> cardPrefabs = new Dictionary<string, GameObject>();

    public GameObject CardsArea;
    public GameObject DropArea;
    public PlayerData PlayerData;

    public int randomIndex;
    public string randomCard;


    void Start()
    {
        // Load all card prefabs and add them to the dictionary
        cardPrefabs.Add("Card1", Card1);
        cardPrefabs.Add("Card2", Card2);
        cardPrefabs.Add("Card3", Card3);
        cardPrefabs.Add("Amulet", Amulet);
        cardPrefabs.Add("ArcaneBlast", ArcaneBlast);
        cardPrefabs.Add("ArcaneMissiles", ArcaneMissiles);
        cardPrefabs.Add("Aura", Aura);
        cardPrefabs.Add("AuraBlade", AuraBlade);
        cardPrefabs.Add("Bandage", Bandage);
        cardPrefabs.Add("Blizzard", Blizzard);
        cardPrefabs.Add("BloodDrinker", BloodDrinker);
        cardPrefabs.Add("BodyOfFlames", BodyOfFlames);
        cardPrefabs.Add("BodyOfIce", BodyOfIce);
        cardPrefabs.Add("CounterSpell", CounterSpell);
        cardPrefabs.Add("CrimsonCurse", CrimsonCurse);
        cardPrefabs.Add("Fireball", Fireball);
        cardPrefabs.Add("FireNova", FireNova);
        cardPrefabs.Add("Firestorm", Firestorm);
        cardPrefabs.Add("Frostbite", Frostbite);
        cardPrefabs.Add("Frostbolt", Frostbolt);
        cardPrefabs.Add("HealingPotion", HealingPotion);
        cardPrefabs.Add("HeavyArmor", HeavyArmor);
        cardPrefabs.Add("HeavyShield", HeavyShield);
        cardPrefabs.Add("Hemorrhage", Hemorrhage);
        cardPrefabs.Add("HolyBlade", HolyBlade);
        cardPrefabs.Add("IceLance", IceLance);
        cardPrefabs.Add("Ignition", Ignition);
        cardPrefabs.Add("Inferno", Inferno);
        cardPrefabs.Add("InstantFreeze", InstantFreeze);
        cardPrefabs.Add("LightArmor", LightArmor);
        cardPrefabs.Add("MagicBlade", MagicBlade);
        cardPrefabs.Add("MoltenArmor", MoltenArmor);
        cardPrefabs.Add("PiercingAttack", PiercingAttack);
        cardPrefabs.Add("Plan", Plan);
        cardPrefabs.Add("PotionOfStrength", PotionOfStrength);
        cardPrefabs.Add("Power", Power);
        cardPrefabs.Add("PowerSlash", PowerSlash);
        cardPrefabs.Add("Punch", Punch);
        cardPrefabs.Add("Pyroblast", Pyroblast);
        cardPrefabs.Add("QuickDraw", QuickDraw);
        cardPrefabs.Add("Rend", Rend);
        cardPrefabs.Add("Shater", Shater);
        cardPrefabs.Add("ShieldBlock", ShieldBlock);
        cardPrefabs.Add("Shout", Shout);
        cardPrefabs.Add("Slash", Slash);
        cardPrefabs.Add("SnowBall", SnowBall);
        cardPrefabs.Add("Staff", Staff);
        cardPrefabs.Add("TimeWarp", TimeWarp);
        cardPrefabs.Add("Wall", Wall);
        // You can add as many cards as you need

        PlayerData = FindObjectOfType<PlayerData>();
    }
    // Start is called before the first frame update
    void Update()
    {
        PlayerData = FindObjectOfType<PlayerData>();
    }

    public void OnClick() 
    {
        for (var i = 0; i < 5; i++)
        {
            randomIndex = Random.Range(0, PlayerData.battleDeck.Count);
            randomCard = PlayerData.battleDeck[randomIndex];
            PlayerData.handCards.Add(PlayerData.battleDeck[randomIndex]);
            PlayerData.battleDeck.RemoveAt(randomIndex);
            //GameObject cardPrefab = Resources.Load<GameObject>(randomCard);
            GameObject cardPrefab = cardPrefabs[randomCard];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardsArea.transform, false);
        }
        /*{
            GameObject playerCard = Instantiate(Card1, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardsArea.transform, false);
        }*/
    }
}
