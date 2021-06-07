using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObjects : MonoBehaviour
{
    public float contadorTiempo = 0;
    public Transform pos;
    public GameObject aparicion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for (contadorTiempo = 0; contadorTiempo < 10; contadorTiempo++)
        //{
            contadorTiempo += Time.deltaTime;
        //}
        

        if (contadorTiempo >= 10)
        {
            AparecerAnuncio();
        }
    }

    void AparecerAnuncio()
    {
        //if (aparicion != null)
        //{
            Instantiate(aparicion, pos.position, pos.rotation);
        //}
        //Destroy(gameObject);
        


    }
}
