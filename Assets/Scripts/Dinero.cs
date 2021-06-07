using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dinero : MonoBehaviour
{
    public Text textoContador;
    //private int GameController.puntuacion = 50000;


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
        textoContador.text = GameController.puntuacion.ToString();

        if (GameController.puntuacion <= 45000 && GameController.puntuacion > 40000)
        {
            imagenEstrella1.sprite = spriteEstrellaLlena;
        }
        if (GameController.puntuacion <= 40000 && GameController.puntuacion > 35000)
        {
            imagenEstrella2.sprite = spriteEstrellaLlena;
        }
        if (GameController.puntuacion <= 35000 && GameController.puntuacion > 30000)
        {
            imagenEstrella3.sprite = spriteEstrellaLlena;
        }
        if (GameController.puntuacion <= 30000 && GameController.puntuacion > 25000)
        {
            imagenEstrella4.sprite = spriteEstrellaLlena;
        }
        if (GameController.puntuacion <= 25000 && GameController.puntuacion > 20000)
        {
            imagenEstrella5.sprite = spriteEstrellaLlena;
        }
    }

    public void restaDineroAnuncioFrape()
    {
        GameController.puntuacion = GameController.puntuacion - 1000;
        textoContador.text = GameController.puntuacion.ToString();
    }

    public void restaDineroAnuncioEscuelas()
    {
        GameController.puntuacion = GameController.puntuacion - 3000;
        textoContador.text = GameController.puntuacion.ToString();
    }

    public void restaDineroDamnificados()
    {
        GameController.puntuacion = GameController.puntuacion - 5000;
        textoContador.text = GameController.puntuacion.ToString();
    }

    public void restaDineroIndigenas()
    {
        GameController.puntuacion = GameController.puntuacion - 2000;
        textoContador.text = GameController.puntuacion.ToString();
    }

    public void restaDineroVoluntariado()
    {
        GameController.puntuacion = GameController.puntuacion - 8000;
        textoContador.text = GameController.puntuacion.ToString();
    }


}
