using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{

    public Vector3 direccion;
    public float velocidad;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(direccion, velocidad * Time.deltaTime);
    }

}
