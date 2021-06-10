using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarAnuncio : MonoBehaviour
{
    
    private void OnMouseDown()
    {
        Debug.Log("Hola");
        gameObject.SetActive(false);
        
    }
    

    
}
