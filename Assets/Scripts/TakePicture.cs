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


    private Camera myCamera;
    private bool takeScreenshotOnNextFrame;

    /*private void Awake()
    {
        myCamera = gameObject.GetComponentInChildren<Camera>();
    }

    private void OnPostRender()
    {
        if (takeScreenshotOnNextFrame)
            takeScreenshotOnNextFrame = false;

        RenderTexture renderTexture = myCamera.targetTexture;
        Texture2D renderResult = 
            new Texture2D(renderTexture.height, renderTexture.width, TextureFormat.ARGB32, false);
        Rect rect = new Rect(0, 0, renderTexture.width, renderTexture.height);
        renderResult.ReadPixels(rect, 0, 0);

        byte[] byteArray = renderResult.EncodeToJPG();
        System.IO.File.WriteAllBytes(Application.dataPath + "/CameraScreenshot" + $"{FileCounter}" + ".png", byteArray);
        FileCounter++;
        
        RenderTexture.ReleaseTemporary(renderTexture);
        myCamera.targetTexture = null;
    }*/

    public void ShootActivate()
    {
        light.SetActive(true);
        /*TakeScreenshot(resWidth, resHeight);*/
    }

    public void ShootDeactivate()
    {
        light.SetActive(false);
    }

    /*private void TakeScreenshot(int width, int height)
    {
        myCamera.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        takeScreenshotOnNextFrame = true;
    }*/
}
