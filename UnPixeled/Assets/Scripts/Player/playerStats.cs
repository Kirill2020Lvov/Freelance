using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Rendering;

public class playerStats : MonoBehaviour
{
    GameObject player;
    GUIManager GUI;
    public TextMesh damageText;

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
            showFloatingText(ammount);
            health -= ammount;
        }
    }

    void showFloatingText(float damage)
    {
        var go = Instantiate(damageText, new Vector3(transform.position.x + Random.Range(0, 5), transform.position.y + Random.Range(0, 5), transform.position.z + Random.Range(0, 5)), Quaternion.Euler(60, 45, 0));
        go.GetComponent<TextMesh>().color = Color.red;
        go.GetComponent<TextMesh>().text = damage.ToString();
    }
}
