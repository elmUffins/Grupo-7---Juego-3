using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAIDA : MonoBehaviour
{
    public GameObject[] productosPrefab; // Todos los productos disponibles
    public Transform[] spawners; 
    public float delay = 1.0f; 

    void Start()
    {
        int cantidad = Random.Range(4, 20); 
        int elemento = Random.Range(0, 20); 
        StartCoroutine(SpawnObjects(cantidad, elemento));
        Debug.Log(cantidad);
    }

    IEnumerator SpawnObjects(int cantidad, int elemento)
    {
        for (int i = 0; i < cantidad; i++)
        {
            int spawnerIndex = Random.Range(0, spawners.Length); 
            Instantiate(productosPrefab[elemento], spawners[spawnerIndex].position, spawners[spawnerIndex].rotation);
            yield return new WaitForSeconds(delay); 
        }
    }

    void Update()
    {
        
    }
}
