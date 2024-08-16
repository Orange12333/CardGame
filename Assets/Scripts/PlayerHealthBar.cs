using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealthBar : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    public float MaxHealth;
    public PlayerData Player;
    public BattleInfo BattleInfo;

    public TMP_Text armor;
    public TMP_Text barrier;
    public TMP_Text block; 
    public TMP_Text strength;
    public TMP_Text weak;
    public TMP_Text regeneration;
    public TMP_Text bleed;
    public TMP_Text burn;
    public TMP_Text freeze;

    public TMP_Text playerHpIndicator;
    
    private void Start()
    {
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerData>();
        BattleInfo = FindObjectOfType<BattleInfo>();
    }

    private void Update()
    {
        CurrentHealth = Player.playerHp;
        MaxHealth = Player.playerMaxHp;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
        playerHpIndicator.SetText($"{CurrentHealth}/{MaxHealth}");

        if (BattleInfo.battle == 0)
        {
            armor.text = BattleInfo.playerArmor.ToString();
            barrier.text = BattleInfo.playerBarrier.ToString();
            block.text = BattleInfo.playerBlock.ToString();
            strength.text = BattleInfo.playerStr.ToString();
            weak.text = BattleInfo.playerWeak.ToString();
            regeneration.text = BattleInfo.playerReg.ToString();
            bleed.text = BattleInfo.playerBleed.ToString();
            burn.text = BattleInfo.playerBurn.ToString();
            freeze.text = BattleInfo.playerFreez.ToString();
        }
        else
        {
            armor.text = Player.playerArmor.ToString();
            barrier.text = Player.playerBarrier.ToString();
            block.text = Player.playerBlock.ToString();
            strength.text = Player.playerStr.ToString();
            weak.text = Player.playerWeak.ToString();
            regeneration.text = Player.playerReg.ToString();
            bleed.text = Player.playerBleed.ToString();
            burn.text = Player.playerBurn.ToString();
            freeze.text = Player.playerFreez.ToString();
        }
    }
}
