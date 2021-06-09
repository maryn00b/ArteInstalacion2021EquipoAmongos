using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Donaciones : MonoBehaviour
{
    public Text textoContador;
    private int donacion = 0;
    public float contadorTiempo = 0;

    public GameObject reclamarDonaciones;
    bool reclamo = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contadorTiempo += Time.deltaTime;
        textoContador.text = donacion.ToString();


        if (contadorTiempo >= 7 && contadorTiempo <= 8)
        {
            donacion = donacion + 5;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 9 && contadorTiempo <= 10)
        {
            donacion = donacion + 10;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 10 && contadorTiempo <= 11)
        {
            donacion = donacion + 5;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 12 && contadorTiempo <= 13)
        {
            donacion = donacion + 1;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 15 && contadorTiempo <= 16)
        {
            donacion = donacion + 7;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 18 && contadorTiempo <= 19)
        {
            donacion = donacion + 3;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 20 && contadorTiempo <= 21)
        {
            donacion = donacion + 15;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 22 && contadorTiempo <= 23)
        {
            donacion = donacion + 4;
            textoContador.text = donacion.ToString();
            reclamo = false;
        }
        if (contadorTiempo >= 25 && contadorTiempo <= 26)
        {
            donacion = donacion + 20;
            textoContador.text = donacion.ToString();
            reclamo = true;
        }

        if (reclamo)
        {
            if (!reclamarDonaciones.active)
            {
                reclamarDonaciones.SetActive(true);
                
            }
        }

    }
    

}
