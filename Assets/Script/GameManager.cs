﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public static CardSpawner cardSpawner;
    public static GameManager gameManager;

    public Card cardPrefab;
    public Card card;
    public Transform spawnPoint;
    //private float countdown = 1f;    
    public  List<Card> cardsOnTable = new List<Card>();

    public int totalPares = 0;
    public bool paridad = false;

    

    private void Awake()
    {
        if(gameManager != null)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        Spawncard();

        totalPares = 0;        
        Paridadtotal();

    }

    private void Update()
    {
        for (int i = 0; i < 7; i++)
        {
            if (cardsOnTable[i] == null)
            {
                card = Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
                card.id = i;
                cardsOnTable[i] = card;
                if (i == 6)// la carta de la mano , llega mas rapido a la pantalla
                {
                    card.speed += 15;
                }
            }
        }

        totalPares = 0;        
        Paridadtotal();
        if((totalPares == 5) || (totalPares == 0)) // control para saber si todas las cartas visibles sobre la mesa son pares o impares.
        {
            paridad = true;
        }
        else
        {
            paridad = false;
        }
    }

    void Spawncard()
    {
        for (int i = 0; i < 7; i++)
        {
            card = Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
            card.id = i;
            cardsOnTable.Add(card);
            if (i == 6)
            {
                card.speed += 2;
            }
        }
        
    }

    public void IsGameOver(int results)
    {
        

        if ((results % 2) == 0)
        {
            GameOver();
        }
        else
        {
            UIManager.uiManager.TotalPoints(results);
            UIManager.uiManager.timeStart += 2;
        }

        

    }

    public void GameOver()
    {
        Debug.Log("TE DIO UN RESULTADO PAR >>>> GAME OVER");
    }

    public void Paridadtotal()
    {
        for (int i = 0; i < 5; i++)
        {
            if((cardsOnTable[i].value % 2) == 0) 
            {
                totalPares++;
            }
            
        }        
    }

    
}
