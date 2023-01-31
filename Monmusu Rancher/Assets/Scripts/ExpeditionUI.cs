using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExpeditionUI : MonoBehaviour
{
    public GameObject PlainsPanel;
    public GameObject ForestPanel;

    public void OpenPlainsMenu(){
        PlainsPanel.SetActive(true);
        ForestPanel.SetActive(false);
    }

    public void OpenForestMenu(){
        ForestPanel.SetActive(true);
        PlainsPanel.SetActive(false);
    }

    public void CloseplainsMenu(){
        PlainsPanel.SetActive(false);
    }

    public void CloseForestMenu(){
        ForestPanel.SetActive(false);
    }
}
