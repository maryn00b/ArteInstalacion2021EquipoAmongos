using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Panels : MonoBehaviour
{
    //public GameObject panel1;
    //public GameObject comenzar;
    public static bool jugadorCerca = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player"))
        {
            Debug.Log("OnTriggerEnterJugador");
            jugadorCerca = true;
            Debug.Log(jugadorCerca);
        }

    }
    
    
}
