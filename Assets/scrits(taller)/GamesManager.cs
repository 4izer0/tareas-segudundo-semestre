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
        string textoAFormatear = "soy {0} y tengo solo {1}, años, a {0} le gusta el numero {1}";
        string[] textos = new string[] { "toño", "10" };
        string mesnsaje = string.Format(textoAFormatear, textos);
        Debug.Log(mesnsaje);


        textoPreguntas.text = preguntas[indicePregunta];

        palabrasGuardadas = new string[preguntas.Length];




    }

    public void GuardarRespuesta()
    {
        //Guardar lo que escribio
        palabrasGuardadas[indicePregunta] = inputRespuesta.text;

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
        textohistoria.text = string.Format(historia, palabrasGuardadas);
        //todo oculta5r los elementos

        textoPreguntas.gameObject.SetActive(false);
        botonRespuesta.SetActive(false);
        inputRespuesta.gameObject.SetActive(false);
        
    }



    
}
