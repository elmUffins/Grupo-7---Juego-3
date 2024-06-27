using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CAIDA : MonoBehaviour
{
    public GameObject[] productosPrefab; // Array de todos los productos disponibles
    public Transform[] spawners; // Array con los spawners
    public float delay = 1.0f; // Delay entre cada instanciación del prefab
    public float delayDeCambio = 5.0f; // Delay entre la caída del último elemento y el cambio de pantalla

    void Start()
    {
        int cantidad = Random.Range(4, 20); 
        int elemento = Random.Range(0, 20); 
        StartCoroutine(SpawnObjects(cantidad, elemento)); // Activa el proceso 'SpawnObjects'
        Debug.Log(cantidad);
    }

    IEnumerator SpawnObjects(int cantidad, int elemento) // Función de tipo 'IEnumerator', permite iterar los objetos y utilizar 'WaitForSeconds'
    {
        for (int i = 0; i < cantidad; i++)
        {
            int spawnerIndex = Random.Range(0, spawners.Length); 
            Instantiate(productosPrefab[elemento], spawners[spawnerIndex].position, spawners[spawnerIndex].rotation);
            yield return new WaitForSeconds(delay); 
        }

        // Cambio de escena
        yield return new WaitForSeconds(delayDeCambio);
        SceneManager.LoadScene("RESPUESTA"); 
    }

    void Update()
    {
        
    }
}
