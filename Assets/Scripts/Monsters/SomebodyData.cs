using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomebodyData : MonoBehaviour
{
    public float maxHp = 1000000;
    public float hp;
    public float actions = 3;
    public float monsterArmor = 0;
    public float monsterBarrier = 0;
    public float monsterBlock = 0;
    public float monsterStr = 0;
    public float monsterWeak = 0;
    public float monsterBleed = 0;
    public float monsterBurn = 0;
    public float monsterFreez = 0;
    public float monsterReg = 0;
    public float gold = 100;
    public float exp = 100;
    public int overwhelm;

    private int dmg;

    public MonsterData DropArea;
    public PlayerData player;
    public BattleInfo BattleInfo;
    private void Start()
    {
        DropArea = GetComponentInParent<MonsterData>();
        player = FindObjectOfType<PlayerData>();
        BattleInfo = FindObjectOfType<BattleInfo>();
        maxHp = 1000000;
        actions = 3;
        monsterArmor = 0;
        monsterBarrier = 0;
        monsterBlock = 0;
        monsterStr = 0;
        monsterWeak = 0;
        monsterBleed = 0;
        monsterBurn = 0;
        monsterFreez = 0;
        monsterReg = 0;
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
        overwhelm = 0;
    }

    public void MonsterAction1()
    {
        dmg = (int)((20 - monsterFreez - player.playerBarrier) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        player.playerBurn += 5 + overwhelm;
        player.playerFreez += 5 + overwhelm;
        BattleInfo.score += (int)DropArea.maxHp - (int)DropArea.hp;
    }

    public void MonsterAction2()
    {
        dmg = (int)((20 - monsterFreez - player.playerBarrier) * (100 - player.playerBlock) / 100);
        player.playerHp -= dmg;
        player.playerBurn += 5 + overwhelm;
        player.playerFreez += 5 + overwhelm;
        BattleInfo.score += (int)DropArea.maxHp - (int)DropArea.hp;
    }

    public void MonsterAction3()
    {
        player.playerHp -= player.playerBurn + player.playerFreez;
        BattleInfo.score += (int)DropArea.maxHp - (int)DropArea.hp;
        overwhelm += 5;
    }
}
