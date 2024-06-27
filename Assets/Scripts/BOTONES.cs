using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOTONES : MonoBehaviour
{
    public InputField inputField; 
    public GameObject panelNumero; 
    public GameObject panelError;


    void Start()
    {
        panelNumero.SetActive(false);
        panelError.SetActive(false);
    }

    public void Mostrar()
    {
        string inputText = inputField.text;

        if (int.TryParse(inputText, out int result))
        {
            panelNumero.SetActive(true);
            panelError.SetActive(false);
        }
        else
        {
            panelNumero.SetActive(false);
            panelError.SetActive(true);
        }
    }
}
