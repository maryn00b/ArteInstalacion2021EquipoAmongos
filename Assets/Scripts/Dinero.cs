using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    public Text textoContador;
    private int puntuacion = 50000;


    public GameObject estrella1;
    public GameObject estrella2;
    public GameObject estrella3;
    public GameObject estrella4;
    public GameObject estrella5;

    Image imagenEstrella1;
    Image imagenEstrella2;
    Image imagenEstrella3;
    Image imagenEstrella4;
    Image imagenEstrella5;

    public Sprite spriteEstrellaLlena;
    public Sprite spriteEstrellaVacia;

    // Start is called before the first frame update
    void Start()
    {
        imagenEstrella1 = estrella1.GetComponent<Image>();
        imagenEstrella2 = estrella2.GetComponent<Image>();
        imagenEstrella3 = estrella3.GetComponent<Image>();
        imagenEstrella4 = estrella4.GetComponent<Image>();
        imagenEstrella5 = estrella5.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (puntuacion <= 45000 && puntuacion > 40000)
        {
            imagenEstrella1.sprite = spriteEstrellaLlena;
        }
        if (puntuacion <= 40000 && puntuacion > 35000)
        {
            imagenEstrella2.sprite = spriteEstrellaLlena;
        }
        if (puntuacion <= 35000 && puntuacion > 30000)
        {
            imagenEstrella3.sprite = spriteEstrellaLlena;
        }
        if (puntuacion <= 30000 && puntuacion > 25000)
        {
            imagenEstrella4.sprite = spriteEstrellaLlena;
        }
        if (puntuacion <= 25000 && puntuacion > 20000)
        {
            imagenEstrella5.sprite = spriteEstrellaLlena;
        }
    }

    public void restaDinero()
    {
        puntuacion = puntuacion - 3000;
        textoContador.text = puntuacion.ToString();
    }


}
