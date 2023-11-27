using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CanvasHandler : MonoBehaviour
{
    public Text mensajeText;
    public Canvas mensajeCanvas;
    public float duracion = 5.0f;

    void Start()
    {
        mensajeText.text = "";
        mensajeCanvas.enabled = false;
        MostrarMensaje("Primero debes leer el manual de configuración, y ver la imagen de la topología");
    }

    public void MostrarMensaje(string mensaje)
    {
        StartCoroutine(MostrarMensajeCoroutine(mensaje));
    }

    IEnumerator MostrarMensajeCoroutine(string mensaje)
    {
        mensajeText.text = mensaje;
        mensajeCanvas.enabled = true;

        yield return new WaitForSeconds(duracion);

        mensajeCanvas.enabled = false;
    }
}
