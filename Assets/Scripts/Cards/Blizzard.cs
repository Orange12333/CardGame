using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blizzard : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((4 - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;
        monster.monsterFreez += 4;
        playerData.playerFreez += 4;

        playerData.discardPile.Add("Blizzard");
        playerData.handCards.Remove("Blizzard");
    }
}
