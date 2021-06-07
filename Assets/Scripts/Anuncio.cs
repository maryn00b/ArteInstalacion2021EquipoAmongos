using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anuncio : MonoBehaviour
{

    public bool isMenuActive = true;
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
