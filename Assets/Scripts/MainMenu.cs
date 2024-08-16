using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public BattleInfo BattleInfo;
    public GameObject Continue;
    public void Start()
    {
        BattleInfo = FindObjectOfType<BattleInfo>();
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("CharacterSelection");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ContinueGame()
    {
        if (BattleInfo.battle==1)
        {
            SceneManager.LoadScene("Battle");
        }
        else
        {
            SceneManager.LoadScene("MainView");
        }
    }
    public void Update()
    {
        if (BattleInfo.existingRun == 0)
        {
            Continue.SetActive(false);
        }
        else
        {
            Continue.SetActive(true);
        }
    }
}
