using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.IO;

public class TakePicture : MonoBehaviour
{
    [SerializeField] private GameObject light;

    private int resWidth = 1920;
    private int resHeight = 1080;
    public int FileCounter = 0;

    private void Awake()
    {
        
    }

    public void Shoot()
    {
        light.SetActive(true);
        /*Camera Cam = GetComponent<Camera>();
 
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture.active = Cam.targetTexture;
 
        Cam.Render();
 
        Texture2D Image = new Texture2D(resWidth, resHeight);
        Image.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        Image.Apply();
        RenderTexture.active = currentRT;
 
        var Bytes = Image.EncodeToPNG();
        Destroy(Image);
 
        File.WriteAllBytes(Application.dataPath + "/CluePhotos/" + FileCounter + ".png", Bytes);
        FileCounter++;*/
        light.SetActive(false);
    }
}
