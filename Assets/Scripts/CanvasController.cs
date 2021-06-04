using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public RectTransform mc;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;

    private void Start()
    {
        posFinal = Screen.width / 2;
        mc.position = new Vector3(-posFinal, mc.position.y, 0);
    }

    IEnumerator Mover(float time, Vector3 posInit, Vector3 posFin)
    {
        float elapsedTime = 0;
        while (elapsedTime < time)
        {
            mc.position = Vector3.Lerp(posInit, posFin, (elapsedTime / time));
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        mc.position = posFin;
    }

    void MoverMenu(float time, Vector3 posInit, Vector3 posFin)
    {
        StartCoroutine(Mover(time, posInit, posFin));
    }

    public void BUTTON_Configuracion()
    {
        int signo = 1;
        if (!abrirMenu)
            signo = -1;

        MoverMenu(tiempo, mc.position, new Vector3(signo * posFinal, mc.position.y, 0));
        abrirMenu = !abrirMenu;
    }
}
