using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneMissiles : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.hp -= 4;

        playerData.discardPile.Add("ArcaneMissiles");
        playerData.handCards.Remove("ArcaneMissiles");
    }
}
