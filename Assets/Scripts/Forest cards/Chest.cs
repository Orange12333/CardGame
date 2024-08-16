using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Mainview Mainview;
    public OneCardEvents OneCardEvents;

    public void Start()
    {
        Mainview = FindObjectOfType<Mainview>();
        OneCardEvents = FindObjectOfType<OneCardEvents>();
    }
    public void OnClick()
    {
        Mainview.ChestEvent();
    }
}
