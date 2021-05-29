using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaseController : MonoBehaviour
{
    [SerializeField] private string collidderTag;
    private MeshRenderer renderer;

    private void Start()
    {
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(collidderTag))
        {
            renderer.enabled = true;
            other.GetComponent<MeshRenderer>().enabled = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(collidderTag))
        {
            renderer.enabled = false;
            other.GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
