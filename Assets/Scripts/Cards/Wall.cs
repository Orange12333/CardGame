using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        if (playerData.playerBlock < 75)
        {
            playerData.playerBlock = 75;
        }

        playerData.discardPile.Add("Wall");
        playerData.handCards.Remove("Wall");
    }
}
