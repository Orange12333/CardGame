using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightArmor : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerArmor += 1;

        playerData.discardPile.Add("LightArmor");
        playerData.handCards.Remove("LightArmor");
    }
}
