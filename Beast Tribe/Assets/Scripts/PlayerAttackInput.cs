using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour
{


    private CharacterAnimations playerAnimation;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimation = GetComponent<CharacterAnimations>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {

            playerAnimation.Defend(true);

        }
        if (Input.GetKey(KeyCode.T))
        {

            playerAnimation.Defend(false);

        }

        if (Input.GetKey(KeyCode.V))
        {

            playerAnimation.Jump(true);

        }
        else
        {
            playerAnimation.Jump(false);
        }
      


        if (Input.GetKey(KeyCode.F))
        {
            if (Random.Range(0, 2) > 0)
            {
                playerAnimation.Attack_1();
            }
            else
            {
                playerAnimation.Attack_2();

            }
        }


        // Testing: these are working animation in case the enemy ai hit or kill player

        if (Input.GetKey(KeyCode.G))
        {

            playerAnimation.Hit(true);

        }

        if (Input.GetKey(KeyCode.H))
        {

            playerAnimation.Die(true);

        }


    }
}
