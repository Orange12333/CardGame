using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBlade : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((4 + playerData.playerStr - playerData.playerFreez - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;

        playerData.discardPile.Add("MagicBlade");
        playerData.handCards.Remove("MagicBlade");
    }
}
