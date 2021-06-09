using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InicioVideo : MonoBehaviour
{
    public static bool toco = false;
    Button btnToco;
    // Start is called before the first frame update
    void Start()
    {
        btnToco = GameObject.Find("btnToco").GetComponent<Button>();
    }

    public void OnbtnTocoClick()
    {
        toco = true;
        btnToco.transform.position = new Vector2(-1000, -1000);
    }
}
