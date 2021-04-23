using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealFingerprints : MonoBehaviour
{
    [SerializeField] private GameObject Fingerprints;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Brush")
        {
            Fingerprints.SetActive(true);
        }
    }
}
