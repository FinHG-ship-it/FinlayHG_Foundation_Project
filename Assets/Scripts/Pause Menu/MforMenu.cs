using UnityEngine;

public class MforMenu : MonoBehaviour
{

    public GameObject menu;
    // Update is called once per frame
  void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            menu.SetActive(true);
            Debug.Log("M key pressed");
        }
    }
}
