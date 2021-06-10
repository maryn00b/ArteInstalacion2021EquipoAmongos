using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioVideo : MonoBehaviour
{
    public static bool toco = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player"))
        {
            Debug.Log("OnTriggerEnterJugador");
            toco = true;
        }
        
    }
    
}
