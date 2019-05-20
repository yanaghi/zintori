using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CH : MonoBehaviour
{
    public Text cpuhand1;
    public Text cpuhand2;
    public Text cpuhand3;
    public Text cpuhand4;
    public Text cpuhand5;

    string[] hand = new string[3] { "Gu", "Choki", "Pa" };


    // Start is called before the first frame update
    void Start()
    {
        cpuhand1.text = hand[Random.Range(0, 3)];
        cpuhand2.text = hand[Random.Range(0, 3)];
        cpuhand3.text = hand[Random.Range(0, 3)];
        cpuhand4.text = hand[Random.Range(0, 3)];
        cpuhand5.text = hand[Random.Range(0, 3)];
    }

   

    // Update is called once per frame
    void Update()
    {
       
    }

    public string Getcpuhand(int n)
    {
        if (n == 1)
        {
            return cpuhand1.text;
        }
        else if (n == 2)
        {
            return cpuhand2.text;
        }
        else if (n == 3)
        {
            return cpuhand3.text;
        }
        else if (n == 4)
        {
            return cpuhand4.text;
        }
        else
        {
            return cpuhand5.text;
        }
    }

}
