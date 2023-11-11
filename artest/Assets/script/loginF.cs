using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


using UnityEngine.SceneManagement;

[System.Serializable]
public class ServerResponse
{
    public bool success;
    public string message;
}

public class loginF : MonoBehaviour
{

    public TMP_InputField usernameInput; // Reference to the InputField for username
    public TMP_InputField passwordInput;

    public Image image;
    public TMP_Text text;

    public string successMessage = "Login Successfully";
    public float requestTimeout = 10.0f;

    private void Start()
    {
        image.enabled = false; // disable
        text.enabled = false;
    }

    public void Login()
    {
        string username = usernameInput.text; // Get the username from the InputField
        string password = passwordInput.text;

        StartCoroutine(postRequest("https://goclimb.onrender.com/loginAR/",username, password));
    }

    IEnumerator postRequest(string url, string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("password", password);

        UnityWebRequest uwr = UnityWebRequest.Post(url, form);     
        uwr.timeout = Mathf.CeilToInt(requestTimeout);

        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Network Error: " + uwr.error);
        }
        else
        {
            //Debug.Log("Server Response: " + uwr.downloadHandler.text);
            string responseText = uwr.downloadHandler.text;
            Debug.Log("Server Response: " + responseText);

            // Ω‚ŒˆJSONœÏ”¶
            ServerResponse response = JsonUtility.FromJson<ServerResponse>(responseText);

            if (response != null && response.success)
            {
                // login success
                Debug.Log(successMessage);
                SceneManager.LoadScene("MainPage");

                //display success message
                text.text = "Login Success";
                image.enabled = true;
                text.enabled = true;

                // hide Text UI
                StartCoroutine(HideTextUI());
            }
            else
            {
                Debug.Log("Login failed. Error: " + response.message);

                //display error message
                text.text = "Login Failed" + response.message;
                image.enabled = true;
                text.enabled = true;

                // hide Text UI
                StartCoroutine(HideTextUI());
            }
        }
    }

    IEnumerator HideTextUI()
    {
        yield return new WaitForSeconds(3f); // 5 secd

        // hide Text UI
        image.enabled = false;
        text.enabled = false;
    }

}
