using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodDrinker : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)((5 + playerData.playerStr - playerData.playerFreez - monster.monsterArmor - playerData.playerWeak) * (100 - monster.monsterBlock) / 100);
        monster.hp -= dmg;
        playerData.playerHp += monster.monsterBleed;
        if (playerData.playerHp > playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }
        monster.monsterBleed = 0;

        playerData.discardPile.Add("BloodDrinker");
        playerData.handCards.Remove("BloodDrinker");
    }
}
