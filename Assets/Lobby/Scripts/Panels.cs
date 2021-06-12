
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Panels : MonoBehaviour
{
    public GameObject panel1;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player"))
        {
            Debug.Log("OnTriggerEnterJugador");
            panel1.SetActive(true);

        }

    }


}
