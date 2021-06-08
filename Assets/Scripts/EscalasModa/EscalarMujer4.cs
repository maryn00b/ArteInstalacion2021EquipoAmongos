using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalarMujer4 : MonoBehaviour
{
    bool isSmall = true;
    private void OnMouseDown()
    {
        if (isSmall)
        {
            gameObject.transform.position = new Vector3(34, 1, 3);
            gameObject.transform.localScale = new Vector3(10, 10, 0.1f);
            isSmall = false;
        }

        else if (!isSmall)
        {
            gameObject.transform.position = new Vector3(36, 2, 3);
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 0.01f);
            isSmall = true;
        }
    }
}
