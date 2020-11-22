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
    private Transform target; // Posicion que buscara segun su id
    public float speed = 0.5f; //velocidad para llegar a su posicion
    public bool esta = false; // si la carta esta o no en la mesa
    public Text valueText; // canvas del valor de la carta

    

    private void Start()
    {
        target = PositionsCards.posId[id];
        if (id != 5)
        {
            value = (int)((Random.Range(1, 50)) + 0.5);
        }
        else
        {
            value = (int)((Random.Range(100, 102)));
        }
    }

    private void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir * speed * Time.deltaTime, Space.World);
        transform.rotation = target.rotation;
        valueText.text = "" + value;
    }

    public Card (int Id, int Value)
    {
        id = Id;
        value = Value;
    }

    private void OnMouseDown()
    {
        if (id != 6)
        {
            result = value + GameManager.gameManager.cardsOnTable[6].value;
            GameManager.gameManager.IsGameOver(result);
            Destroy(GameManager.gameManager.cardsOnTable[6].gameObject);
            Destroy(gameObject);
        }
    }
}
