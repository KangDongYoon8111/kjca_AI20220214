using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosyLove_Chapter5_ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput1 = "60";
        string userInput2 = "75";
        string userInput3 = "100";
        int number1 = int.Parse(userInput1); 
        int number2 = int.Parse(userInput2); 
        int number3 = int.Parse(userInput3);
        int max;
        int min;
        int sum = number1 + number2 + number3;
        int aver = sum / 3;

        if (number1 > number2 && number1 > number3)
        {
            max = number1;
        }
        else if (number2 > number1 && number2 > number3)
        {
            max = number2;
        }
        else
            max = number3;

        if (number1 < number2 && number1 < number3)
        {
            min = number1;
        }
        else if (number2 < number1 && number2 < number3)
        {
            min = number2;
        }
        else
            min = number3;

        Debug.Log($"최대값은 {max}입니다.");
        Debug.Log($"최소값은 {min}입니다.");
        Debug.Log($"합계는 {sum}입니다.");
        Debug.Log($"평균값은 {aver}입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
