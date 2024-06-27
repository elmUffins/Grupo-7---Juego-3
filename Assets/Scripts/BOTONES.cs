using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOTONES : MonoBehaviour
{
    public InputField inputField; 
    public GameObject panelNumero; 
    public GameObject panelError;
    public GameObject esperando;

    void Start()
    {
        esperando.SetActive(true);
        panelNumero.SetActive(false);
        panelError.SetActive(false);
    }

    public void Mostrar()
    {
        string inputText = inputField.text;

        if (int.TryParse(inputText, out int result))
        {
            esperando.SetActive(false);
            panelNumero.SetActive(true);
            panelError.SetActive(false);
        }
        else
        {
            esperando.SetActive(false);
            panelNumero.SetActive(false);
            panelError.SetActive(true);
        }
    }
}
