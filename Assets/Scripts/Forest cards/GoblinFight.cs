using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoblinFight : MonoBehaviour
{
    public BattleInfo Enemy;
    public PlayerData playerData;
    public Mainview Mainview;

    public void Start()
    {
        Enemy = FindObjectOfType<BattleInfo>();
        playerData = FindObjectOfType<PlayerData>();
        Mainview = FindObjectOfType<Mainview>();
    }

    public void OnClick()
    {
        Enemy.enemy = "Goblin";
        Enemy.battle = 1;
        playerData.turn = 0;
        Mainview.cardsDrawn = 0;
        SceneManager.LoadScene("Battle");
    }
}
