using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExpBar : MonoBehaviour
{
    public BattleInfo BattleInfo;
    public PlayerData PlayerData;

    public Image Bar;
    public TMP_Text ExpAmound;
    // Start is called before the first frame update
    void Start()
    {
        BattleInfo = FindObjectOfType<BattleInfo>();
        PlayerData = FindObjectOfType<PlayerData>();
    }

    // Update is called once per frame
    void Update()
    {
        if (BattleInfo.playerLvl == 3)
        {
            ExpAmound.text = "Max Level!";
        }
        else if (BattleInfo.playerXp < 100)
        {
            Bar.fillAmount = BattleInfo.playerXp / 100f;
            ExpAmound.text = BattleInfo.playerXp + "/100 exp";
        }
        else
        {
            Bar.fillAmount = BattleInfo.playerXp / 100f;
            ExpAmound.text = "Level Up!";
        }
    }

    public void LevelUp()
    {
        if (BattleInfo.playerLvl < 3)
        {
            if (BattleInfo.playerXp >= 100)
            {
                BattleInfo.playerXp -= 100;
                BattleInfo.LevelUp();
                PlayerData.playerMaxHp = BattleInfo.playerMaxHp;
                PlayerData.playerHp = BattleInfo.playerHp;
            }
        }
    }
}
