using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text endPoints, maxPoints, sumImp;
    public Text[] ultimaSuma;
    private void Start()
    {
        endPoints.text ="Puntaje: " + Stadistics.stadistics.points.ToString();
        maxPoints.text = "Puntaje maximo: " + Stadistics.stadistics.maxPoints.ToString();
        sumImp.text = "Sumas impares totales: " + Stadistics.stadistics.sumasImp.ToString();


        

    }
    private void Update()
    {
        ultimaSuma[0].text = Stadistics.stadistics.ultMano.ToString();
        ultimaSuma[1].text = Stadistics.stadistics.ultSeleccion.ToString();

    }

}
