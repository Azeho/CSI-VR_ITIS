using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoController : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        Object[] photos = Resources.LoadAll("", typeof(Texture2D));
    }
}
