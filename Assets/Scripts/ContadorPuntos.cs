using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ContadorPuntos : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI textMeshProUGUI;

    private int local = 0;
    private int visitante = 0;

    public void incrementarLocal()
    {
        this.local++;
        textMeshProUGUI.text = "Local " + local + " - " + "Visitante " + visitante;
    }

    public void incrementarVisitante()
    {
        this.visitante++;
        textMeshProUGUI.text = "Local " + local + " - " + "Visitante " + visitante;
    }

    void Start()
    {
        textMeshProUGUI.text = "Local " + local + " - " + "Visitante " + visitante;

    }


}
