using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leehyeonchan_chapter5_ex02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a;
        a = 70;

        if(a>50){
            Debug.Log($"{a}는 50보다 큰 수 입니다.");
            
        }

        else
        {
            Debug.Log($"{a}는 50보다 작은 수 입니다.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
