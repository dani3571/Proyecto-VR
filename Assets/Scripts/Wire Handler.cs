using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireHandler : MonoBehaviour
{
    public bool isGrabbingWire = false;
    public GameObject wire;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag.Equals("Wires"))
        {
            wire = other.gameObject;
            isGrabbingWire = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag.Equals("Wires"))
        {
            wire = null;
            isGrabbingWire = false;
        }
    }
}
