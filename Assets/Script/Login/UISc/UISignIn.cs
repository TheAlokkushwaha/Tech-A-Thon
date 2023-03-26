using Michsky.UI.Shift;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISignIn : MonoBehaviour
{
    // [SerializeField] Text errorText;
    // [SerializeField] Canvas canvas;
    public GameObject Object;


    string username, password;

    void OnEnable()
    {
        MainPanelManager.OnSignInFailed.AddListener(OnSignInFailed);
        MainPanelManager.OnSignInSucess.AddListener(OnSignInSuccess);
    }
    void OnDisable()
    {
        MainPanelManager.OnSignInFailed.RemoveListener(OnSignInFailed);
        MainPanelManager.OnSignInSucess.RemoveListener(OnSignInSuccess);
    }
    void OnSignInFailed()
    {
        //errorText.text="Error to SignIn";
    }

    void OnSignInSuccess()
    {
       // errorText.gameObject.SetActive(true);
        //canvas.enabled = false;
    }

    public void UpdateUsername(string _username)
    {
        username = _username;
    }
    public void UpdatePassword(string _password)
    {
        password = _password;
    }

    public void SignIn()
    {
        MainPanelManager.Instance.SignIn(username, password);
    }


}
