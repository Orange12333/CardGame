using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBlock : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        if (playerData.playerBlock < 25)
        {
            playerData.playerBlock = 25;
        }

        playerData.discardPile.Add("ShieldBlock");
        playerData.handCards.Remove("ShieldBlock");
    }
}
