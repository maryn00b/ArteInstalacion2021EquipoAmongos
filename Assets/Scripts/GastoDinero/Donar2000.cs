using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donar2000 : MonoBehaviour
{
    
        private void OnMouseDown()
        {
            GameController.puntuacion = GameController.puntuacion - 2000;
        }
   
}
