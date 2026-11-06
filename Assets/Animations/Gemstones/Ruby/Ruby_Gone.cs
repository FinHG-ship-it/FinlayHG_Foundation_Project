using UnityEngine;

public class Ruby_Gone : MonoBehaviour
{    

public GameObject Base;
public GameObject Crystals;
public bool isClicked = false;
public bool obtained = false;

    // Update is called once per frame
    void Update()
    {
        if (isClicked == true)
        {
        Base.SetActive(false);
        Crystals.SetActive(false); //
        }
        if(obtained == true)
        {
        Base.SetActive(false);
        Crystals.SetActive(false);
        }
    }

}
