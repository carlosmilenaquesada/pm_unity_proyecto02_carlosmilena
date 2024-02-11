using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private GameObject contadorPuntos;
    private float topBound = 30;
    private float lowerBound = 0;
    void Start()
    {
        contadorPuntos = GameObject.FindGameObjectWithTag("contador");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            contadorPuntos.GetComponent<ContadorPuntos>().incrementarVisitante();
            Destroy(gameObject);
            
        }
    }
}
