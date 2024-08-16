using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firestorm : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((3 - playerData.playerFreez - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;
        monster.monsterBurn += 3;
        playerData.playerBurn += 3;

        playerData.discardPile.Add("Firestorm");
        playerData.handCards.Remove("Firestorm");
    }
}
