using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcData : MonoBehaviour
{
    public float maxHp = 40f;
    public float hp;
    public float actions = 4f;
    public float monsterArmor = 1;
    public float monsterBarrier = 0;
    public float monsterBlock = 0;
    public float monsterStr = 3;
    public float monsterWeak = 0;
    public float monsterBleed = 2;
    public float monsterBurn = 0;
    public float monsterFreez = 0;
    public float monsterReg = 0;
    public float gold = 10;
    public float exp = 40;

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
    }

    public void MonsterAction2()
    {
        dmg = (int)((1 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        player.playerWeak += 2;
    }

    public void MonsterAction3()
    {
        dmg = (int)((1 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        DropArea.monsterBlock = 50;
    }
    public void MonsterAction4()
    {
        dmg = (int)((15 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        DropArea.monsterWeak += 5;
    }
}
