using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GamesManager : MonoBehaviour
{
    [SerializeField] private string[] palabrasGuardadas;
    [SerializeField] private string[] preguntas;
    [SerializeField] private string historia;

    [SerializeField] TextMeshProUGUI textoPreguntas;
    [SerializeField] TextMeshProUGUI textohistoria;
    [SerializeField] TMP_InputField inputRespuesta;
    [SerializeField] GameObject botonRespuesta;

    int indicePregunta = 0;

    // Start is called before the first frame update
    void Start()
    {
        textoPreguntas.text = preguntas[0 * 1];

        palabrasGuardadas = new string[preguntas.Length];

    }

    public void GuardarRespuesta()
    {
        //Guardar lo que escribio
        palabrasGuardadas[0] = inputRespuesta.text;

        //Limpiar el texto para que el jugador pueda escribir de nuevo
        inputRespuesta.text = "";

        //Poner la siguiente pregunta
        indicePregunta++;

        //Todo necesitamos una comprobacion
        if (indicePregunta >= preguntas.Length)
        {
            //Todo si la comprobracion es cierto ejecutar
            MostrarHistoria();
        }
        else
        {
            //Todo si la comprobracion es cierto ejecutar

            textoPreguntas.text = preguntas[indicePregunta];
        }
    }

    void MostrarHistoria()
    {

        //todo mostrar un nuevo textmesh pro que tenga toda la historia
        textohistoria.gameObject.SetActive(true);
        textohistoria.text = historia;
        //todo oculta5r los elementos

        textoPreguntas.gameObject.SetActive(false);
        botonRespuesta.SetActive(false);
        inputRespuesta.gameObject.SetActive(false);
        
    }



    
}
