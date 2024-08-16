using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plan : MonoBehaviour
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

        playerData.discardPile.Add("Plan");
        playerData.handCards.Remove("Plan");
    }
}
