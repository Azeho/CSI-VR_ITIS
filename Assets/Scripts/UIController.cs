using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class UIController : MonoBehaviour
{
    public static string PlayerName;
    private StringBuilder playerNameBuilder = new StringBuilder("", 12);
    [SerializeField] private TextMeshProUGUI displayName;
    [SerializeField] private TextMeshProUGUI UIName;
    [SerializeField] private GameObject maxCharactersCountError;
    [SerializeField] private GameObject enterNameError;
    [SerializeField] private GameObject playerUI;
    [SerializeField] private GameObject VRRig;
    [SerializeField] private GameObject menuUI;
    [SerializeField] private GameObject leftHandUI;
    [SerializeField] private GameObject rightHandUI;
    [SerializeField] private GameObject leftHand;
    [SerializeField] private GameObject rightHand;
    [SerializeField] private MovementProvider movementProvider;
    [SerializeField] private SnapTurnProviderBase snapTurnProvider;
    [SerializeField] private AudioSource startGameSound;

    void Update()
    {
        PlayerName = playerNameBuilder.ToString();
        displayName.text = PlayerName;
        UIName.text = PlayerName;
    }

    public void ChangeName(TextMeshProUGUI inputButton)
    {
        if (playerNameBuilder.Length < 12)
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
            leftHandUI.SetActive(false);
            rightHandUI.SetActive(false);
            leftHand.SetActive(true);
            rightHand.SetActive(true);
            VRRig.GetComponent<MovementProvider>().enabled = true;
            VRRig.GetComponent<SnapTurnProviderBase>().enabled = true;
            VRRig.gameObject.transform.position = new Vector3(2, 0, -9);
            VRRig.gameObject.transform.Rotate(0f, 110f, 0f, Space.World);
            startGameSound.PlayOneShot(startGameSound.clip, 0.5f);
        }
        else
        {
            maxCharactersCountError.SetActive(false);
            enterNameError.SetActive(true);
        }
            
    }
}
