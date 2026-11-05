using UnityEngine;

public class Ruby_Pickup : MonoBehaviour
{
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>(); //This Asigns animator to the ANIMATOR
    }

    void OnMouseDown()
    {
        animator.SetTrigger("IsClicked 0"); // goes into ANIMATOR, and sets the bool "IsClicked" to true
        //        animator.SetTrigger("IsClicked"); 



    }
}