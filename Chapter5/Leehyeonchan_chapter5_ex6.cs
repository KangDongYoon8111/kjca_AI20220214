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


        // ���� �ذ� ���� �ڹٶ� Ȯ���� �������� �ִµ� �ϳ׿�
        switch (userInput1)
        {
            case "+":
                Debug.Log(($"�Է��Ͻ� {userInput1}+{userInput2} �� ���� {userInput1 + userInput2}�Դϴ�"));
                break;

                //�� �ذ� ���� 
                //   switch (number1)
                //  {
                //    case "+":
                //       Debug.Log($"�Է��Ͻ�{number1}{number3}{number2}�� ����  {10+2} �Դϴ�");
                //        break;
                //
                //    case "*":
                //       Debug.Log($"�Է��Ͻ�{number1}{number3}{number2}�� ����  {10 * 2} �Դϴ�");
                //       break;


                //  }


        }

    // Update is called once per frame
    void Update()
        {
            
    }

