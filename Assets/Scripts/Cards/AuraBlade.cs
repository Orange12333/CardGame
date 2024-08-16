using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AuraBlade : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;
    private int dmg;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        dmg = (int)(20+playerData.playerStr - playerData.playerWeak);
        monster.hp -= dmg;
        playerData.playerHp -= 10;

        playerData.discardPile.Add("AuraBlade");
        playerData.handCards.Remove("AuraBlade");
    }
}
