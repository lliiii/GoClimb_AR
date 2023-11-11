using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Vuforia;
using UnityEngine.Networking;
using System;
using Unity.VisualScripting;
using UnityEngine.UI;

public class startVbC : MonoBehaviour
{
    public GameObject Startvbutton;
    public GameObject stopvbutton;

    public GameObject EStartvbutton;
    public GameObject Estopvbutton;

    public GameObject Hstartvbutton2;
    public GameObject Hstopbutton2;

    public GameObject EStartvbutton2;
    public GameObject Estopvbutton2;

    public GameObject Hstartvbutton3;
    public GameObject Hstopbutton3;

    public GameObject EStartvbutton3;
    public GameObject Estopvbutton3;

    public GameObject Hstartvbutton4;
    public GameObject Hstopbutton4;

    public GameObject EStartvbutton4;
    public GameObject Estopvbutton4;

    public Timer timer;

    public GameObject uiPanel;
    public GameObject Dialog;
    public GameObject FinishDialog;

    private VirtualButtonBehaviour HstartButtonBehaviour;
    private VirtualButtonBehaviour HstopButtonBehaviour;

    private VirtualButtonBehaviour EstartButtonBehaviour;
    private VirtualButtonBehaviour EstopButtonBehaviour;

    private VirtualButtonBehaviour HstartButtonBehaviour2;
    private VirtualButtonBehaviour HstopButtonBehaviour2;

    private VirtualButtonBehaviour EstartButtonBehaviour2;
    private VirtualButtonBehaviour EstopButtonBehaviour2;

    private VirtualButtonBehaviour HstartButtonBehaviour3;
    private VirtualButtonBehaviour HstopButtonBehaviour3;

    private VirtualButtonBehaviour EstartButtonBehaviour3;
    private VirtualButtonBehaviour EstopButtonBehaviour3;

    private VirtualButtonBehaviour HstartButtonBehaviour4;
    private VirtualButtonBehaviour HstopButtonBehaviour4;

    private VirtualButtonBehaviour EstartButtonBehaviour4;
    private VirtualButtonBehaviour EstopButtonBehaviour4;

    public TextMeshProUGUI finishTimeText;


    private VirtualButtonBehaviour completedButton;

    //get date
    DateTime getdate = DateTime.Now;

    //upload message
    public GameObject image;
    public TextMeshProUGUI text;


    void Start()
    {
        //first
        Startvbutton = GameObject.Find("HstartButton");
        HstartButtonBehaviour = Startvbutton.GetComponent<VirtualButtonBehaviour>();
        HstartButtonBehaviour.RegisterOnButtonPressed(OnStartButtonPressed);
        HstartButtonBehaviour.RegisterOnButtonReleased(OnButtonReleased);

        stopvbutton = GameObject.Find("HstopButton");
        HstopButtonBehaviour = stopvbutton.GetComponent<VirtualButtonBehaviour>();
        HstopButtonBehaviour.RegisterOnButtonPressed(OnStopButtonPressed);
        HstopButtonBehaviour.RegisterOnButtonReleased(OnButtonReleased);
        

        EStartvbutton = GameObject.Find("EstartButton");
        EstartButtonBehaviour = EStartvbutton.GetComponent<VirtualButtonBehaviour>();
        EstartButtonBehaviour.RegisterOnButtonPressed(OnStartButtonPressed);
        EstartButtonBehaviour.RegisterOnButtonReleased(OnButtonReleased);

        Estopvbutton = GameObject.Find("EstopButton");
        EstopButtonBehaviour = Estopvbutton.GetComponent<VirtualButtonBehaviour>();
        EstopButtonBehaviour.RegisterOnButtonPressed(OnStopButtonPressed);
        EstopButtonBehaviour.RegisterOnButtonReleased(OnButtonReleased);

        //2nd
        Hstartvbutton2 = GameObject.Find("HstartButton2");
        HstartButtonBehaviour2 = Hstartvbutton2.GetComponent<VirtualButtonBehaviour>();
        HstartButtonBehaviour2.RegisterOnButtonPressed(OnStartButtonPressed);
        HstartButtonBehaviour2.RegisterOnButtonReleased(OnButtonReleased);

        Hstopbutton2 = GameObject.Find("HstopButton2");
        HstopButtonBehaviour2 = Hstopbutton2.GetComponent<VirtualButtonBehaviour>();
        HstopButtonBehaviour2.RegisterOnButtonPressed(OnStopButtonPressed);
        HstopButtonBehaviour2.RegisterOnButtonReleased(OnButtonReleased);

        EStartvbutton2 = GameObject.Find("EstartButton2");
        EstartButtonBehaviour2 = EStartvbutton2.GetComponent<VirtualButtonBehaviour>();
        EstartButtonBehaviour2.RegisterOnButtonPressed(OnStartButtonPressed);
        EstartButtonBehaviour2.RegisterOnButtonReleased(OnButtonReleased);

        Estopvbutton2 = GameObject.Find("EstopButton2");
        EstopButtonBehaviour2 = Estopvbutton2.GetComponent<VirtualButtonBehaviour>();
        EstopButtonBehaviour2.RegisterOnButtonPressed(OnStopButtonPressed);
        EstopButtonBehaviour2.RegisterOnButtonReleased(OnButtonReleased);

        //3rd
        Hstartvbutton3 = GameObject.Find("HstartBtn3");
        HstartButtonBehaviour3 = Hstartvbutton3.GetComponent<VirtualButtonBehaviour>();
        HstartButtonBehaviour3.RegisterOnButtonPressed(OnStartButtonPressed);
        HstartButtonBehaviour3.RegisterOnButtonReleased(OnButtonReleased);

        Hstopbutton3 = GameObject.Find("HstopBtn3");
        HstopButtonBehaviour3 = Hstopbutton3.GetComponent<VirtualButtonBehaviour>();
        HstopButtonBehaviour3.RegisterOnButtonPressed(OnStopButtonPressed);
        HstopButtonBehaviour3.RegisterOnButtonReleased(OnButtonReleased);

        EStartvbutton3 = GameObject.Find("EstartBtn3");
        EstartButtonBehaviour3 = EStartvbutton3.GetComponent<VirtualButtonBehaviour>();
        EstartButtonBehaviour3.RegisterOnButtonPressed(OnStartButtonPressed);
        EstartButtonBehaviour3.RegisterOnButtonReleased(OnButtonReleased);

        Estopvbutton3 = GameObject.Find("EstopBtn3");
        EstopButtonBehaviour3 = Estopvbutton3.GetComponent<VirtualButtonBehaviour>();
        EstopButtonBehaviour3.RegisterOnButtonPressed(OnStopButtonPressed);
        EstopButtonBehaviour3.RegisterOnButtonReleased(OnButtonReleased);

        //4th
        Hstartvbutton4 = GameObject.Find("HstartBtn4");
        HstartButtonBehaviour4 = Hstartvbutton4.GetComponent<VirtualButtonBehaviour>();
        HstartButtonBehaviour4.RegisterOnButtonPressed(OnStartButtonPressed);
        HstartButtonBehaviour4.RegisterOnButtonReleased(OnButtonReleased);

        Hstopbutton4 = GameObject.Find("HstopBtn4");
        HstopButtonBehaviour4 = Hstopbutton4.GetComponent<VirtualButtonBehaviour>();
        HstopButtonBehaviour4.RegisterOnButtonPressed(OnStopButtonPressed);
        HstopButtonBehaviour4.RegisterOnButtonReleased(OnButtonReleased);

        EStartvbutton4 = GameObject.Find("EstartBtn4");
        EstartButtonBehaviour4 = EStartvbutton4.GetComponent<VirtualButtonBehaviour>();
        EstartButtonBehaviour4.RegisterOnButtonPressed(OnStartButtonPressed);
        EstartButtonBehaviour4.RegisterOnButtonReleased(OnButtonReleased);

        Estopvbutton4 = GameObject.Find("EstopBtn4");
        EstopButtonBehaviour4 = Estopvbutton4.GetComponent<VirtualButtonBehaviour>();
        EstopButtonBehaviour4.RegisterOnButtonPressed(OnStopButtonPressed);
        EstopButtonBehaviour4.RegisterOnButtonReleased(OnButtonReleased);

        HstopButtonBehaviour.enabled = false;
        HstopButtonBehaviour.enabled = false;

        EstartButtonBehaviour.enabled = false;
        EstopButtonBehaviour.enabled = false;

        HstopButtonBehaviour2.enabled = false;
        HstopButtonBehaviour2.enabled = false;

        EstartButtonBehaviour2.enabled = false;
        EstopButtonBehaviour2.enabled = false;

        HstopButtonBehaviour3.enabled = false;
        HstopButtonBehaviour3.enabled = false;

        EstartButtonBehaviour3.enabled = false;
        EstopButtonBehaviour3.enabled = false;

        HstopButtonBehaviour4.enabled = false;
        HstopButtonBehaviour4.enabled = false;

        EstartButtonBehaviour4.enabled = false;
        EstopButtonBehaviour4.enabled = false;

        // disable
        uiPanel.SetActive(false);
        Dialog.SetActive(false);
        FinishDialog.SetActive(false);
        image.SetActive(false); 
         
    }

    public void OnStartButtonPressed(VirtualButtonBehaviour vb)
    {
        
            timer.StartTimer();
    }

    public void OnStopButtonPressed(VirtualButtonBehaviour vb)
    {
        completedButton = vb;
        timer.StopTimer();
        FinishDialog.SetActive(true);
        string timestring = timer.GetFormattedTime();
        finishTimeText.text = timestring;
    }

    private VirtualButtonBehaviour GetCompletedVirtualButton()
    {
        return completedButton;
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
        Debug.Log("Button Released");
    }

    public void EnableVirtualButtons()
    {
        EstartButtonBehaviour.enabled = true;
        EstopButtonBehaviour.enabled = true;

        HstartButtonBehaviour.enabled = true;
        HstopButtonBehaviour.enabled = true;

        EstartButtonBehaviour2.enabled = true;
        EstopButtonBehaviour2.enabled = true;

        HstartButtonBehaviour2.enabled = true;
        HstopButtonBehaviour2.enabled = true;

        EstartButtonBehaviour3.enabled = true;
        EstopButtonBehaviour3.enabled = true;

        HstartButtonBehaviour3.enabled = true;
        HstopButtonBehaviour3.enabled = true;

        EstartButtonBehaviour4.enabled = true;
        EstopButtonBehaviour4.enabled = true;

        HstartButtonBehaviour4.enabled = true;
        HstopButtonBehaviour4.enabled = true;


        uiPanel.SetActive(true);
        Dialog.SetActive(false);
    }

    public void showDialog()
    {
        Dialog.SetActive(true);
    }

    public void DisableVirtualButtons()
    {
        EstartButtonBehaviour.enabled = false;
        EstopButtonBehaviour.enabled = false;

        HstartButtonBehaviour.enabled = false;
        HstopButtonBehaviour.enabled = false;

        EstartButtonBehaviour2.enabled = false;
        EstopButtonBehaviour2.enabled = false;

        HstartButtonBehaviour2.enabled = false;
        HstopButtonBehaviour2.enabled = false;

        HstopButtonBehaviour3.enabled = false;
        HstopButtonBehaviour3.enabled = false;

        EstartButtonBehaviour3.enabled = false;
        EstopButtonBehaviour3.enabled = false;

        HstopButtonBehaviour4.enabled = false;
        HstopButtonBehaviour4.enabled = false;

        EstartButtonBehaviour4.enabled = false;
        EstopButtonBehaviour4.enabled = false;

        uiPanel.SetActive(false);
    }

    public void CloseFinishDialog()
    {
        FinishDialog.SetActive(false);
    }

    public void uploadData()
    {
        VirtualButtonBehaviour currentButton = GetCompletedVirtualButton();
        if (currentButton != null)
        {
            string formattedDate = getdate.ToString("yyyy-MM-ddTHH:mm:ss");
            string timestring = timer.GetFormattedTime();

            string locName;
            int distance;

            if (currentButton == HstopButtonBehaviour)
            {
                locName = "El Mosquitero(hard)";
                distance = 8;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
            else if (currentButton == EstopButtonBehaviour)
            {
                locName = "El Mosquitero(Easy)";
                distance = 5;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
            else if (currentButton == EstopButtonBehaviour2)
            {
                locName = "Balmoral Island(Easy)";
                distance = 5;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
            else if (currentButton == HstopButtonBehaviour2)
            {
                locName = "Balmoral Island(hard)";
                distance = 5;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
            else if (currentButton == EstopButtonBehaviour3)
            {
                locName = "Goa Pawon-Borku(Easy)";
                distance = 13;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
            else if (currentButton == HstopButtonBehaviour3)
            {
                locName = "Goa Pawon-Terpesona(hard)";
                distance = 15;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
            else if (currentButton == EstopButtonBehaviour4)
            {
                locName = "Goa Pawon-Nasehat Pak Hendi(Easy)";
                distance = 15;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
            else if (currentButton == HstopButtonBehaviour4)
            {
                locName = "Goa Pawon-N.A.(hard)";
                distance = 15;
                StartCoroutine(postRequest("https://goclimb.onrender.com/ARcreateClimbActivity/", timestring, formattedDate, locName, distance));
            }
        }
    }

    IEnumerator postRequest(string url, string time, string formattedDate, string locName, int diatance)
    {
        WWWForm form = new WWWForm();
        //form.AddField("user", "Jojo");
        form.AddField("locName", locName);
        form.AddField("distance", diatance);
        form.AddField("date", formattedDate);
        form.AddField("timeCompleted", time);

        UnityWebRequest uwr = UnityWebRequest.Post(url, form);
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
                Debug.Log(response.message);
                text.text = "Update Success";
                image.SetActive(true);
                //text.enabled = true;

                // hide Text UI
                StartCoroutine(HideTextUI());
            }
            else
            {
                Debug.Log("Update failed. Error: " + response.message);
                text.text = "Update failed" + response.message;
                image.SetActive(true);
                StartCoroutine(HideTextUI());
            }
        }
    }

    IEnumerator HideTextUI()
    {
        yield return new WaitForSeconds(3f); // 5 secd

        // hide Text UI
        image.SetActive(false);
        //text.SetActive(false);
    }
}
