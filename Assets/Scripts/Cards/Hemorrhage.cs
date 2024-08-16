using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hemorrhage : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterBleed += 4;

        playerData.discardPile.Add("Hemorrhage");
        playerData.handCards.Remove("Hemorrhage");
    }
}
