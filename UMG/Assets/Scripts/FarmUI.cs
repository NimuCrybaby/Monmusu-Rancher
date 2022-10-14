using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmUI : MonoBehaviour
{
    public GameObject MilkFactoryPanel;
    public GameObject WoolFactoryPanel;

    public void OpenMilkFactory(){
        MilkFactoryPanel.SetActive(true);
        WoolFactoryPanel.SetActive(false);
    }

    public void OpenWoolFactory(){
        WoolFactoryPanel.SetActive(true);
        MilkFactoryPanel.SetActive(false);
    }
}
