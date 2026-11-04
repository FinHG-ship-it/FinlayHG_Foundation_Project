using UnityEngine;

public class PauseMenuNEW : MonoBehaviour
{
    public GameObject Player;
    public GameObject Crosshair;
    public GameObject Menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("M key pressed");
            //if (Time.timeScale == 1)
            //{
            Time.timeScale = 0;
            Debug.Log("Game Paused");
    
            Player.SetActive(false);
            Crosshair.SetActive(false);
            Menu.SetActive(true);
            Cursor.lockState = CursorLockMode.None; //Unity Documentation - https://docs.unity3d.com/ScriptReference/CursorLockMode.Locked.html
           // }


        }        

    }
    



}