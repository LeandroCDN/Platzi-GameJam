using System.Collections;
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
    public int result;

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
    }    

    void Spawncard()
    {
        for (int i = 0; i < 7; i++)
        {
            card = Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
            card.id = i;
            cardsOnTable.Add(card);
        }
        
    }

    private void Update()
    {
        for (int i = 0; i < 7; i++)
        {
            if (cardsOnTable[i] == null)
            {
                card = Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
                card.id = i;
                cardsOnTable[i]=card;
            }
        }
    }
}
