using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyOfIce : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerHp += playerData.playerFreez;
        if (playerData.playerHp > playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }
        playerData.playerFreez = 0;

        playerData.discardPile.Add("BodyOfIce");
        playerData.handCards.Remove("BodyOfIce");
    }
}
