using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WireHandler : MonoBehaviour
{
    public bool isGrabbingWire = false;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag.Equals("Wires"))
        {
            isGrabbingWire = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag.Equals("Wires"))
        {
            isGrabbingWire = false;
        }
    }
}
