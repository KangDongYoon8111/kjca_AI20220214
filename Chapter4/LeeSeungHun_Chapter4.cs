using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeeSeungHun_Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1 i++와 ++i의 차이점은 무엇인가요?
        int a = 10;
        Debug.Log(a++);
        Debug.Log(++a);
        //답 : i++의 경우 i배출이후 +1 이고
        //++i 의 경우 i배출이전 +1 입니다.

        //2 각 출력문의 값을 적으세요
        //int i = 1;
        //Debug.Log(i - i + 1); 답: 1
        //Debug.Log(i++);       답: 1
        //Debug.Log(++i);       답: 3
        //Debug.Log(i += 1);    답: 4
        //3. 다음 코드에서 b는 어떤 값을 가질까요? 
        //int a = 10;
        //string b = a == 0 ? "가나다" : "ABC";
        //답: ABC


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
