using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
    public Card cardPrefab;
    public Transform spawnPoint;
    //private float countdown = 1f;

    private void Start()
    {
        Spawncard();
    }    

    void Spawncard()
    {
        for (int i = 0; i < 7; i++)
        {
            Instantiate(cardPrefab, spawnPoint.position, spawnPoint.rotation);
            cardPrefab.id = i;
        }
        
    }
}
