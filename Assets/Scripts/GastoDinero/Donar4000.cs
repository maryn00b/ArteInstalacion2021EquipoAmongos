using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Donar4000 : MonoBehaviour
{
   
        private void OnMouseDown()
        {
            GameController.puntuacion = GameController.puntuacion - 4000;
        }
    
}
