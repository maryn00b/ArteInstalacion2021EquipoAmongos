using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionesRobot : MonoBehaviour
{
    public  Animator personajeAnimado;
    public  Animator controlTraslacion;
    public static bool walk =false;
    public static bool chekWalk = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (walk)
        {
            personajeAnimado.SetBool("walking", true);
            controlTraslacion.SetBool("traslacion", true);
            personajeAnimado.SetBool("angry", false);
            personajeAnimado.SetBool("idle", false);
            walk = false;
        }

        if (IdleWalk.pisoCol && personajeAnimado.GetBool("walking") == true)
        {
            personajeAnimado.SetBool("walking", false);
            personajeAnimado.SetBool("angry", false);
            personajeAnimado.SetBool("idle", true);

        }
        if (Flash.foto)
        {
            personajeAnimado.SetBool("walking", false);
            personajeAnimado.SetBool("angry", true);
            personajeAnimado.SetBool("idle", false);
        }
       
        


    }
    public void changeAnimation()
    {
        personajeAnimado.SetBool("walking",true);
        controlTraslacion.SetBool("traslacion", true);
        
    }
    
}
