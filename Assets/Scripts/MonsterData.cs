using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;

public class MonsterData : MonoBehaviour
{
    public float alive;
    public float maxHp;
    public float hp;
    public float action;
    public float actions;
    public float monsterArmor;
    public float monsterBarrier;
    public float monsterBlock;
    public float monsterStr;
    public float monsterWeak;
    public float monsterBleed;
    public float monsterBurn;
    public float monsterFreez;
    public float monsterReg;
    public float gold;
    public float exp;
    public BattleInfo Enemy;
    public GameObject DropArea;
    public GameObject Goblin;
    public GameObject Orc;
    public GameObject EarthElemental;
    public GameObject Cyclops;
    public GameObject EliteOrc;
    public GameObject Somebody;
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject CardsArea;
    public PlayerData player;
    public TMP_Text label;

    public EndTurn endTurn;


    private void Start()
    {
        player = FindObjectOfType<PlayerData>();
        Enemy = FindObjectOfType<BattleInfo>();
        endTurn = FindObjectOfType<EndTurn>();
        GameObject monsterName = Resources.FindObjectsOfTypeAll<GameObject>().ToList().FirstOrDefault(x => x.name == Enemy.enemy);
        GameObject monster = Instantiate(monsterName, new Vector3(0, 0, 0), Quaternion.identity);
        monster.transform.SetParent(DropArea.transform, false);
        action = 1;
        alive = 1;
    }

    public void Update()
    {
        if (hp>maxHp)
        {
            hp = maxHp;
        }
    }

    public void MonsterAttack()
    {
        if (action > actions)
        {
            MonsterBeforeEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
            else
            {
                BroadcastMessage("MonsterAction1");
                action = 2;
            }
            MonsterAfterEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
        }
        else if (action == 1)
        {
            MonsterBeforeEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
            else
            {
                BroadcastMessage("MonsterAction1");
                action += 1;
            }
            MonsterAfterEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
        }
        else if(action == 2)
        {
            MonsterBeforeEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
            else
            {
                BroadcastMessage("MonsterAction2");
                action += 1;
            }
            MonsterAfterEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
        }
        else if (action == 3)
        {
            MonsterBeforeEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
            else
            {
                BroadcastMessage("MonsterAction3");
                action += 1;
            }
            MonsterAfterEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
        }
        else if (action == 4)
        {
            MonsterBeforeEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
            else
            {
                BroadcastMessage("MonsterAction4");
                action += 1;
            }
            MonsterAfterEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
        }
        else if (action == 5)
        {
            MonsterBeforeEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
            else
            {
                BroadcastMessage("MonsterAction5");
                action += 1;
            }
            MonsterAfterEffects();
            if (hp <= 0 && alive == 1)
            {
                endTurn.YouWinBattle();
                alive = 0;
            }
        }
    }
    public void MonsterBeforeEffects()
    {
        monsterBlock = 0;
        if (monsterStr > 0)
        {
            monsterStr -= 1;
        }
        hp -= monsterBurn;
        if (monsterBurn > 0)
        {
            monsterBurn -= 1;
        }
        hp += monsterReg;
        if(hp > maxHp)
        {
            hp = maxHp;
        }
    }
    public void MonsterAfterEffects()
    {
        if (monsterWeak > 0)
        {
            monsterWeak -= 1;
        }
        hp -= monsterBleed;
        if (monsterBleed > 0)
        {
            monsterBleed -= 1;
        }
        monsterFreez = 0;
    }
}
