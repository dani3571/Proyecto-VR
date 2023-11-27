using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopHandler : MonoBehaviour
{
    [SerializeField]
    Level1Handler level1Handler;
    [SerializeField]
    CanvasHandler canvasHandler;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name.Equals("Laptop"))
        {
            level1Handler.laptopIsPositioned = true;
            canvasHandler.MostrarMensaje("Conecta la laptop al puerto designado");
        }
    }
}
