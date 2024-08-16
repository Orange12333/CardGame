using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignition : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterBurn += 3;

        playerData.discardPile.Add("Ignition");
        playerData.handCards.Remove("Ignition");
    }
}
