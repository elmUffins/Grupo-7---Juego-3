using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAIDA : MonoBehaviour
{
    public GameObject[] productosPrefab;
    public Transform[] spawners;
    int spawner = 0;
    int cantidad = Random.Range(4, 20);
    int elemento = Random.Range(0, 20);
    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {
            Instantiate(productosPrefab[elemento], spawners[spawner].position, spawners[spawner].rotation);
            if (spawner + 1 == 9)
            {
                spawner = 0;
            }
            else
            {
                spawner += 1;
            }
        }
        
    }

    void Update()
    {
        
    }
}
