using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SettingsArea : MonoBehaviour
{
    public BattleInfo BattleInfo;
    public TMP_Text gold;
    public TMP_Text ClassAndLvl;

    private void Start()
    {
        BattleInfo = FindObjectOfType<BattleInfo>();
    }
    void Update()
    {
        gold.text = BattleInfo.playerGold.ToString();
        ClassAndLvl.text = BattleInfo.playerClass + " lvl " + BattleInfo.playerLvl;
    }
}
