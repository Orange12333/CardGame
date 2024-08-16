using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class OneCardEvents : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text TopText;
    public TMP_Text GreenButton;
    public BattleInfo BattleInfo;
    public Mainview Mainview;
    public string Card;
    public int randomIndex;

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
    public Dictionary<string, GameObject> warriorcardPrefabs = new Dictionary<string, GameObject>();
    public Dictionary<string, GameObject> magecardPrefabs = new Dictionary<string, GameObject>();
    public Dictionary<string, GameObject> cardPrefabs = new Dictionary<string, GameObject>();
    public GameObject CardsArea;
    public GameObject Map;

    public string activity;
    //public int value2;
    void Start()
    {
        //EndTurn = FindObjectOfType<EndTurn>();
        //MonsterData = FindObjectOfType<MonsterData>();
        //battleRewards.text = "You Found " + EndTurn.goldGain.ToString() + " gold\nYou gain " + EndTurn.expGain.ToString() + " exp";
    }
    private void Awake()
    {
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
        BattleInfo = FindObjectOfType<BattleInfo>();
        Mainview = FindObjectOfType<Mainview>();
        //value1 = EndTurn.goldGain;
        /*
        if (BattleInfo.activity == "Chest")
        {
            if (BattleInfo.playerClass == "Warrior")
            {
                randomIndex = Random.Range(0, BattleInfo.warriorCards.Count);
                Card = BattleInfo.warriorCards[randomIndex];
            }
            else if (BattleInfo.playerClass == "Mage")
            {
                randomIndex = Random.Range(0, BattleInfo.mageCards.Count);
                Card = BattleInfo.mageCards[randomIndex];
            }

            GameObject cardPrefab = cardPrefabs[Card];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardsArea.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;
        }
        else if(BattleInfo.activity == "Tavern")
        {
            randomIndex = Random.Range(0, BattleInfo.deck.Count);
            Card = BattleInfo.deck[randomIndex];
            GameObject cardPrefab = cardPrefabs[Card];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardsArea.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;
        }   
        */
    }
    public void TakeCard()
    {
        if (BattleInfo.activity == "Tavern")
        {
            BattleInfo.deck.Remove(Mainview.Card);
        }
        else if(BattleInfo.activity == "Chest")
        {
            BattleInfo.deck.Add(Mainview.Card);
        }
        for (int i = CardsArea.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(CardsArea.transform.GetChild(i).gameObject);
        }
        for (int i = Map.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(Map.transform.GetChild(i).gameObject);
        }
    }
    public void IgnoreCard()
    {
        for (int i = CardsArea.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(CardsArea.transform.GetChild(i).gameObject);
        }
        for (int i = Map.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(Map.transform.GetChild(i).gameObject);
        }
    }
    public void Update()
    {
        if (BattleInfo.activity == "Tavern")
        {
            TopText.text = "Delete this card?";
            GreenButton.text = "Delete";
        }
        else if (BattleInfo.activity == "Chest")
        {
            TopText.text = "Take this card?";
            GreenButton.text = "Take";
        }
    }
}
