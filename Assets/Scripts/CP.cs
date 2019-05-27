using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CP : MonoBehaviour
{
    public Text cpuPower1;
    public Text cpuPower2;
    public Text cpuPower3;
    public Text cpuPower4;
    public Text cpuPower5; 

    int[] cp = new int[] { 10, 20, 30, 40, 50 };

   

    // Start is called before the first frame update
    void Start()
    {
        System.Random rng = new System.Random();
        int n = cp.Length;

        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            int tmp = cp[k];
            cp[k] = cp[n];
            cp[n] = tmp;
        }
        cpuPower1.text= cp[0]+"p";
        cpuPower2.text = cp[1] + "p";
        cpuPower3.text = cp[2] + "p";
        cpuPower4.text = cp[3] + "p";
        cpuPower5.text = cp[4] + "p";



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int Getcp(int n)
    {
        return cp[n];
    }
}
