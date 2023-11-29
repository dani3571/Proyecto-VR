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
    [SerializeField]
    CanvasHandler canvasHandler;
    [SerializeField]
    Text porcentageText;
    private int index = 0;
    private int porcentage = 0;
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
        {"Hostname R1","Routername R1","Name R1"}, // 0
        {"Enable password c1sco1234","Set password c1sco1234","Enable secret c1sco1234"}, // 2
        {"ip domain-server CCNA-lab.com","ip domain-name CCNA-lab.com","ip domain-net CCNA-lab.com"}, // 1
        {"no ip dns lookup","no ip dns server","no ip domain lookup"}, // 2
        {"service password-cifrate","service password-encryption","password-cifrate"}, // 1
        {"name SSHadmin secret 55Hadm!n","username SSHadmin password 55Hadm!n","username SSHadmin secret 55Hadm!n"}, // 2
        {"crypto key generate rsa 1024","crypto key 1024","generate key 1024"}, // 0
        {"line con 0\n password cisco \n loggin synchronous \n login","line con 0\n password cisco\n login","line con 0\n password cisco \n loggin synchronous"}, // 0
        {"line vty 0 4\n secret cisco \n login local","line vty 0 4\n password cisco \n login","line vty 0 4\n password cisco \n login local"}, // 2
        {"banner message #Ingreso solo para personal autorizado#","advise motd #Ingreso solo para personal autorizado#","banner motd #Ingreso solo para personal autorizado#"}, // 2
    };
    int[] correctAnswerIndex = new int[]{
        0,
        2,
        1,
        2,
        1,
        2,
        0,
        0,
        2,
        2
    };
    public void StartConfiguration() {
        SetQuestion(0);
    }
    public bool ValidatePrompt(int buttonIndex) {
        if(index <= 9) {
            Debug.Log(index);
            if(correctAnswerIndex[index] == buttonIndex)
            {
                index++;
                porcentage = porcentage + 10;
                porcentageText.text = porcentage.ToString() +"%"; 
                if(index <= 9)
                {
                    SetQuestion(index);
                }
                else 
                {
                    PromptText.text = "Completaste la configuración!";
                    Option1.text = "";
                    Option2.text = "";
                    Option3.text = "";
                    canvasHandler.MostrarMensaje("Felicidades!, completaste la configuración básica del switch");
                }
                return true;
            }
            else 
            {
                canvasHandler.MostrarMensaje("Opción incorrecta, busque el comando en el manual de configuración");
            }
            return false;
        } else {
            canvasHandler.MostrarMensaje("Felicidades!, completaste la configuración básica del switch");
            return false;
        }
    }
    void SetQuestion(int index){
        PromptText.text = settings[index];
        Option1.text = options[index,0];
        Option2.text = options[index,1];
        Option3.text = options[index,2];
        Debug.Log("OPCIONESSSSS"+ Option1.text);
    }
}
