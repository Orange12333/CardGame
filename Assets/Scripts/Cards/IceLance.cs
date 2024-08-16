using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceLance : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        if (monster.monsterFreez > 0)
        {
            dmg = (int)((9 - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        }
        else
        {
            dmg = (int)((3 - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        }
        monster.hp -= dmg;

        playerData.discardPile.Add("IceLance");
        playerData.handCards.Remove("IceLance");
    }
}
