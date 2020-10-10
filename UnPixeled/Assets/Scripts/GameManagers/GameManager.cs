using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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
  }

    #endregion

    public GameObject player ;
    public GameObject GUI;
}
