using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Leap;

public class ScoreBoard : MonoBehaviour
{
    public Text sweetsScore; // 옮긴 디저트 개수(점수)
    private int sweetsCount = 0; //초기 점수 값
    Controller controller;

    void Start()
    {
        controller = new Controller();
        sweetsScore = GameObject.Find("Score").GetComponent<Text>();
    }

    void Update()
    {
        Frame frame = controller.Frame();
        // do something with the tracking data in the frame... 
    }

    void OnTriggerEnter(Collider Get)
    {
        if (Get.gameObject.CompareTag("Sweets(T)"))
        {
            Get.gameObject.SetActive(false);
            sweetsCount += 1;

            // Update is called once per frame
            void Update()
            {

            }
        }
    }

    void GetSweets()
    {

        sweetsCount++;
        sweetsScore.text = sweetsCount + "개";

    }
}
