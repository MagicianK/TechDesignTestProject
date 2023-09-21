using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateButtonOnClicked : MonoBehaviour
{
    public Button button;

    private void OnMouseDown()
    {

        button.interactable = true;
        button.GetComponentInChildren<Text>().text = "Switch Level";
    }
}
