using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyShield : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        if (playerData.playerBlock < 50)
        {
            playerData.playerBlock = 50;
        }

        playerData.discardPile.Add("HeavyShield");
        playerData.handCards.Remove("HeavyShield");
    }
}
