using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public CH ch;

    // Start is called before the first frame update
    void Start()
    {  //プレイヤーとCPUの手をコンソールに表示//
        for(int n=1; n<=5; n++)
        {
            string myhand = SumPoint.Getmyhand(n);
            string cpuhand = ch.Getcpuhand(n);

            Debug.Log("プレイヤーの手は" + myhand);
            Debug.Log("CPUの手は" + cpuhand);
        }
       
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextButton()
    {
        SceneManager.LoadScene("Resultscene");
    }
}
