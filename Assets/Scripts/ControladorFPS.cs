using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorFPS : MonoBehaviour
{
    Rigidbody rb;
    Vector2 inputMov;
    public float velCamina = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        inputMov.x = Input.GetAxis("Horizontal");
        inputMov.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        float vel = velCamina;
        rb.velocity = (transform.forward * vel * inputMov.y) + (transform.right * vel * inputMov.x);
    }
}
