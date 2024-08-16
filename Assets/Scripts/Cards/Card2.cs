using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card2 : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        endTurn = FindObjectOfType<EndTurn>();
        endTurn.DrawCard();
        endTurn.DrawCard();

        playerData.discardPile.Add("Card2");
        playerData.handCards.Remove("Card2");
    }
}
