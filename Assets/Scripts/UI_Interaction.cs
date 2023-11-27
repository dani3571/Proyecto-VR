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
        }
        Debug.Log("Se hizo clic en el botón: " + nombreBoton);
    }
}
