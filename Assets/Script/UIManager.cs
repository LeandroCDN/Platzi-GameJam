using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int points = 0;    
    public Text pointsText;
    public static UIManager uiManager;

    public  float timeStart = 15;
    public Text countDown;

    
    private void Awake()
    {
        if (uiManager != null)
        {
            Destroy(this);
        }
        else
        {
            uiManager = this;
        }
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        countDown.text = timeStart.ToString();
    }

    private void Update()
    {
        timeStart -= Time.deltaTime;
        countDown.text = "TIME: " + Mathf.Round(timeStart).ToString();
    }

    public  void TotalPoints(int result)
    {
        points = result + points;
        pointsText.text = "Puntaje: " + points; 
    }
}
