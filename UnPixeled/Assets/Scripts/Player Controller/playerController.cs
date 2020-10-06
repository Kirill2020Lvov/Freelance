using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class playerController : MonoBehaviour
{
    [SerializeField] public float playerSpeed;
    public GameObject playerModel;
    Animator playerAnim;
    public CharacterController charController;

    private void Start()
    {
        //initialize components
        charController = GetComponent<CharacterController>();

        //initialize player model
        playerAnim = playerModel.GetComponent<Animator>();
    }

    void Update()
    {
        //WASD Movement_________________________________________________________________________________________________________
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * moveX + transform.forward * moveZ;
        movement = movement.normalized * Time.deltaTime;

        charController.Move(movement * playerSpeed);

        //Animation_____________________________________________________________________________________________________________
        if (moveX != 0 || moveZ != 0)
        {
            playerAnim.SetInteger("condition", 1);
            float angle = Mathf.Atan2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * Mathf.Rad2Deg;
            playerModel.transform.rotation = Quaternion.Euler(new Vector3(0, angle + 45, 0));
        }
        else
        {
            playerAnim.SetInteger("condition", 0);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            playerAnim.SetInteger("attack", 1);
        }
        else
        {
            playerAnim.SetInteger("attack", 0);
        }
    }
}
