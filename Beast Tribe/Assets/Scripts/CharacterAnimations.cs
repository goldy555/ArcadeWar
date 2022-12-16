using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{

    private Animator anim;
    


    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
    }

   public void Walk (bool walk)
    {

        anim.SetBool("Walk", walk);

    }

    public void Jump(bool jump)
    {

        anim.SetBool("Jump", jump);

    }
    public void Defend(bool defend)
    {

        anim.SetBool("Defend", defend);

    }


    public void Hit(bool hit)
    {

        anim.SetBool("Hit", hit);

    }
    public void Die (bool die)
    {


        anim.SetBool("Die", die);
    }
    public void Run(bool run)
    {


        anim.SetBool("Run", run);
    }


    public void Attack_1()
    {


        anim.SetTrigger("Attack1");
    }
    public void Attack_2()
    {


        anim.SetTrigger("Attack2");
    }
}
