using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aura : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerReg += 1;

        playerData.discardPile.Add("Aura");
        playerData.handCards.Remove("Aura");
    }
}
