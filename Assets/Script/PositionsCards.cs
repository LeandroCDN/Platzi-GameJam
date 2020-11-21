using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionsCards : MonoBehaviour
{
    public static Transform[] posId;

    private void Awake()
    {
        posId = new Transform[transform.childCount];
        for (int  i = 0; i < posId.Length; i++)
        {
           posId[i] = transform.GetChild(i);
        }
    }
}
