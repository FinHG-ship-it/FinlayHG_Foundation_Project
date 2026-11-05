using UnityEngine;

public class Ruby_Gone : MonoBehaviour
{    

public GameObject Ruby1;
public GameObject Ruby2;
public bool isClicked = false;
public bool obtained = false;

    // Update is called once per frame
    void Update()
    {
        if (isClicked == true)
        {
        Ruby1.SetActive(false);
        Ruby2.SetActive(false); // this disables the ruby after the animation finishes.
        }
        if(obtained == true)
        {
        Ruby1.SetActive(false);
        Ruby2.SetActive(false);
        }
    }

}
