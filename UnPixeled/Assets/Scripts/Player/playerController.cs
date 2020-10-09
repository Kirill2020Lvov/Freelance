using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class playerController : MonoBehaviour
{
    //switchers
    bool enableInput; //enables player inputs

    //Player
    [SerializeField] public float playerSpeed;
    public GameObject playerModel;

    //Players weapon
    public GameObject weaponCollider;
    BoxCollider attackCollider;

    //Player animation
    Animator playerAnim;
    CharacterController charController;



    private void Start()
    {
        //initialize input
        enableInput = true;

        //initalize player's weapon
        attackCollider = weaponCollider.GetComponent<BoxCollider>();
        attackCollider.enabled = true;

        //initialize components
        charController = GetComponent<CharacterController>();

        //initialize player model
        playerAnim = playerModel.GetComponent<Animator>();
    }



    void Update()
    {
        //inputs
        if (enableInput == true)
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


            //AttackAnimation
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                attackCollider.enabled = true;
                playerAnim.SetInteger("attack", 1);
            }

            else if (Input.GetAxis("Fire1") == 0)
            {
                attackCollider.enabled = false;
            }

            else
            {
                playerAnim.SetInteger("attack", 0);
            }
        }
    }

    public void characterDeath (bool switchBool)
    {
        enableInput = switchBool;
        playerModel.SetActive(false);
    }
}
