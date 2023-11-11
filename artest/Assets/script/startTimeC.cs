using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class startTimeC : MonoBehaviour
{
    public GameObject startButton; // Drag your Virtual Button GameObject here
    public GameObject endButton;
    private bool isButtonEnabled = false;

    // Add any other necessary variables or references here

    private void Start()
    {
        // Disable the Virtual Button at the start
        SetVirtualButtonState(false);
    }

    public void EnableVirtualButton()
    {
        // Enable the Virtual Button
        SetVirtualButtonState(true);
    }

    public void DisableVirtualButton()
    {
        // Disable the Virtual Button
        SetVirtualButtonState(false);
    }

    private void SetVirtualButtonState(bool isEnabled)
    {
        if (startButton != null)
        {
            VirtualButtonBehaviour vb = startButton.GetComponent<VirtualButtonBehaviour>();
            if (vb != null)
            {
                vb.enabled = isEnabled;
                isButtonEnabled = isEnabled;
            }
        }
    }

}
