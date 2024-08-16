using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseView : MonoBehaviour
{
    //public TMP_Text battleRewards;
    //public EndTurn EndTurn;
    public BattleInfo BattleInfo;

    private void Awake()
    {
        BattleInfo = FindObjectOfType<BattleInfo>();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void YouLost()
    {
        SceneManager.LoadScene("MainMenu");
        BattleInfo.existingRun = 0;
        BattleInfo.battle = 0;
    }
    /*
    public void Start()
    {
        EndTurn = FindObjectOfType<EndTurn>();
    }
    public void Awake()
    {
        battleRewards.text = "You Found " + EndTurn.goldGain.ToString() + " gold\nYou gain " + EndTurn.expGain.ToString() + " exp";
    }
    */
}
