using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Management;

public class changeScene : MonoBehaviour
{

    public void MoveToScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void MoveToARScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
        var xrManagerSettings = XRGeneralSettings.Instance.Manager;
        xrManagerSettings.InitializeLoaderSync();
    }

    public void OutToARScene(int sceneID)
    {
       SceneManager.LoadScene(sceneID);
        var xrManagerSettings = XRGeneralSettings.Instance.Manager;
        xrManagerSettings.DeinitializeLoader();
    }

    public void quit()
    {
        Application.Quit();
    }
}
