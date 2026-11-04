using UnityEngine;

public class ClickAnim : MonoBehaviour
{
   Animator animator; // Sets animator as a variable with the data type ANIMATOR
    // This script is to trigger an animation on the object the script is attached to.
    void Start()
    {
        animator = GetComponent<Animator>(); //This Asigns animator to the ANIMATOR
    }

    void OnMouseDown()
    {
        animator.SetBool("IsClicked", true); // goes into ANIMATOR, and sets the bool "IsClicked" to true


    }

}
