using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card3 : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        //monster = FindObjectOfType<MonsterData>();
        //monster.hp -= 1;
        playerData = FindObjectOfType<PlayerData>();
        playerData.playerHp += 3;
        if(playerData.playerHp>playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }

        playerData.discardPile.Add("Card3");
        playerData.handCards.Remove("Card3");
    }
}
