using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Scores : MonoBehaviour
{
    public TMP_Text YourScores;
    public BattleInfo BattleInfo;

    private void Awake()
    {
        BattleInfo = FindObjectOfType<BattleInfo>();
    }

    void Update()
    {
        YourScores.text = "Your score: " + BattleInfo.score + "\nYour best score: " + BattleInfo.bestscore;
    }
}
