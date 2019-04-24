using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public Text timeText;
    private float time;
    private float realTime = 5f;



    void Start()
    {
      //  StartCoroutine(Example());
    }

    private void Awake()
    {
        StartCoroutine(Example());

        //time = 100f;

    }


    private void Update()
    {

        time -= Time.deltaTime;

        if (time>5f)
        {

            //  timeText.text = Mathf.Ceil(time).ToString();   //반올림
            timeText.text = string.Format("{0:N2}", time);
        }
    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(5);
        time = 100f;



        //   private int min;




    }

}



