using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5_kimtaehun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string i = "100";
        int j = int.Parse(i);
        if (j > 50) {
            Debug.Log("50이상입니다.");
        }
        else if(j<50){
            Debug.Log("50이하입니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
