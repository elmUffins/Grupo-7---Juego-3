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
    public GameObject titulo;
    public GameObject responder;
    public GameObject cantidad;

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
            titulo.SetActive(false);
            responder.SetActive(false);
            cantidad.SetActive(false);
            esperando.SetActive(false);
            panelNumero.SetActive(true);
            panelError.SetActive(false);
        }
        else
        {
            titulo.SetActive(false);
            responder.SetActive(false);
            cantidad.SetActive(false);
            esperando.SetActive(false);
            panelNumero.SetActive(false);
            panelError.SetActive(true);
        }
    }
}
