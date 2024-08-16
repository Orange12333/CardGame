using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyOfFlames : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerHp += playerData.playerBurn;
        if (playerData.playerHp > playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }
        playerData.playerBurn = 0;

        playerData.discardPile.Add("BodyOfFlames");
        playerData.handCards.Remove("BodyOfFlames");
    }
}
