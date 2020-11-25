using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int points = 0;
    public Text pointsText;
    public static UIManager uiManager;

    public float timeStart = 15;
    public Text countDown;

    //GameOver
    public Image panel;

    //TUTORIAL
    public Text[] tutorial;
    public Button siguiente;
    public int page =  1;

    
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
        
    }

    private void Start()
    {
        countDown.text = timeStart.ToString();
        
    }

    private void Update()
    {
        timeStart -= Time.deltaTime;
        countDown.text = "TIME: " + Mathf.Round(timeStart).ToString();

        //Sounds
        //FindObjectOfType<AudioManager>().Play("lento");
      
    }

    public  void TotalPoints(int result)
    {
        points = result + points;
        pointsText.text = "Puntaje: " + points; 
    }
}
