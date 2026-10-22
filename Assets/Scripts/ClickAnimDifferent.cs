using UnityEngine;

public class ClickAnimDifferent : MonoBehaviour
{
   Animator ani; // Sets animator as a variable with the data type ANIMATOR
    // This script is to trigger an animation on the object the script is attached to.
    void Start()
    {
        ani = GetComponent<Animator>(); //This Asigns animator to the ANIMATOR
    }

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Y)) // If the Y key is pressed down
        {
        ani.SetBool("IsClicked", true); // goes into ANIMATOR, and sets the bool "IsClicked" to true

    
        }
    }  
}

// I made this script because I was having issues clicking on the Bookcase.