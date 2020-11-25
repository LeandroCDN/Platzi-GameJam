using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stadistics : MonoBehaviour
{
    public static Stadistics stadistics;

    
    public int points = 0;
    public int maxPoints= 0 ;
    public int sumasImp = 0;
    public int ultMano, ultSeleccion;


    private void Awake()
    {

        if (stadistics != null)
        {
            Destroy(this);
        }
        else
        {
            stadistics = this;
        }
        DontDestroyOnLoad(this);
        
    }
    public void Update()
    {
        points = UIManager.uiManager.points;
        if( maxPoints < points)
        {
            maxPoints = points;
        }
    }
}
