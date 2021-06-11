using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public float contadorTiempo = 0;

    public GameObject anuncioFrappe;
    public GameObject anuncioEscuela;
    public GameObject anuncioDamnificados;
    public GameObject anuncioIndigenas;
    public GameObject anuncioVoluntariado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
            contadorTiempo += Time.deltaTime;
        
        

        if (contadorTiempo >= 30 && contadorTiempo <= 31)
        {
            if (!anuncioFrappe.active)
            {
               anuncioFrappe.SetActive(true);
            }
        }

        if (contadorTiempo >= 50 && contadorTiempo <= 51)
        {
            if (!anuncioEscuela.active)
            {
                anuncioEscuela.SetActive(true);
            }
        }

        if (contadorTiempo >= 70 && contadorTiempo <= 71)
        {
            if (!anuncioDamnificados.active)
            {
                anuncioDamnificados.SetActive(true);
            }
        }

        if (contadorTiempo >= 90 && contadorTiempo <= 91)
        {
            if (!anuncioIndigenas.active)
            {
                anuncioIndigenas.SetActive(true);
            }
        }

        if (contadorTiempo >= 100 && contadorTiempo <= 110)
        {
            if (!anuncioVoluntariado.active)
            {
                anuncioVoluntariado.SetActive(true);
            }
        }
    }

}
