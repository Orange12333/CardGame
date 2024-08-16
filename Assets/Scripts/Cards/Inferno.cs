using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inferno : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((1 + monster.monsterBurn - playerData.playerFreez - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;

        playerData.discardPile.Add("Inferno");
        playerData.handCards.Remove("Inferno");
    }
}
