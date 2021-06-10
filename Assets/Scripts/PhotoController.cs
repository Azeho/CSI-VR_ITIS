using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class PhotoController : MonoBehaviour
{
    private Object[] photos;
    [SerializeField] private GameObject photoPrefab;
    [SerializeField] private GameObject photoSpawner;
    [SerializeField] private GameObject pinBoard;
    [SerializeField] private float offsetZ = 1f;
    [SerializeField] private float offsetY;
    private Vector3 parentTransform;

    private void Awake()
    {
        parentTransform = photoSpawner.transform.position;
    }

    public void LoadPhotos()
    {
        photos = Resources.LoadAll("", typeof(Texture2D));
        pinBoard.SetActive(true);
        for (int i = 0; i < 4; i++)
        {
            GameObject spawnedPhoto = Instantiate(photoPrefab, new Vector3(parentTransform.x, parentTransform.y,
                parentTransform.z - i), Quaternion.identity);
            Material mat = new Material(Shader.Find("Standard"));
        }
    }
}
