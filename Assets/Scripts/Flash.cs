using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{
    public static bool foto = false;

    private void OnMouseDown()
    {
        foto = true;
        Debug.Log(foto);
    }
    
}
