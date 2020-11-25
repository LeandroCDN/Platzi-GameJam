using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text[] tutorial;
    public Button siguiente,play;
    public Image imgPlay;
    public int page = 1;
    
    

    // Start is called before the first frame update
    private void Start()
    {
        play.enabled = false;
        imgPlay.enabled = false;

    }
    public void Siguiente ()
    {
        if (page == 1)
        {
            tutorial[0].enabled = false;
            tutorial[1].enabled = false;
            tutorial[2].enabled = false;
            tutorial[3].enabled = true;
            tutorial[4].enabled = true;
            tutorial[5].enabled = false;
            tutorial[6].enabled = false;
            tutorial[7].enabled = false;
            tutorial[8].enabled = false;
            tutorial[9].enabled = false;
            tutorial[10].enabled = false;
            page++;
        }
        else
        {
            if (page == 2)
            {
                tutorial[0].enabled = false;
                tutorial[1].enabled = false;
                tutorial[2].enabled = false;
                tutorial[3].enabled = false;
                tutorial[4].enabled = false;
                tutorial[5].enabled = true;
                tutorial[6].enabled = true;
                tutorial[7].enabled = true;
                tutorial[8].enabled = true;
                tutorial[9].enabled = true;
                tutorial[10].enabled = true;
                page++;
            }
            else
            {
                tutorial[0].enabled = true;
                tutorial[1].enabled = true;
                tutorial[2].enabled = true;
                tutorial[3].enabled = true;
                tutorial[4].enabled = true;
                tutorial[5].enabled = true;
                tutorial[6].enabled = true;
                tutorial[7].enabled = true;
                tutorial[8].enabled = true;
                tutorial[9].enabled = true;
                tutorial[10].enabled = true;
                page++;
                play.enabled = true;
                imgPlay.enabled = true;
                siguiente.GetComponent<Image>().enabled = false;
                siguiente.GetComponentInChildren<Text>().enabled = false;
            }
        }
    }
}
