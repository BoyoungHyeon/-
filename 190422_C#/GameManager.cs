/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    public Text timeText; //제한 시간 표기 
    private float time; // 카운트 다운포함 러닝타임
    private float realTime; // 실질적 100초

    private Text sweetsScore; // 옮긴 디저트 개수(점수)
    private int sweetsCount = 0; //초기 점수 값
    private int finish = 1;


    void Start()
    {

        sweetsScore = GameObject.Find("Score").GetComponent<Text>();
    }

    private void Awake()
    {
        StartCoroutine(Example());


    }


    private void Update()
    {

        time -= Time.deltaTime;

        if (time > 5f)
        {

            //  timeText.text = Mathf.Ceil(time).ToString();   //반올림
            timeText.text = string.Format("{0:N2}", time);
        }

        if (finish == 0)
        {
            time += Time.deltaTime;
            SetCountText();
        }
        
    }

    IEnumerator Example()
    {

        yield return new WaitForSeconds(5);
        time = 100f;
    }

    /* void OnTriggerEnter(Collider Get)
     {

         //부딪힌 오브젝트의 태그가 sweets인 경우 Count를 1씩 증가시킨다. 
         if (Get.collider.tag == "Sweets")
         {
             getCount += 1;
         }
         }
        */
        /*
    void OnTriggerEnter(Collider Get)
    {
        if (Get.gameObject.CompareTag("Sweets(T)"))
        {
            Get.gameObject.SetActive(false);
            sweetsCount += 1;
        }

    }
    void SetCountText()
    {
        if (time != 0)
        {
            sweetsScore.text = sweetsCount.ToString();

            {
                if (time < 0)
                {
                    time = 0;



                    SceneManager.LoadScene("s04_Level01_score");
                    finish = 1;
                }



            }
        }
    }
}


/*
{ //쟁반에 담은 디저트의 개수 텍스트 표기

void GetSweets()
{

sweetsCount++;
sweetscore.text = sweetsCount + "개";

}



    public int Count;               //떨어지는 박스의 갯수 세기. 사용자가 담는 디저트 갯수 세기
    public float _time;             //박스가 떨어지기까지 걸리는 시간재기. 
    public GUIText Text_time;       //시간 표기를 위한 GUIText.
    public GameObject ClearGUI;     //클리어 했을 시 나올 GUI 모음.


    public GameObject Replay_Button_Obj;
    public GUITexture Replay_Button;


    void OnTriggerEnter(Collider Get)
    {

        //부딪힌 오브젝트의 태그가 sweets인 경우 Count를 1씩 증가시킨다. 
        if (Get.collider.tag == "sweets")
        {
            Count += 1;
        }

    

        //Count가 16보다 커지면 End 를 활성화한다. 시간제한
        if (Count >= 16 && End == false)
        {
            End = true;
            ClearGUI.SetActive(true);
            Replay_Button_Obj.SetActive(true);
        }
    }


    void Update()
    {

        //_time 의 값을 GUIText의 글씨에 표기해준다.   
        Text_time.text = _time.ToString();

    }

    void GUI_Check()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if (Replay_Button.HitTest
             (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)))
            {
                Application.LoadLevel(0);
            }
        }
    }

} 


*/


