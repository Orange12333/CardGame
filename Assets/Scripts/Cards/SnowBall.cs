using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBall : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((2 - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;
        monster.monsterFreez += 1;

        playerData.discardPile.Add("SnowBall");
        playerData.handCards.Remove("SnowBall");
    }
}
