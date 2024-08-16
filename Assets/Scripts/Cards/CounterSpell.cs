using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterSpell : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterBarrier = 0;

        playerData.discardPile.Add("CounterSpell");
        playerData.handCards.Remove("CounterSpell");
    }
}
