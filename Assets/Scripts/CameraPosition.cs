using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour
{

    public GameObject playerGameObject;
    private bool esPrimeraPersona = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            if (esPrimeraPersona)
            {
                Camera.main.transform.parent = null;
                Camera.main.orthographic = true;
                Camera.main.transform.position = new Vector3(0, 45, 10);
                transform.eulerAngles = new Vector3(90, 0, 0);
                esPrimeraPersona = false;
            }
            else
            {
                Camera.main.transform.position = playerGameObject.transform.position + new Vector3(-1.5f, 6.2f, -6);
                Camera.main.transform.parent = playerGameObject.transform;
                transform.eulerAngles = new Vector3(27, 0, 0);
                Camera.main.orthographic = false;
               

                esPrimeraPersona = true;
            }
        }

    }
}
