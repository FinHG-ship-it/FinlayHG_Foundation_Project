using UnityEngine;

public class MenuFloorClipingFix : MonoBehaviour
{


    void Update()
    {
         if (Input.GetKeyDown(KeyCode.M))
        {
            transform.Translate(0,10,0);
            Debug.Log("M Key Pressed");
        }
    }
}
