using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActivateButtonOnClicked : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        button.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
    }
    private void OnMouseDown()
    {
        button.interactable = true;
        button.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
    }
}
