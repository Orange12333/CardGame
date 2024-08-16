using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingPotion : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerHp += 5;
        if (playerData.playerHp > playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }

        playerData.handCards.Remove("HealingPotion");
    }
}
