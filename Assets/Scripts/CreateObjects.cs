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
        
        

        if (contadorTiempo >= 60 && contadorTiempo <= 61)
        {
            if (!anuncioFrappe.active)
            {
               anuncioFrappe.SetActive(true);
            }
        }

        if (contadorTiempo >= 120 && contadorTiempo <= 121)
        {
            if (!anuncioEscuela.active)
            {
                anuncioEscuela.SetActive(true);
            }
        }

        if (contadorTiempo >= 180 && contadorTiempo <= 181)
        {
            if (!anuncioDamnificados.active)
            {
                anuncioDamnificados.SetActive(true);
            }
        }

        if (contadorTiempo >= 240 && contadorTiempo <= 241)
        {
            if (!anuncioIndigenas.active)
            {
                anuncioIndigenas.SetActive(true);
            }
        }

        if (contadorTiempo >= 300 && contadorTiempo <= 301)
        {
            if (!anuncioVoluntariado.active)
            {
                anuncioVoluntariado.SetActive(true);
            }
        }
    }

}
