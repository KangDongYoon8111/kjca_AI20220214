using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leehyeonchan_chapter5_ex6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "10";
        string userInput2 = "2";
        string userInput3 = "+";


        int number1 = int.Parse(userInput1);
        int number2 = int.Parse(userInput2);
        int number3 = int.Parse(userInput3);


        // 에러 해결 실패 자바랑 확실히 차이점이 있는듯 하네용
        switch (userInput1)
        {
            case "+":
                Debug.Log(($"입력하신 {userInput1}+{userInput2} 의 값은 {userInput1 + userInput2}입니다"));
                break;

                //전 해결 못함 
                //   switch (number1)
                //  {
                //    case "+":
                //       Debug.Log($"입력하신{number1}{number3}{number2}의 값은  {10+2} 입니다");
                //        break;
                //
                //    case "*":
                //       Debug.Log($"입력하신{number1}{number3}{number2}의 값은  {10 * 2} 입니다");
                //       break;


                //  }


        }

    // Update is called once per frame
    void Update()
        {
            
    }

