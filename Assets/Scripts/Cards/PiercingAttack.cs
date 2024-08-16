using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiercingAttack : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)(4 + playerData.playerStr - playerData.playerFreez - playerData.playerWeak);
        monster.hp -= dmg;

        playerData.discardPile.Add("PiercingAttack");
        playerData.handCards.Remove("PiercingAttack");
    }
}
