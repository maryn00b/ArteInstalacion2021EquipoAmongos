using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CerrarFinStars : MonoBehaviour
{
    public GameObject btnPoster;
    public void cerrarEstrellas()
    {
        //Debug.Log("Hola");
        btnPoster.SetActive(false);
    }
}
