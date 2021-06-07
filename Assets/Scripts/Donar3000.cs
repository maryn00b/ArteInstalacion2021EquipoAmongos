using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donar3000 : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameController.puntuacion = GameController.puntuacion - 3000;
    }
}
