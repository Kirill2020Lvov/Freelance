using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] public float playerSpeed = 5;
    Rigidbody playerRB;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        playerRB.velocity = new Vector3 (moveX, playerRB.velocity.y, moveZ) * playerSpeed * Time.deltaTime;
    }
}
