using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Interaction : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Button[] buttons;
    [SerializeField]
    Level1Handler level1Handler;
    [SerializeField]
    WireHandler wireHandler;
    [SerializeField]
    CanvasHandler canvasHandler;
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; 
            buttons[i].onClick.AddListener(() => ManejarClic(buttons[index].name));
        }
    }
    public void ManejarClic(string nombreBoton)
    {
        if(nombreBoton == level1Handler.assignedPort)
        {
            if(level1Handler.laptopIsPositioned)
            {
                    level1Handler.Connect();
                    level1Handler.StartLevel1();      
             
            }
            else 
            {
                canvasHandler.MostrarMensaje("Debes posicionar la laptop al lado del router");
            }
        }
        else
        {
            canvasHandler.MostrarMensaje("Elegiste un puerto incorrecto, revisa el manual de configuración"); 
        } 
        Debug.Log("Se hizo clic en el botón: " + nombreBoton);
    }
}
