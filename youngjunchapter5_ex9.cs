using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youngjunchapter5_ex9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            if (i % 3 == 0)
            {
                continue;
            }
            else
            

                Debug.Log(i);
                sum += i;

        }
    }
        
    // Update is called once per frame
    void Update()
    {
        
    }
}
