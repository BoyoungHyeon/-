using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BacktoLv1Inform : MonoBehaviour
{
  
    public void BtLv1Click()
    {
        SceneManager.LoadScene("s02_StartLv01");
    }
}
