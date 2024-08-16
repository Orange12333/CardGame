using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mainview : MonoBehaviour
{
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
    public Dictionary<string, GameObject> battleCardPrefabs = new Dictionary<string, GameObject>();

    public GameObject GoblinFight;
    public GameObject OrcFight;
    public GameObject EarthElementalFight;
    public GameObject CyclopsFight;
    public GameObject EliteOrcFight;
    public GameObject SomebodyFight;
    public GameObject CardsArea;
    public GameObject CardsArea2;
    public GameObject Chest;
    public GameObject Tavern;
    public GameObject Shop;
    public GameObject Rest;
    public BattleInfo BattleInfo;
    public GameObject BattleView;
    public GameObject OneCardEvent;
    public GameObject ShopEvent;
    public OneCardEvents OneCardEvents;
    public GameObject ShopCardsArea1;
    public GameObject ShopCardsArea2;
    public GameObject ShopCardsArea3;
    public TMP_Text ShopButton1;
    public TMP_Text ShopButton2;
    public TMP_Text ShopButton3;
    public PlayerData PlayerData;
    public TMP_Text Info;

    public Dictionary<string, GameObject> cardPrefabs = new Dictionary<string, GameObject>();

    public int randomIndex;
    public string randomCard;
    public int cardsDrawn;
    public string Card;
    public string ShopCard1;
    public string ShopCard2;
    public string ShopCard3;
    int CardPrice1;
    int CardPrice2;
    int CardPrice3;

    public void Start()
    {
        BattleInfo = FindObjectOfType<BattleInfo>();
        OneCardEvents = FindObjectOfType<OneCardEvents>();
        PlayerData = FindObjectOfType<PlayerData>();
        cardPrefabs.Add("GoblinFight", GoblinFight);
        cardPrefabs.Add("OrcFight", OrcFight);
        cardPrefabs.Add("EarthElementalFight", EarthElementalFight);
        cardPrefabs.Add("CyclopsFight", CyclopsFight);
        cardPrefabs.Add("EliteOrcFight", EliteOrcFight);
        cardPrefabs.Add("SomebodyFight", SomebodyFight);
        cardPrefabs.Add("Chest", Chest);
        cardPrefabs.Add("Tavern", Tavern);
        cardPrefabs.Add("Shop", Shop);
        cardPrefabs.Add("Rest", Rest);

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
    }

    public void MapDraw()
    {
        if(cardsDrawn==0)
        {
            if (BattleInfo.currentZone == "Forest" && BattleInfo.bossKilled == 0 && BattleInfo.currentLocation.Count > 0)
            {
                for (var i = 0; i < 3; i++)
                {
                    randomIndex = Random.Range(0, BattleInfo.currentLocation.Count);
                    randomCard = BattleInfo.currentLocation[randomIndex];
                    BattleInfo.currentLocation.RemoveAt(randomIndex);
                    GameObject cardPrefab = cardPrefabs[randomCard];
                    GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                    playerCard.transform.SetParent(CardsArea.transform, false);
                    cardsDrawn = 1;
                }
            }
            else if (BattleInfo.currentZone == "Forest" && BattleInfo.bossKilled == 0 && BattleInfo.currentLocation.Count == 0)
            {
                GameObject playerCard = Instantiate(CyclopsFight, new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(CardsArea.transform, false);
                cardsDrawn = 1;
                BattleInfo.bossKilled = 1;
            }
            else if (BattleInfo.currentZone == "Forest" && BattleInfo.bossKilled == 1)
            {
                GameObject playerCard = Instantiate(SomebodyFight, new Vector3(0, 0, 0), Quaternion.identity);
                playerCard.transform.SetParent(CardsArea.transform, false);
                cardsDrawn = 1;
            }
        }
    }
    public void ChestEvent()
    {
        cardsDrawn = 0;
        BattleInfo.activity = "Chest";
        OneEventcardsDraw();
        OneCardEvent.SetActive(true);
        BattleView.SetActive(false);
    }
    public void TavernEvent()
    {
        cardsDrawn = 0;
        BattleInfo.activity = "Tavern";
        OneEventcardsDraw();
        OneCardEvent.SetActive(true);
        BattleView.SetActive(false);
    }

    public void ShopEventStart()
    {
        cardsDrawn = 0;
        //BattleInfo.activity = "Chest";
        //OneEventcardsDraw();
        ShopCardsDraw();
        ShopEvent.SetActive(true);
        BattleView.SetActive(false);
    }

    public void OneEventcardsDraw()
    {
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
            playerCard.transform.SetParent(CardsArea2.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true;
            playerCard.AddComponent<CanvasGroup>().interactable = false;
        }
        else if (BattleInfo.activity == "Tavern")
        {
            randomIndex = Random.Range(0, BattleInfo.deck.Count);
            Card = BattleInfo.deck[randomIndex];
            GameObject cardPrefab = cardPrefabs[Card];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardsArea2.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true;
            playerCard.AddComponent<CanvasGroup>().interactable = false;
        }
    }
    public void ShopCardsDraw()
    {
        if (BattleInfo.playerClass == "Warrior")
        {
            randomIndex = Random.Range(0, BattleInfo.warriorCards.Count);
            ShopCard1 = BattleInfo.warriorCards[randomIndex];
            GameObject cardPrefab = cardPrefabs[ShopCard1];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(ShopCardsArea1.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;

            randomIndex = Random.Range(0, BattleInfo.warriorCards.Count);
            ShopCard2 = BattleInfo.warriorCards[randomIndex];
            cardPrefab = cardPrefabs[ShopCard2];
            playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(ShopCardsArea2.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;

            randomIndex = Random.Range(0, BattleInfo.warriorCards.Count);
            ShopCard3 = BattleInfo.warriorCards[randomIndex];
            cardPrefab = cardPrefabs[ShopCard3];
            playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(ShopCardsArea3.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;
        }
        else if (BattleInfo.playerClass == "Mage")
        {
            randomIndex = Random.Range(0, BattleInfo.mageCards.Count);
            ShopCard1 = BattleInfo.mageCards[randomIndex];
            GameObject cardPrefab = cardPrefabs[ShopCard1];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(ShopCardsArea1.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;

            randomIndex = Random.Range(0, BattleInfo.mageCards.Count);
            ShopCard2 = BattleInfo.mageCards[randomIndex];
            cardPrefab = cardPrefabs[ShopCard2];
            playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(ShopCardsArea2.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;

            randomIndex = Random.Range(0, BattleInfo.mageCards.Count);
            ShopCard3 = BattleInfo.mageCards[randomIndex];
            cardPrefab = cardPrefabs[ShopCard3];
            playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(ShopCardsArea3.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;
        }
        /*
        for (int i = 1; i <= 3; i++)
        {
            GameObject cardPrefab = cardPrefabs["ShopCard" + i];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            GameObject shopCardsArea = GameObject.Find("ShopCardsArea" + i);
            playerCard.transform.SetParent("ShopCardsArea" + i.transform, false);
            foreach (var trigger in playerCard.GetComponents<EventTrigger>())
            {
                Destroy(trigger);
            }
            playerCard.GetComponent<Rigidbody2D>().isKinematic = true; // Disable the Rigidbody2D
            playerCard.AddComponent<CanvasGroup>().interactable = false;
        }
        */
        CardPrice1 = Random.Range(25, 100);
        ShopButton1.text = CardPrice1.ToString();
        CardPrice2 = Random.Range(25, 100);
        ShopButton2.text = CardPrice2.ToString();
        CardPrice3 = Random.Range(25, 100);
        ShopButton3.text = CardPrice3.ToString();
        Info.text = "";
    }
    public void TakeCard1()
    {
        if (BattleInfo.playerGold >= CardPrice1)
        {
            BattleInfo.deck.Add(ShopCard1);
            BattleInfo.playerGold -= CardPrice1;
            Info.text = "Thanks!";
            /*
            for (int i = ShopCardsArea1.transform.childCount - 1; i >= 0; i--)
            {
                Destroy(ShopCardsArea1.transform.GetChild(i).gameObject);
            }
            for (int i = ShopCardsArea2.transform.childCount - 1; i >= 0; i--)
            {
                Destroy(ShopCardsArea2.transform.GetChild(i).gameObject);
            }
            for (int i = ShopCardsArea3.transform.childCount - 1; i >= 0; i--)
            {
                Destroy(ShopCardsArea3.transform.GetChild(i).gameObject);
            }
            for (int i = CardsArea.transform.childCount - 1; i >= 0; i--)
            {
                Destroy(CardsArea.transform.GetChild(i).gameObject);
            }
            */
        }
        else
        {
            Info.text = "Get some more gold!";
        }
    }
    public void TakeCard2()
    {
        if (BattleInfo.playerGold >= CardPrice2)
        {
            BattleInfo.deck.Add(ShopCard2);
            BattleInfo.playerGold -= CardPrice2;
            Info.text = "Thanks!";
        }
        else
        {
            Info.text = "Get some more gold!";
        }
    }
    public void TakeCard3()
    {
        if (BattleInfo.playerGold >= CardPrice3)
        {
            BattleInfo.deck.Add(ShopCard3);
            BattleInfo.playerGold -= CardPrice3;
            Info.text = "Thanks!";
        }
        else
        {
            Info.text = "Get some more gold!";
        }
    }
    public void IgnoreShop()
    {
    for (int i = ShopCardsArea1.transform.childCount - 1; i >= 0; i--)
    {
         Destroy(ShopCardsArea1.transform.GetChild(i).gameObject);
    }
    for (int i = ShopCardsArea2.transform.childCount - 1; i >= 0; i--)
    {
         Destroy(ShopCardsArea2.transform.GetChild(i).gameObject);
    }
    for (int i = ShopCardsArea3.transform.childCount - 1; i >= 0; i--)
    {
         Destroy(ShopCardsArea3.transform.GetChild(i).gameObject);
    }
    for (int i = CardsArea.transform.childCount - 1; i >= 0; i--)
    {
         Destroy(CardsArea.transform.GetChild(i).gameObject);
    }
    }
    public void RestEvent()
    {
        cardsDrawn = 0;
        BattleInfo.playerXp += 20;
        BattleInfo.playerHp += BattleInfo.playerMaxHp / 2f;
        if (BattleInfo.playerHp > BattleInfo.playerMaxHp)
        {
            BattleInfo.playerHp = BattleInfo.playerMaxHp;
        }
        PlayerData.playerHp = BattleInfo.playerHp;
        for (int i = CardsArea.transform.childCount - 1; i >= 0; i--)
        {
            Destroy(CardsArea.transform.GetChild(i).gameObject);
        }
    }
}
