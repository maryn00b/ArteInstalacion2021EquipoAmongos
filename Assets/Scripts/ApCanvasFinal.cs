using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApCanvasFinal : MonoBehaviour
{
    
    
    public float contadorTiempo = 0;

    public GameObject donacionesRecibidas;
    public GameObject ayuda;
    public GameObject foto;
    bool aparecer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorTiempo += Time.deltaTime;
        


       
        
        if (contadorTiempo >= 3 && contadorTiempo <= 4)
        {
           
            aparecer = true;
        }

        if (aparecer)
        {
            if (!donacionesRecibidas.active)
            {
                donacionesRecibidas.SetActive(true);

            }
            if (!ayuda.active)
            {
                ayuda.SetActive(true);

            }
            if (!foto.active)
            {
                foto.SetActive(true);

            }
        }
    }
}
