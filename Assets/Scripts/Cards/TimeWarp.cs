using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeWarp : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        endTurn = FindObjectOfType<EndTurn>();
        endTurn.DrawCard();
        endTurn.DrawCard();
        endTurn.DrawCard();
        playerData.playerHp -= 3;

        playerData.discardPile.Add("TimeWarp");
        playerData.handCards.Remove("TimeWarp");
    }
}
