using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public float contadorTiempo = 0;
    public GameObject anuncioFrappe;
    public GameObject anuncioEscuela;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            contadorTiempo += Time.deltaTime;
        
        

        if (contadorTiempo >= 10 && contadorTiempo <= 11)
        {
            if (!anuncioFrappe.active)
            {
               anuncioFrappe.SetActive(true);
            }
        }

        if (contadorTiempo >= 20 && contadorTiempo <= 21)
        {
            if (!anuncioEscuela.active)
            {
                anuncioEscuela.SetActive(true);
            }
        }
    }

}
