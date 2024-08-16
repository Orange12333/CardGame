using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyArmor : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerArmor += 2;

        playerData.discardPile.Add("HeavyArmor");
        playerData.handCards.Remove("HeavyArmor");
    }
}
