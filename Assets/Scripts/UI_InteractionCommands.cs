using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_InteractionCommands : MonoBehaviour
{
    [SerializeField]
    Button[] buttons;

    [SerializeField]
    ConfigurationHandler configurationHandler;
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; 
            buttons[i].onClick.AddListener(() => ManejarClic(index));
        }
    }
    public void ManejarClic(int buttonIndex)
    {
        if(configurationHandler.ValidatePrompt(buttonIndex)){
            Debug.Log("Opción Correcta");
        } else {
            Debug.Log("Opción Incorrecta");
        }
    }
}
