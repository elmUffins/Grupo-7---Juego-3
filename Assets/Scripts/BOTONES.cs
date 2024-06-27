using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BOTONES : MonoBehaviour
{
    public InputField inputField; 
    public GameObject panelNumero; 
    public GameObject panelError;
    public GameObject esperando;
    public GameObject titulo;
    public GameObject responder;
    public GameObject cantidadT;
    public GameObject textoGood;
    public GameObject textoBad;

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
            cantidadT.SetActive(false);
            esperando.SetActive(false);
            panelNumero.SetActive(true);
            panelError.SetActive(false);

            if (Convert.ToInt32(inputText) == CAIDA.cantidad)
            {
                textoBad.SetActive(false);
            }
            else
            {
                textoGood.SetActive(false);
            }
        }
        else
        {
            titulo.SetActive(false);
            responder.SetActive(false);
            cantidadT.SetActive(false);
            esperando.SetActive(false);
            panelNumero.SetActive(false);
            panelError.SetActive(true);
        }
    }

    public void Ok()
    {
        titulo.SetActive(true);
        responder.SetActive(true);
        cantidadT.SetActive(true);
        esperando.SetActive(true);
        panelNumero.SetActive(false);
        panelError.SetActive(false);
    }

    public void ReRun()
    {
        SceneManager.LoadScene("CAIDA");
    }
}
