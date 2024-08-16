using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionOfStrength : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerStr += 4;

        playerData.handCards.Remove("PotionOfStrength");
    }
}
