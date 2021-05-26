using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static string PlayerName;
    private StringBuilder playerNameBuilder;
    [SerializeField] private TextMeshProUGUI displayName;
    [SerializeField] private TextMeshProUGUI UIName;
    [SerializeField] private GameObject maxCharactersCountError;
    [SerializeField] private GameObject enterNameError;
    [SerializeField] private GameObject playerUI;
    [SerializeField] private GameObject VRRig;
    [SerializeField] private GameObject menuUI;
    
    void Update()
    {
        PlayerName = playerNameBuilder.ToString();
        displayName.text = PlayerName;
        UIName.text = PlayerName;
    }

    public void ChangeName(TextMeshProUGUI inputButton)
    {
        if (playerNameBuilder.Length <= 16)
            playerNameBuilder.Append(inputButton.text);
        else
        {
            enterNameError.SetActive(false);
            maxCharactersCountError.SetActive(true);
        }
            
    }

    public void StartGame()
    {
        if (playerNameBuilder.Length > 0)
        {
            menuUI.SetActive(false);
            playerUI.SetActive(true);
            VRRig.gameObject.transform.position = new Vector3(2, 0, -9);
            VRRig.gameObject.transform.Rotate(0f, 200f, 0f, Space.World);
        }
        else
        {
            maxCharactersCountError.SetActive(false);
            enterNameError.SetActive(true);
        }
            
    }
}
