using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConfigurationHandler : MonoBehaviour
{
    [SerializeField]
    Text Option1;
    [SerializeField]
    Text Option2;
    [SerializeField]
    Text Option3;
    [SerializeField]
    TMP_Text PromptText;
    private int index = 0;
    string[] settings = new string[]
    {
        "1. Cambia el nombre del Router a R1",
        "2. Configure c1sco1234 como contraseña encriptada del modo EXEC con privilegios",
        "3. Establezca CCNA-lab.com como nombre del dominio",
        "4. Inhabilite la búsqueda DNS",
        "5. Habilite el cifrado de contraseñas de texto sin formato",
        "6. Configure un usuario con nombre de SSHAdmin con una contraseña 55Hadm!n",
        "7. Genere un conjunto de claves criptográficas con un módulo de 1024 bits.",
        "8. Asigne cisco como contraseña de consola, con la opción de logging synchronous",
        "9. Asigne cisco como contraseña vty",
        "10. Cree un aviso que advierta a todo el que acceda al dispositivo que el acceso no autorizado está prohibido"
    };    
    string[,] options = new string[,]{
        {"Hostname R1","Routername R1","Name R1"},
        {"Enable secret c1sco1234","X","X"},
        {"ip domain-name CCNA-lab.com","X","X"},
        {"no ip domain lookup","X","X"},
        {"service password-encryption","X","X"},
        {"username SSHadmin secret 55Hadm!n","X","X"},
        {"crypto key generate rsa 1024","X","X"},
        {"line con 0\n password cisco \n loggin synchronous \n login","X","X"},
        {"line vty 0 4\n password cisco \n login local","X","X"},
        {"banner motd #Ingreso solo para personal autorizado#","X","X"},
    };
    int[] correctAnswerIndex = new int[]{
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0,
        0
    };
    public void StartConfiguration() {
        SetQuestion(0);
    }
    public bool ValidatePrompt(int buttonIndex) {
        if(correctAnswerIndex[index] == buttonIndex)
        {
            index++;
            SetQuestion(index);
            return true;
        }
        return false;
    }
    void SetQuestion(int index){
        PromptText.text = settings[index];
        Option1.text = options[index,0];
        Option2.text = options[index,1];
        Option3.text = options[index,2];
    }
}
