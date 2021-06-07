using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donar1000 : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameController.puntuacion = GameController.puntuacion - 1000;
    }
}
