using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyclopsData : MonoBehaviour
{
    public float maxHp = 100f;
    public float hp;
    public float actions = 3f;
    public float monsterArmor = 0;
    public float monsterBarrier = 0;
    public float monsterBlock = 25;
    public float monsterStr = 5;
    public float monsterWeak = 0;
    public float monsterBleed = 0;
    public float monsterBurn = 0;
    public float monsterFreez = 0;
    public float monsterReg = 3;
    public float gold = 100;
    public float exp = 100;

    private int dmg;

    public MonsterData DropArea;
    public PlayerData player;
    private void Start()
    {
        DropArea = GetComponentInParent<MonsterData>();
        player = FindObjectOfType<PlayerData>();
        monsterReg = 3;
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
        dmg = (int)((10 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        DropArea.monsterBlock = 25;
    }

    public void MonsterAction2()
    {
        dmg = (int)((10 + DropArea.monsterStr - DropArea.monsterFreez - player.playerArmor - DropArea.monsterWeak) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        DropArea.monsterBlock = 25;
    }

    public void MonsterAction3()
    {
        dmg = (int)((20 - monsterFreez - player.playerBarrier) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
    }
}
