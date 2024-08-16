using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthElementalData : MonoBehaviour
{
    public float maxHp = 30f;
    public float hp;
    public float actions = 4f;
    public float monsterArmor = 1;
    public float monsterBarrier = 1;
    public float monsterBlock = 0;
    public float monsterStr = 0;
    public float monsterWeak = 0;
    public float monsterBleed = 0;
    public float monsterBurn = 0;
    public float monsterFreez = 0;
    public float monsterReg = 0;
    public float gold = 30;
    public float exp = 20;

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
        dmg = (int)((4 - monsterFreez - player.playerBarrier) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        DropArea.monsterBlock = 25;
    }

    public void MonsterAction2()
    {
        dmg = (int)((4 - monsterFreez - player.playerBarrier) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        DropArea.monsterBlock = 50;
    }

    public void MonsterAction3()
    {
        dmg = (int)((2 - monsterFreez - player.playerBarrier) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        DropArea.monsterBlock = 75;
        player.playerBleed += 3;
    }

    public void MonsterAction4()
    {
        DropArea.hp += 10;
        DropArea.monsterBlock = 25;
    }
}
