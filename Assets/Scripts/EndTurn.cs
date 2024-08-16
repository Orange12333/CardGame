using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndTurn : MonoBehaviour
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
    public TMP_Text label1;

    public GameObject CardsArea;
    public GameObject DropArea;
    public PlayerData PlayerData;
    public MonsterData monster;
    public TMP_Text buttonlabel;
    public BattleInfo BattleInfo;
    public GameObject BattleView;
    public GameObject YouLose;
    public GameObject YouWin;
    public YouWin YouWinScript;

    public int randomIndex;
    public string randomCard;
    public int goldGain;
    public int expGain;
    int x = 0;

    public void Start()
    {
        monster = FindObjectOfType<MonsterData>();
        PlayerData = FindObjectOfType<PlayerData>();
        BattleInfo = FindObjectOfType<BattleInfo>();
        YouWinScript = FindObjectOfType<YouWin>();

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
        Debug.Log("eloelo320");
        /*
        if (PlayerData.battle == 1) 
        { 
            DrawCards(); 
        }
        */
    }
    /*
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        DrawCards();
    }
    */
    public IEnumerator EndTurnActions()
    {
        if (x == 0)
        {
            x = 1;
            yield return new WaitForSeconds(2);
            PlayerAfterEffects();
            monster.MonsterAttack();
            if (PlayerData.playerHp <= 0)
            {
                YouLoseBattle();
            }
            else
            {
                yield return new WaitForSeconds(2);
                PlayerBeforeEffects();
                DrawCards();
                PlayerData.turn += 1;
                if (PlayerData.playerHp <= 0)
                {
                    YouLoseBattle();
                }
                x = 0;
            }
        }
    }

    public void YouWinBattle()
    {
        goldGain = (int)monster.gold + Random.Range(1, 10);
        BattleInfo.playerGold += goldGain;
        expGain = (int)monster.exp + Random.Range(1, 10);
        BattleInfo.playerXp += expGain;
        BattleInfo.battle = 0;
        BattleInfo.playerHp = PlayerData.playerHp;
        buttonlabel.text = "Start\nBattle";
        YouWin.SetActive(true);
        BattleView.SetActive(false);
    }

    public void YouLoseBattle()
    {
        BattleInfo.battle = 0;
        BattleInfo.existingRun = 0;
        buttonlabel.text = "Start\nBattle";
        if(BattleInfo.score>BattleInfo.bestscore)
        {
            BattleInfo.bestscore = BattleInfo.score;
        }
        BattleView.SetActive(false);
        YouLose.SetActive(true);
    }

    public void DrawCard()
    {
        if (PlayerData.battleDeck.Count == 0)
        {
            PlayerData.battleDeck.AddRange(PlayerData.discardPile);
            PlayerData.discardPile.Clear();
        }
        randomIndex = Random.Range(0, PlayerData.battleDeck.Count);
        randomCard = PlayerData.battleDeck[randomIndex];
        PlayerData.handCards.Add(PlayerData.battleDeck[randomIndex]);
        PlayerData.battleDeck.RemoveAt(randomIndex);
        GameObject cardPrefab = cardPrefabs[randomCard];
        GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        playerCard.transform.SetParent(CardsArea.transform, false); 
    }

    public void DrawCards()
    {
        for (var i = 0; i < 5; i++)
        {
            if(PlayerData.battleDeck.Count == 0)
            {
                PlayerData.battleDeck.AddRange(PlayerData.discardPile);
                PlayerData.discardPile.Clear();
            }
            randomIndex = Random.Range(0, PlayerData.battleDeck.Count);
            randomCard = PlayerData.battleDeck[randomIndex];
            PlayerData.handCards.Add(PlayerData.battleDeck[randomIndex]);
            PlayerData.battleDeck.RemoveAt(randomIndex);
            GameObject cardPrefab = cardPrefabs[randomCard];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardsArea.transform, false);

        }
    }

    public void DeckView()
    {
        for (var i = 0; i < BattleInfo.deck.Count; i++)
        {
            GameObject cardPrefab = cardPrefabs[i.ToString()];
            GameObject playerCard = Instantiate(cardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(CardsArea.transform, false);
        }
    }

    public void EndPlayerTurn()
    {
        if (PlayerData.turn == 0)
        {
            DrawCards();
            buttonlabel.text = "End\nTurn";
            PlayerData.turn += 1;
        }
        else 
        {
            foreach (Transform child in CardsArea.transform)
            {
                Destroy(child.gameObject);
            }
            PlayerData.discardPile.AddRange(PlayerData.handCards);
            PlayerData.handCards.Clear();
            StartCoroutine(EndTurnActions());
        }
    }

    public void PlayerBeforeEffects()
    {
        PlayerData.playerBlock = 0;
        if (PlayerData.playerStr > 0)
        {
            PlayerData.playerStr -= 1;
        }
        PlayerData.playerHp -= PlayerData.playerBurn;
        if (PlayerData.playerBurn > 0)
        {
            PlayerData.playerBurn -= 1;
        }
        PlayerData.playerHp += PlayerData.playerReg;
        if (PlayerData.playerHp > PlayerData.playerMaxHp)
        {
            PlayerData.playerHp = PlayerData.playerMaxHp;
        }
    }
    public void PlayerAfterEffects()
    {
        if (PlayerData.playerWeak>0)
        {
            PlayerData.playerWeak -= 1;
        }
        PlayerData.playerHp -= PlayerData.playerBleed;
        if (PlayerData.playerBleed > 0)
        {
            PlayerData.playerBleed -= 1;
        }
        PlayerData.playerFreez = 0;
    }
    public void ClearBoard()
    {
        foreach (Transform child in CardsArea.transform)
        {
            Destroy(child.gameObject);
        }
        PlayerData.battleDeck.Clear();
        PlayerData.handCards.Clear();
        PlayerData.discardPile.Clear();
    }
}
