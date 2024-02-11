using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    
    public float velocidadDesplazamiento = 10f;

    void Update()
    {
       
       
        transform.Translate(Vector3.forward * velocidadDesplazamiento * Time.deltaTime);
    }
}
