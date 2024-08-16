using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((1 + playerData.playerStr - playerData.playerFreez - monster.monsterArmor - playerData.playerWeak) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;

        playerData.handCards.Remove("Punch");
    }
}
