using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliteOrcData : MonoBehaviour
{
    public float maxHp = 60f;
    public float hp;
    public float actions = 4f;
    public float monsterArmor = 0;
    public float monsterBarrier = 0;
    public float monsterBlock = 25;
    public float monsterStr = 5;
    public float monsterWeak = 0;
    public float monsterBleed = 0;
    public float monsterBurn = 0;
    public float monsterFreez = 0;
    public float monsterReg = 0;
    public float gold = 40;
    public float exp = 60;

    private int dmg;

    public MonsterData DropArea;
    public PlayerData player;
    private void Start()
    {
        DropArea = GetComponentInParent<MonsterData>();
        player = FindObjectOfType<PlayerData>();
        DropArea.maxHp = maxHp;
        DropArea.hp = maxHp;
        DropArea.actions = actions;
        DropArea.gold = gold;
        DropArea.exp = exp;
        DropArea.monsterArmor = monsterArmor;
        DropArea.monsterBarrier = monsterBarrier;
        DropArea.monsterBlock = monsterBlock;
        DropArea.monsterStr = monsterStr;
        DropArea.monsterWeak = monsterWeak;
        DropArea.monsterBleed = monsterBleed;
        DropArea.monsterBurn = monsterBurn;
        DropArea.monsterFreez = monsterFreez;
        DropArea.monsterReg = monsterReg;
    }

    public void MonsterAction1()
    {
        dmg = (int)((5 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        player.playerBleed += 2;
        DropArea.hp += player.playerBleed;
    }

    public void MonsterAction2()
    {
        dmg = (int)((5 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        player.playerBleed += 3;
        DropArea.hp += player.playerBleed;
    }

    public void MonsterAction3()
    {
        dmg = (int)((5 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        player.playerBleed += 4;
        DropArea.hp += player.playerBleed;
    }
    public void MonsterAction4()
    {
        player.playerHp -= player.playerBleed;
        DropArea.hp += player.playerBleed;
        player.playerWeak += 2;
    }
}
