using UnityEngine;
//This script is to destroy a game object using the space bar.
public class PushSpaceToDestroy : MonoBehaviour
{
   
    public GameObject gameObjectToDestroy;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Destroy(gameObject);
            //Destroy(this); //This distroys the script attached to the game object
            //Destroy(this.gameObject);

            Destroy(gameObjectToDestroy);//This destroys the game object that we have referenced in the inspector.
        }
    }
}
