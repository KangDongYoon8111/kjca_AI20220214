using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimGyuRI_Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1. i++ 와 ++i 의 차이점은 무엇인가요? 선출력 후 계산 / 선계산후출력
        //2. 각 출력문의 값을 적으세요
        int i = 1;
        Debug.Log(i = i + 1); 답: 2
            Debug.Log(i++); 답: 2
            Debug.Log (++i) 답: 4
            Debug.Log(i += 1); 답 5
            //3. 다음코드에서 b는 어떤 값을 가질까요?
            int a = 10;
        string b = a == 0 ? "가나다" : "ABC"; ABC        //
        //
        //


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
