using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    public Text textoContador;
    private int puntuacion = 10000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restaDinero()
    {
        puntuacion = puntuacion - 3000;
        textoContador.text = puntuacion.ToString();
    }
}
