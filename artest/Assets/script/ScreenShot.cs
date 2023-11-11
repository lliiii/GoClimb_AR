using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class ScreenShot : MonoBehaviour
{
    public GameObject UI;
    public GameObject shareDialog;

    private void Start()
    {
        shareDialog.SetActive(false);
    }
    private IEnumerator CaptureScreenshotAndShowUI()
    {
        // Deactivate the UI before taking the screenshot
        UI.SetActive(false);

        // Wait for the end of the frame to capture the screenshot
        yield return new WaitForEndOfFrame();

        // Capture the screenshot
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        texture.Apply();

        string name = "GoClimb_app" + System.DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".png";

        NativeGallery.SaveImageToGallery(texture, "GoClimb Picture", name);

        // Destroy the texture
        Destroy(texture);
        //show dialog
        shareDialog.SetActive(true);
        // Activate the UI again
        UI.SetActive(true);
    }

    public void TakeScreenshot()
    {
        // Start the coroutine to capture the screenshot and show the UI
        StartCoroutine(CaptureScreenshotAndShowUI());
    }

    public void shareScreenshot()
    {
        Application.OpenURL("https://goclimb.onrender.com/forum/");
    }

    public void closedialog()
    {
        shareDialog.SetActive(false);
    }

}

