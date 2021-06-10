using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActMenuConf : MonoBehaviour
{
    public GameObject menuDesplegable;
    public void depslegarMenu()
    {
        if (!menuDesplegable.active)
        {
            menuDesplegable.SetActive(true);
        }
        else if (menuDesplegable.active)
        {
            menuDesplegable.SetActive(false);
        }
    }
}
