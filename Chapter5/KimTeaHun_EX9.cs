using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KimTeaHun_EX9 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++){
            if (i % 3==0) {
                continue;
            }
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
