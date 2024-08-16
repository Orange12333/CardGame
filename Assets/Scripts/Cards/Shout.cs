using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shout : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterWeak += 2;

        playerData.handCards.Remove("Shout");
    }
}
