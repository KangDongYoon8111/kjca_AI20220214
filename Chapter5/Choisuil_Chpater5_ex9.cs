using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choisuil_Chpater5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1~10까지 정수 중에서 3으로 나누어 떨어지지 않는 수를
        //출력하고, 이 수들의 합을 출력

        int result = 0;

        for(int i = 0; i < 11; i++) {
            if(i % 3 == 0) {
                continue;
            }
            Debug.Log($"{i}");
            result += i;
    }
        Debug.Log($"1~10중 3으로 나누어 떨어지지 않는 수의 합 : {result}");

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
