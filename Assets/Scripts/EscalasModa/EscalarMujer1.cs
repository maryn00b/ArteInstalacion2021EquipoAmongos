using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalarMujer1 : MonoBehaviour
{
    bool isSmall = true;
    private void OnMouseDown()
    {
        if (isSmall)
        {
            gameObject.transform.position = new Vector3(-1551.59f, 331.04f, -93.76f);
            gameObject.transform.localScale = new Vector3(2.469797f, 2.469797f, 0.03f);
            isSmall = false;
        }

        else if (!isSmall)
        {
            gameObject.transform.position = new Vector3(-1551.7f, 331.86f, -95.816f);
            gameObject.transform.localScale = new Vector3(0.631488f, 0.631488f, 0.01f);
            isSmall = true;
        }
    }
}
