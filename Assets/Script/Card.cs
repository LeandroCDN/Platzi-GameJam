using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    public int id; //lugar que ocupara la carta y forma para identificarla  

    public int result;
    

    public int value; //Sera el valor de la Carta   
    public Transform target; // Posicion que buscara segun su id
    public float speed = 0.5f; //velocidad para llegar a su posicion
    public bool esta = false; // si la carta esta o no en la mesa
    public Text valueText; // canvas del valor de la carta   

    public Animator animator;
    public AudioSource audioSource;
    

    private void Start()
    {
        target = PositionsCards.posId[id];
        if (id != 5)
        {
            value = (int)((Random.Range(1, 50)) + 0.5);
            animator.enabled = false;
        }
        else
        {
            value = (int)((Random.Range(100, 102)));
            animator.enabled = false;
        }
        transform.rotation = target.rotation;
        
    }

    private void Update()
    {
        
        Vector3 dir = target.position - transform.position;        
        transform.Translate(dir * speed * Time.deltaTime, Space.World);        
        valueText.text = "" + value;
    }   

    private void OnMouseDown()
    {
        audioSource.Play();


        if (id != 6 && id!=5)
        {
            result = value + GameManager.gameManager.cardsOnTable[6].value;
            GameManager.gameManager.IsGameOver(result);
            Destroy(GameManager.gameManager.cardsOnTable[6].gameObject);
            
            Destroy(gameObject,0.2f);
        }
        if(id == 5)
        {
            animator.enabled = true;
            result = value + GameManager.gameManager.cardsOnTable[6].value;
            GameManager.gameManager.IsGameOver(result);
            Destroy(GameManager.gameManager.cardsOnTable[6].gameObject);
            Destroy(gameObject,1.5f);            
        }
        
    }
}
