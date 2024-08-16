using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinData : MonoBehaviour
{
    public float maxHp = 20f;
    public float hp;
    public float actions = 2f;
    public float monsterArmor = 0;
    public float monsterBarrier = 0;
    public float monsterBlock = 0;
    public float monsterStr = 0;
    public float monsterWeak = 0;
    public float monsterBleed = 0;
    public float monsterBurn = 0;
    public float monsterFreez = 0;
    public float monsterReg = 0;
    public float gold = 17;
    public float exp = 33;

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
        dmg = (int) ((5 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
    }

    public void MonsterAction2()
    {
        dmg = (int)((8 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
    }
}
