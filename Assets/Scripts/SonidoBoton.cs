﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBoton : MonoBehaviour
{
    public AudioSource sonidoBoton;

    private void OnMouseDown()
    {
        sonidoBoton.Play();
    }
}
