using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI_Interaction : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    Button[] buttons;

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
        Debug.Log("Se hizo clic en el botón: " + nombreBoton);
    }
 
    
}