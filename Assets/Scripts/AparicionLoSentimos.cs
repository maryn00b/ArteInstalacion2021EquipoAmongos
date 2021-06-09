using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparicionLoSentimos : MonoBehaviour
{
    public GameObject anuncioLoSiento;
    public GameObject btnAceptar;
    // Start is called before the first frame update
    public void loSiento()
    {
        anuncioLoSiento.SetActive(true);
        btnAceptar.SetActive(true);
    }
}
