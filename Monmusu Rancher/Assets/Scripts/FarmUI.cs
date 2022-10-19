using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmUI : MonoBehaviour
{
    public GameObject MilkFactoryPanel;
    public GameObject WoolFactoryPanel;
    public GameObject DefaultPanel;
    public GameObject CowInventoryPanel;

    public void OpenMilkFactory(){
        MilkFactoryPanel.SetActive(true);
        WoolFactoryPanel.SetActive(false);
        DefaultPanel.SetActive(false);
    }

    public void OpenWoolFactory(){
        WoolFactoryPanel.SetActive(true);
        MilkFactoryPanel.SetActive(false);
        DefaultPanel.SetActive(false);
    }

    public void CloseMilkFactory(){
        MilkFactoryPanel.SetActive(false);
        DefaultPanel.SetActive(true);
    }
    public void CloseWoolFactory(){
        WoolFactoryPanel.SetActive(false);
        DefaultPanel.SetActive(true);
    }
    public void OpenCowInventoryPanel(){
        CowInventoryPanel.SetActive(true);
    }
    public void CloseCowInventoryPanel(){
        CowInventoryPanel.SetActive(false);
    }
}
