using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public playerController player;
    public GUIManager GUI;



    #region Singleton

    public static GameManager instance;

void Awake ()
  {
      if (instance == null) 
      {
          instance = this;
      } else if (instance != this) 
      {
          Destroy(gameObject);
          return;
      }
  
      DontDestroyOnLoad(gameObject);

        player = FindObjectOfType<playerController>();
        GUI = FindObjectOfType<GUIManager>();
  }

    #endregion


    
}
