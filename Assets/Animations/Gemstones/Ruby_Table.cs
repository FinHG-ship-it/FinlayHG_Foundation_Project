using UnityEngine;

public class Ruby_Table : MonoBehaviour

{
    public GameObject Table;
    //Animator animator;
    public Animator Ruby_Pickup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //animator = GetComponent<Animator>(); //This Asigns animator to the ANIMATOR
    }

    void OnMouseDown()
    {
        Ruby_Pickup.SetBool("TableClicked", true); // goes into ANIMATOR, and sets the bool "TableClicked" to true
        Debug.Log("Clicked"); 
        

    }
}