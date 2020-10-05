using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] public float playerSpeed;
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
        Vector3 Movement;
        transform.Translate(moveX * playerSpeed * Time.deltaTime, playerRB.velocity.y * Time.deltaTime, moveZ * playerSpeed * Time.deltaTime);
    }
}
