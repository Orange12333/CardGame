using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frostbite : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterFreez += 3;

        playerData.discardPile.Add("Frostbite");
        playerData.handCards.Remove("Frostbite");
    }
}
