using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoltenArmor : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.monsterArmor = 0;

        playerData.discardPile.Add("MoltenArmor");
        playerData.handCards.Remove("MoltenArmor");
    }
}
