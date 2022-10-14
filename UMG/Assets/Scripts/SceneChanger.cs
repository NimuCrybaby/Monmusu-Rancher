using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void SceneFarm(){
        SceneManager.LoadScene("Farm");
    }

     public void SceneTown(){
        SceneManager.LoadScene("Town");
    }

     public void SceneWilderness(){
        SceneManager.LoadScene("Wilderness");
    }

    public void SceneMap(){
        SceneManager.LoadScene("Map");
    }
}
