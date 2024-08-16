using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireNova : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterBurn += 4;
        playerData.playerBurn += 4;

        playerData.discardPile.Add("FireNova");
        playerData.handCards.Remove("FireNova");
    }
}
