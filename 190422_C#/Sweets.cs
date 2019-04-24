using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Leap; //립(모션)쓴다.

/* 디저트 쟁반 닿는 순간 파괴 코드*/

public class Sweets : MonoBehaviour//모노비헤이비어는 상속받은 클래스
{

    void putontray(Collider col) //putontray라는 함수 안에 콜라이더 콜이 있고
    {
        if (col.gameObject.name == "TrayWood") //콜라이더 있는 게임오브젝트 얘들 태그가 "Sweets"이면

        {
            GameObject.Find("GameManager").SendMessage("GetSweets");
            Destroy(gameObject); // 나무쟁반과 부딛히면 디저트를 파괴해          

        }
    }
}
