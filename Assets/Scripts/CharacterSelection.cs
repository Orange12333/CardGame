using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    public BattleInfo Deckinfo;

    public void Start()
    {
        Deckinfo = FindObjectOfType<BattleInfo>();
    }
    public void WarriorSelected()
    {
        Debug.Log("Warrior");
        Deckinfo.playerClass = "Warrior";
        Deckinfo.playerMaxHp = 50;
        Deckinfo.playerHp = 50;
        Deckinfo.playerHpPerLvl = 15;
        Deckinfo.playerLvl = 1;
        Deckinfo.playerXp = 0;
        Deckinfo.playerGold = 0;
        Deckinfo.playerArmor = 0;
        Deckinfo.playerBarrier = 0;
        Deckinfo.playerBlock = 0;
        Deckinfo.playerStr = 0;
        Deckinfo.playerWeak = 0;
        Deckinfo.playerBleed = 0;
        Deckinfo.playerBurn = 0;
        Deckinfo.playerFreez = 0;
        Deckinfo.playerReg = 0;
        Deckinfo.existingRun = 1;
        Deckinfo.deck.Clear();
        Deckinfo.currentLocation.Clear();
        Deckinfo.deck.AddRange(Deckinfo.warriorStarterDeck);
        Deckinfo.currentLocation.AddRange(Deckinfo.ForestCards);
        Deckinfo.bossKilled = 0;
        Deckinfo.currentZone = "Forest";
        SceneManager.LoadScene("MainView");
    }

    public void MageSelected()
    {
        Debug.Log("Mage");
        Deckinfo.playerClass = "Mage";
        Deckinfo.playerMaxHp = 40;
        Deckinfo.playerHp = 40;
        Deckinfo.playerHpPerLvl = 10;
        Deckinfo.playerLvl = 1;
        Deckinfo.playerXp = 0;
        Deckinfo.playerGold = 0;
        Deckinfo.playerArmor = 0;
        Deckinfo.playerBarrier = 0;
        Deckinfo.playerBlock = 0;
        Deckinfo.playerStr = 0;
        Deckinfo.playerWeak = 0;
        Deckinfo.playerBleed = 0;
        Deckinfo.playerBurn = 0;
        Deckinfo.playerFreez = 0;
        Deckinfo.playerReg = 0;
        Deckinfo.existingRun = 1;
        Deckinfo.deck.Clear();
        Deckinfo.currentLocation.Clear();
        Deckinfo.deck.AddRange(Deckinfo.mageStarterDeck);
        Deckinfo.currentLocation.AddRange(Deckinfo.ForestCards);
        Deckinfo.bossKilled = 0;
        Deckinfo.currentZone = "Forest";
        SceneManager.LoadScene("MainView");
    }

    public void BackSelected()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
