using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CerrarAnuncio : MonoBehaviour
{
    public GameObject finalizarEstrellas;
    public GameObject cerrarSigno;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

    public void cerrarAnuncio()
    {
        if (finalizarEstrellas.active && cerrarSigno.active)
        {
            finalizarEstrellas.SetActive(false);
            cerrarSigno.SetActive(false);
        }
    }
}
