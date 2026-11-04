using UnityEngine;

public class ObjectPickup : MonoBehaviour

{
    public GameObject ObjectToPickup;
    // Update is called once per frame
    void OnMouseDown()
    
    {
        Debug.Log("Clicked");  //Destroy(gameObject);
            //Destroy(this); //This distroys the script attached to the game object
            //Destroy(this.gameObject);

         ObjectToPickup.SetActive(false);//This destroys the game object that we have referenced in the inspector.
    }

}
