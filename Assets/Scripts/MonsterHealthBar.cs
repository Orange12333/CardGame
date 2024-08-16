using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonsterHealthBar : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    public float MaxHealth;
    public MonsterData MonsterStats;

    public TMP_Text armor;
    public TMP_Text barrier;
    public TMP_Text block;
    public TMP_Text strength;
    public TMP_Text weak;
    public TMP_Text regeneration;
    public TMP_Text bleed;
    public TMP_Text burn;
    public TMP_Text freeze;

    public TMP_Text monsterHpIndicator;

    void Start()
    {
        HealthBar = GetComponent<Image>();
        MonsterStats = FindObjectOfType<MonsterData>();
    }

    void Update()
    {
        MaxHealth = MonsterStats.maxHp;
        CurrentHealth = MonsterStats.hp;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
        monsterHpIndicator.SetText($"{CurrentHealth}/{MaxHealth}");
        armor.text = MonsterStats.monsterArmor.ToString();
        barrier.text = MonsterStats.monsterBarrier.ToString();
        block.text = MonsterStats.monsterBlock.ToString();
        strength.text = MonsterStats.monsterStr.ToString();
        weak.text = MonsterStats.monsterWeak.ToString();
        regeneration.text = MonsterStats.monsterReg.ToString();
        bleed.text = MonsterStats.monsterBleed.ToString();
        burn.text = MonsterStats.monsterBurn.ToString();
        freeze.text = MonsterStats.monsterFreez.ToString();
    }
}
