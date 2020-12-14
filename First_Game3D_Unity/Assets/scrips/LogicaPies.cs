using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public LogicaPersonaje LogicaPersonaje;

    private void OnTriggerStay(Collider other)
    {
        LogicaPersonaje.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        LogicaPersonaje.puedoSaltar = false;
    }
}
