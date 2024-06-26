using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAIDA : MonoBehaviour
{
    public GameObject[] productos;
    public int min;
    public int max;
    void Start()
    {
        int cantidad = Random.Range(4, 14);
        int elemento = Random.Range(0, 20);
    }

    void Update()
    {
        
    }
}
