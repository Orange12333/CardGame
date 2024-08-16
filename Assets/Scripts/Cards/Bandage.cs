using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bandage : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerHp += 3;
        if (playerData.playerHp > playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }

        playerData.handCards.Remove("Bandage");
    }
}
