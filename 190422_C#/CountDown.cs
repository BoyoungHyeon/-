using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public Text txtCountDown;
    float countDown = 5.0f;
    bool isCountDown = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCountDown)
        {
            countDown -= Time.deltaTime;
            txtCountDown.text = "" + ((int)countDown + 1);

            if (countDown < 0)
            {
                txtCountDown.text = "";
            }
        }
    }
}
