using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shater : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)(5 * monster.monsterFreez - monster.monsterBarrier);
        monster.hp -= dmg;
        monster.monsterFreez = 0;

        playerData.discardPile.Add("Shater");
        playerData.handCards.Remove("Shater");
    }
}
