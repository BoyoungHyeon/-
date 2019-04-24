using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Manager : MonoBehaviour
{

    public static bool gameOver;
    public Text timeText;
    private float time;

    void Awake()
    {
        StartCoroutine(Example());
        gameOver = false;
    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(5);
        time = 100f;
    }

        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameOver && Input.Input.GetMouseButtonDown(0))


        { }
    }
}
