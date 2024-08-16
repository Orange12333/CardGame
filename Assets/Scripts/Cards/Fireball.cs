using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((2 - playerData.playerFreez - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;
        monster.monsterBurn += 1;

        playerData.discardPile.Add("Fireball");
        playerData.handCards.Remove("Fireball");
    }
}
