﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalarProducto : MonoBehaviour
{
    bool isSmall = true;
    private void OnMouseDown()
    {
        if (isSmall)
        {
            gameObject.transform.position = new Vector3(32, -0.5f, 3);
            gameObject.transform.localScale = new Vector3(7, 7, 0.1f);
            isSmall = false;
        }

       else if (!isSmall)
        {
            gameObject.transform.position = new Vector3(30, 2, 3);
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.1f);
            isSmall = true;
        }
    }
}
