using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry_Update : MonoBehaviour
{
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Scene_Manager.gameOver) {
            animator.SetBool("isGmaeOver", true);
        }
    }

    

    void onGameOver()
    {
        Scene_Manager.gameOver = true;
    }

}
