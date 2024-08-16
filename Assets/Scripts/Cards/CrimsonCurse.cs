using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrimsonCurse : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.hp -= monster.monsterBleed;

        playerData.discardPile.Add("CrimsonCurse");
        playerData.handCards.Remove("CrimsonCurse");
    }
}
