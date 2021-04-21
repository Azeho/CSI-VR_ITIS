using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Flashlight : MonoBehaviour
{
    [SerializeField] private GameObject light;
    [SerializeField] private GameObject objectsToReveal;
    
    public void TurnOnOff()
    {
        if (!light.activeSelf)
        {
            light.SetActive(true);
            objectsToReveal.SetActive(true);
        }
        else
        {
            light.SetActive(false);
            objectsToReveal.SetActive(false);
        }
    }
    
}
