using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using System.IO;

public class TakePicture : MonoBehaviour
{
    [SerializeField] private GameObject light;

    [SerializeField] private int resWidth = 1920;
    [SerializeField] private int resHeight = 1080;
    private int FileCounter = 0;
    private AudioSource flashSound;


    private Camera myCamera;
    private bool takeScreenshotOnNextFrame;

    private void Start()
    {
        flashSound = GetComponentInParent<AudioSource>();
    }

    public void ShootActivate()
    {
        light.SetActive(true);
        flashSound.PlayOneShot(flashSound.clip, 0.1f);
        CamCapture();
    }

    public void ShootDeactivate()
    {
        light.SetActive(false);
    }

    void CamCapture()
    {
        Camera Cam = GetComponent<Camera>();
 
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture.active = Cam.targetTexture;
 
        Cam.Render();
 
        Texture2D Image = new Texture2D(Cam.targetTexture.width, Cam.targetTexture.height);
        Image.ReadPixels(new Rect(0, 0, Cam.targetTexture.width, Cam.targetTexture.height), 0, 0);
        Image.Apply();
        RenderTexture.active = currentRT;
 
        var Bytes = Image.EncodeToPNG();
        Destroy(Image);
 
        File.WriteAllBytes(Application.dataPath + "/Resources/" + FileCounter + ".png", Bytes);
        FileCounter++;
    }
}
