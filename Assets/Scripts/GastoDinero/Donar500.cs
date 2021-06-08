using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donar500 : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameController.puntuacion = GameController.puntuacion - 500;
    }
}
