using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TInformLv1 : MonoBehaviour
{
    public float delay = 0.1f;
    public string fullText;
    private string InformLv1;

    void Start()
    {
        StartCoroutine(ShowText());
    }


  IEnumerator ShowText()
    {
        for(int i=0; i<fullText.Length; i++)
        {
            InformLv1 = fullText.Substring(0, i);
            this.GetComponent<Text>().text = InformLv1;
            yield return new WaitForSeconds(delay);
        }
    }
}
