using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panels2 : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelEnojado;
    public static bool panelUltimo = false;
    public static bool cerrarPanel = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (InteraccionesRobot.walk)
        {
            panel.SetActive(false);
        }
        if (panelUltimo)
        {
            panelEnojado.SetActive(true);
        }
        if (cerrarPanel)
        {
            panelEnojado.SetActive(false);
        }
    }
}
