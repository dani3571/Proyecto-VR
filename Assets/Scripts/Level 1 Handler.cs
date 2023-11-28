using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Handler : MonoBehaviour
{
    public string assignedPort = "F0/1";
    [SerializeField]
    ConfigurationHandler configurationHandler;
    [SerializeField]
    GameObject canvasConfiguration;
    [SerializeField]
    GameObject laptopWire;
    public bool laptopIsConected;
    public bool portIsCorrect;
    public bool laptopIsPositioned;
    void Start() {
        canvasConfiguration.SetActive(false);
        laptopIsConected = false;
        portIsCorrect = false;
        laptopIsPositioned = false;
        laptopWire.SetActive(false);
    }
    public void StartLevel1() {
        canvasConfiguration.SetActive(true);
        configurationHandler.StartConfiguration();
    }
    public void Connect() {
        laptopWire.SetActive(true);
        laptopIsConected = true;
    }
}
