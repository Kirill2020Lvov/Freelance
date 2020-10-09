using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using UnityEngine;

public class playerStats : MonoBehaviour
{
    GameObject player;
    GUIManager GUI;

    public float health = 100;
    public float expirience = 0;
    public float energy = 100;

    private void Awake()
    {
        GUI = GameManager.instance.GUI.GetComponent<GUIManager>();
        player = GameManager.instance.player;
    }

    // Update is called once per frame
    void Update()
    {
        GUI.HealthBar(health);
        GUI.EnergyBar(energy);
        GUI.ExpirienceBar(expirience);

        if (health < 0)
        {
            player.GetComponent<playerController>().characterDeath(false);
        }
        
    }

    public void healtHit (float ammount)
    {
        if (health > 0)
        {
            health -= ammount;
        }
    }

    
}
