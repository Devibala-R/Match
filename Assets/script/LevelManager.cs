using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int LevelCount;
    private int i = 0;

    public GameObject[] go;
    public static void NextsceneCall()
    {
       go[i].SetActive(false);
      
        i++;
       go[i].SetActive(true);
       
    }
  
}
