using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopEvent : MonoBehaviour
{
    public Mainview Mainview;
    public BattleInfo BattleInfo;
    public TMP_Text Gold;
    // Start is called before the first frame update
    void Awake()
    {
        Mainview = FindObjectOfType<Mainview>();
        BattleInfo = FindObjectOfType<BattleInfo>();
    }
    private void Update()
    {
        Gold.text = BattleInfo.playerGold.ToString();
    }
    public void IgnoreButton()
    {
        Mainview.IgnoreShop();
    }
    public void Card1()
    {
        Mainview.TakeCard1();
    }
    public void Card2()
    {
        Mainview.TakeCard2();
    }
    public void Card3()
    {
        Mainview.TakeCard3();
    }
}
