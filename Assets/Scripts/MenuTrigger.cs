using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTrigger : MonoBehaviour
{
    public bool isMenuActive = false;
    public GameObject menu;
    public void activarMenu()
    {
        if (isMenuActive == true)
        {
            menu.SetActive(false);
            isMenuActive = false;
        }
        else
        {
            menu.SetActive(true);
            isMenuActive = true;
        }
    }
}
