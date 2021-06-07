using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    public Text textoContador;
    private int puntuacion = 50000;
    public GameObject estrella1;
    Image imagenEstrella1;
    public Sprite spriteEstrellaLlena;
    public Sprite spriteEstrellaVacia;

    // Start is called before the first frame update
    void Start()
    {
        imagenEstrella1 = estrella1.GetComponent<Image>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (puntuacion < 45000)
        {
            imagenEstrella1.sprite = spriteEstrellaLlena;
        }
    }

    public void restaDinero()
    {
        puntuacion = puntuacion - 3000;
        textoContador.text = puntuacion.ToString();
    }


}
