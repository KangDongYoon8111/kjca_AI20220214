using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeonSeonYu_Chapter5_ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string star = "";

        for (int x = 0; x < 5; x++)
        {
            for (int y = 0; y < 5; y++)
            {
                if (x < y)
                {
                    star += "¡Ù";
                }
                else
                {
                    star += "¡Ú";
                }

            }

            Debug.Log(star);
            star = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
