using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private GameObject contadorPuntos;


    private void Start()
    {
        contadorPuntos = GameObject.FindGameObjectWithTag("contador");
    }
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(gameObject);
        Destroy(other.gameObject);
        contadorPuntos.GetComponent<ContadorPuntos>().incrementarLocal();
    }
}
