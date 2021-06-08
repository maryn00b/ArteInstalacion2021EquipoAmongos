using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donar5000 : MonoBehaviour
{
    
        private void OnMouseDown()
        {
            GameController.puntuacion = GameController.puntuacion - 5000;
        }
   
}
