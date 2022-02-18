using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosyLove_Chapter5_ex5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "4";
        string userInput1 = "61";
        int sy = int.Parse(userInput);
        int score = int.Parse(userInput1);

        if (sy == 4)
        {
            if (score >= 70 && score <= 100)
                Debug.Log($"{sy}학년 {score}점 - 합격");
            else if (score < 70 && score >= 0)
                Debug.Log($"{sy}학년 {score}점 - 불합격");
            else
                Debug.Log($"{sy}학년 {score}점 - 경고 다시 입력하세요.");
        }
        else
        {
            if (score >= 60 && score <= 100)
                Debug.Log($"{sy}학년 {score}점 - 합격");
            else if (score < 60 && score >= 0)
                Debug.Log($"{sy}학년 {score}점 - 불합격");
            else
                Debug.Log($"{sy}학년 {score}점 - 경고 다시 입력하세요.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
