using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card1 : MonoBehaviour
{
    public MonsterData monster;
    public PlayerData playerData;
    public EndTurn endTurn;

    public void CardEffect()
    {
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        monster.hp -= 1;

        playerData.discardPile.Add("Card1");
        playerData.handCards.Remove("Card1");
    }
}
/*
private int dmg;
dmg = (int)((5 + playerData.playerStr - playerData.playerFreez - monster.monsterArmor - playerData.playerWeak) * (100 - monster.monsterBlock) / 100);
monster.hp -= dmg;
dmg = (int)((4 - playerData.playerFreez - monster.monsterBarrier) * (100 - monster.monsterBlock) / 100);
monster.hp -= dmg;
 */

/*
        playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        playerData.playerHp += 3;
        if (playerData.playerHp > playerData.playerMaxHp)
        {
            playerData.playerHp = playerData.playerMaxHp;
        }

        playerData.handCards.Remove("Bandage");
 */

/*
   playerData = FindObjectOfType<PlayerData>();
        monster = FindObjectOfType<MonsterData>();
        if (playerData.playerBlock < 50)
        {
            playerData.playerBlock = 50;
        }

        playerData.discardPile.Add("HeavyShield");
        playerData.handCards.Remove("HeavyShield");
 */

/*
  endTurn = FindObjectOfType<EndTurn>();
        endTurn.DrawCard();
        endTurn.DrawCard();
 */


/*
 Monster physical attack:
private int dmg;
dmg = (int) ((5 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
player.playerHp -= dmg;
Monster magic attack:
dmg = (int)((4 - monsterFreez - player.playerBarrier) * (100 - player.playerBlock) / 100);
player.playerHp -= dmg;
 */




