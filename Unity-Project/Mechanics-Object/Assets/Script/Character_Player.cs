using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Player : MonoBehaviour
{
    private CharacterController controller;
    private float speedMove = 2f;
    private float life = 100;


    void Start()
    {

    }

    void Update()
    {
        ControllerMovementPlayer();
        ControllerRestoreHealth();
        ControllerDamage();        
    }

    void ControllerMovementPlayer()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = transform.right * x + transform.forward * z;
        controller.Move(direction * speedMove * Time.deltaTime);
    }
    void ControllerDamage()
    {
        if (Input.GetKey(KeyCode.S))
        {
            life-= Time.deltaTime;
            Debug.Log("Mi vida esta bajando");
        }
    }
    void ControllerRestoreHealth()
    {
        if (Input.GetKey(KeyCode.W))
        {
            life+= Time.deltaTime;
            Debug.Log("Mi vida esta subiendo");
        }
    }
}
