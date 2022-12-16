using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private CharacterController charController;
    private CharacterAnimations playerAnimations;
   
    // Start is called before the first frame update

    public float movement_speed = 3f;
    public float gravity = 9.8f;
    public float rotation_speed = 0.15f;
    public float rotateDps = 180f;
    void Awake()
    {
        charController = GetComponent<CharacterController>();
        playerAnimations = GetComponent<CharacterAnimations>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
        AnimateWalk();
    }

    void Move() {

       // print("Value " + Input.GetAxis("Vertical"));

        if (Input.GetAxis("Vertical") > 0)
        {

            Vector3 moveDirection = transform.forward;
            moveDirection.y -= gravity * Time.deltaTime; // difference btw each frame delta time to smooth each frame
            charController.Move(moveDirection * movement_speed * Time.deltaTime);

        }

        else if (Input.GetAxis("Vertical") < 0)
        {
            Vector3 moveDirection = -transform.forward;
            moveDirection.y -= gravity * Time.deltaTime; // difference btw each frame delta time to smooth each frame
            charController.Move(moveDirection * movement_speed * Time.deltaTime);

        }
        else
        {
            charController.Move(Vector3.zero);
        }

    }

    void Rotate()
    {
        Vector3 rotation_Direction = Vector3.zero;
        if (Input.GetAxis("Horizontal") < 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.left);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            rotation_Direction = transform.TransformDirection(Vector3.right);
        }
        if (rotation_Direction != Vector3.zero)
        {
            transform.rotation = Quaternion.RotateTowards(
           transform.rotation, Quaternion.LookRotation(rotation_Direction),
               rotateDps * Time.deltaTime);


        }


    }

    void AnimateWalk()
    {

        
        if (charController.velocity.sqrMagnitude != 0f) { 
            playerAnimations.Walk(true);
                }
   else{
            playerAnimations.Walk(false);

    }
}

    }
