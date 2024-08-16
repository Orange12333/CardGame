using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amulet : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerBarrier += 1;

        playerData.discardPile.Add("Amulet");
        playerData.handCards.Remove("Amulet");
    }
}
