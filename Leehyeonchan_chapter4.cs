using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leehyeonchan_chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. i ++와 ++i의 차이점은 무엇인가요?
        // 전위증가인 ++i는 i의 값을 1 증가 시킨후에 증가된 값을 return 합니다
        // 후위증가인 i++는 i의 값을 1 증가 시킨 후에 , 증가되기 전의 값을 return 합니다

        //  2. 출력문 값 작성하세요
        int i = 1;
        Debug.Log(i = i + 1); 
        Debug.Log(i++); 
        Debug.Log(++i); 
        Debug.Log(i += 1);

        // 답은 각각
        //  Debug.Log(i = i + 1);  답 : 2
        //  Debug.Log(i++); 답 : 2
        //  Debug.Log(++i); 답 :4
        //  Debug.Log(i += 1); 답: 5

        //3. 다음 코드에서 B 는 어떤 값을 가질까요>?

        // int a = 10;
        // string b = a == 0 ? "가나다" : "ABC";

        int a = 10;
        string b = a == 0 ? "가나다" : "ABC";

        Debug.Log(b);

        // 답 : 한글인지 영어인지를 알려주는것!





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
