using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcaneBlast : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.hp -= 6;

        playerData.discardPile.Add("ArcaneBlast");
        playerData.handCards.Remove("ArcaneBlast");
    }
}
