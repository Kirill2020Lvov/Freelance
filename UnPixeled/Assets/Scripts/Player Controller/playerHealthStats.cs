using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealthStats : MonoBehaviour
{
    public float health;
    public float energy;

    void Start()
    {
        health = 100;
        energy = 100;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            healtHit(50);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }

    void healtHit (float ammount)
    {
        health -= ammount;
    }
}
