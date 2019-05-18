using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CPUHand : MonoBehaviour
{
    public Text cpuhand;
    public Text cpupower;
    string[] hand = new string[3] { "Gu", "Choki", "Pa" };



    // Start is called before the first frame update
    void Start()
    {
        cpuhand.text = hand[Random.Range(0, 3)];   
    }

    // Update is called once per frame
    void Update()
    {
       
    }


}
