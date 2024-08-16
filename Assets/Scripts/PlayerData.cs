using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public BattleInfo PlayerStats;

    public float playerMaxHp;
    public float playerHp;
    public float playerArmor;
    public float playerBarrier;
    public float playerBlock;
    public float playerStr;
    public float playerWeak;
    public float playerBleed;
    public float playerBurn;
    public float playerFreez;
    public float playerReg;
    public int turn;

    public List<string> battleDeck = new List<string>();
    public List<string> handCards = new List<string>();
    public List<string> discardPile = new List<string>();
    private void Start()
    {
        PlayerStats = FindObjectOfType<BattleInfo>();
        playerMaxHp = PlayerStats.playerMaxHp;
        playerHp = PlayerStats.playerHp;
        playerArmor = PlayerStats.playerArmor;
        playerBarrier = PlayerStats.playerBarrier;
        playerBlock = PlayerStats.playerBlock;
        playerStr = PlayerStats.playerStr;
        playerWeak = PlayerStats.playerWeak;
        playerBleed = PlayerStats.playerBleed;
        playerBurn = PlayerStats.playerBurn;
        playerFreez = PlayerStats.playerFreez;
        playerReg = PlayerStats.playerReg;
        turn = 0;
        battleDeck.AddRange(PlayerStats.deck);
    }

    private void Update()
    {
        if (playerHp>playerMaxHp)
        {
            playerHp = playerMaxHp;
        }
    }
}
