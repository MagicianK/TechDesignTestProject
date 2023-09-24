using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;
using UnityEngine.UI;

public class ActivateButtonOnClicked : MonoBehaviour
{
    public Button button;
    public AudioSource source;
    private void Start()
    {
        button.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
    }
    private void OnMouseDown()
    {
        button.interactable = true;
        button.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
        source.Play();
    }
}
