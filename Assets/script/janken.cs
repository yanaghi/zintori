using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class janken : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string p = "Player";
        string c = "CPU";
        int[] power = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, };
        int psp = power[4];
        int csp = power[Random.Range(0, 9)];
        Debug.Log(p + "の兵力は" + psp);
        Debug.Log(c + "の兵力は" + csp);
        //数値で勝負するってとこだけ
        if (psp == csp)
        {
            Debug.Log("引き分けです！");
        } else{
            if (psp > csp)
            {
                Debug.Log(p + "の勝利！");
            }
            else
            {
                Debug.Log(p + "の負け…");
            }
           
        }

    }
  
  
         
    
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
