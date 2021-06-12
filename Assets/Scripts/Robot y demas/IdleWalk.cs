using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleWalk : MonoBehaviour
{
    public static bool pisoCol=false;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.CompareTag("Player"))
        {
            pisoCol=true;

        }

    }
}
