using UnityEngine;

public class MoveBookshelf : MonoBehaviour
{
    

    // Update is called once per frame
  void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            transform.Translate(0,2,0);
            Debug.Log("Bookshelf Moved");
        }
    }
}   
    
