using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantFreeze : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterFreez += 5;

        playerData.discardPile.Add("InstantFreez");
        playerData.handCards.Remove("InstantFreez");
    }
}
