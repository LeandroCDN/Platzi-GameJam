using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;

public class UIManager : MonoBehaviour
{
    //<POST PROCESSING>
    public PostProcessVolume _Volumen;

    private AmbientOcclusion _AmbientOclusion;
    private Vignette _Vignette;
    private LensDistortion _LensDistor;
    //<POST PROCESSING/>

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

        //POST PROCESSING (obteniendo los valores necesarios y seteandolos en 0 por si acaso)
        _Volumen.profile.TryGetSettings(out _AmbientOclusion); 
        _AmbientOclusion.intensity.value = 0;

        _Volumen.profile.TryGetSettings(out _Vignette);
        _Vignette.intensity.value = 0;

        _Volumen.profile.TryGetSettings(out _LensDistor);
        _LensDistor.intensity.value = 0;

    }

    private void Update()
    {
        timeStart -= Time.deltaTime;
        countDown.text = "TIME: " + Mathf.Round(timeStart).ToString();

        //Sounds
        //FindObjectOfType<AudioManager>().Play("lento");
      

        //POST PROCESSING EFFECTS
        SetEffects();
    }

    public  void TotalPoints(int result)
    {
        points = result + points;
        pointsText.text = "Puntaje: " + points;
    }

    //POST PROCESSING EFFECTS
    void SetEffects()
    {
        //POST PROCESSING  se activa cuando el tiempo es menor a 10s y se resetea cuando es mayor a 10s
        if(timeStart >= 10)
        {
            _AmbientOclusion.intensity.value = 0;
            _Vignette.intensity.value = 0;
            _LensDistor.intensity.value = 0;
        }
        else
        {
            _AmbientOclusion.intensity.value = Mathf.Lerp(_AmbientOclusion.intensity.value,10,.03f * Time.deltaTime);
            _Vignette.intensity.value = Mathf.Lerp(_Vignette.intensity.value, 10, .008f * Time.deltaTime);
            _LensDistor.intensity.value = Mathf.Lerp(_LensDistor.intensity.value, -30, .4f * Time.deltaTime);

            Debug.Log("-10");
        }
    }
}
