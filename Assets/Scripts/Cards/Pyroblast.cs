using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pyroblast : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((8 - playerData.playerFreez - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;

        playerData.discardPile.Add("Pyroblast");
        playerData.handCards.Remove("Pyroblast");
    }
}
