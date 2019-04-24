/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{

    [Header("LoginPanel")]
    public InputField ID;
    public InputField PW;

    [Header("CreateaccountPanel")]
    public InputField NewID;
    public InputField NewPW;

    public string LogineUrl; 
    }

    public void LoginBtn()
    {
        StartCoroutine(LoginCo());
    }

    IEnumerator LoginCo()
    {
        Debug.Log(ID.text);



        yield return null;
    }


    public void CreateaccountBtn() //계정 만들기
    {
        StartCoroutine(LoginCo());
    }
    */