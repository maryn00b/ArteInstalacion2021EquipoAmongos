using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Panel2 : MonoBehaviour
{

    public GameObject panel1;
    // Update is called once per frame
    void Update()
    {
        if (Panels.jugadorCerca && !panel1.active)
        {
            panel1.SetActive(true);
        }
    }
}