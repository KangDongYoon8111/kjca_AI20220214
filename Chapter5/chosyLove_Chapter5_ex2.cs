using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chosyLove_Chapter5_ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "60";
        int number = int.Parse(userInput);

        if (number >= 50)
        {
            if(number%3 == 0) //3의 배수일 때
                Debug.Log($"{number}은(는) 50이상의 수이며 3의 배수입니다.");
            else
                Debug.Log($"{number}은(는) 50이상의 수이며 3의 배수가 아닙니다.");
        }
            
        else
        {
            if (number % 3 == 0) //3의 배수일 때
                Debug.Log($"{number}은(는) 50미만의 수이며 3의 배수입니다.");
            else
                Debug.Log($"{number}은(는) 50미만의 수이며 3의 배수가 아닙니다.");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
