using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyBlade : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((10 + playerData.playerStr - playerData.playerFreez - monster.monsterArmor - playerData.playerWeak) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;
        playerData.playerHp += dmg;
        if (playerData.playerHp > playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }

        playerData.discardPile.Add("HolyBlade");
        playerData.handCards.Remove("HolyBlade");
    }
}
