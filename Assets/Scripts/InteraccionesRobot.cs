using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionesRobot : MonoBehaviour
{
    public  Animator personajeAnimado;
    public  Animator controlTraslacion;
    public static bool walk =false;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Flash.foto)
        {
            personajeAnimado.SetBool("walking", false);
            personajeAnimado.SetBool("angry", true);
        }
        if (walk)
        {
            personajeAnimado.SetBool("walking", true);
            controlTraslacion.SetBool("traslacion", true);
        }


    }
    public void changeAnimation()
    {
        personajeAnimado.SetBool("walking",true);
        controlTraslacion.SetBool("traslacion", true);
        
    }
    
}
