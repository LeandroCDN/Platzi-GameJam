using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public  class Loader :MonoBehaviour
{
    public string scene;
    public Animator animator;
    public Button[] botonesMenu;

    


    public  void LoadInMainMenu(string name)
    {

        scene = name;
        animator.enabled = true;        
        Invoke("Load2", 1.7f);
    }
    public void Load2()
    {

        SceneManager.LoadScene(scene);

    }


    public void Load(string name)
    {
       
        SceneManager.LoadScene(name.ToString());

    }
}
