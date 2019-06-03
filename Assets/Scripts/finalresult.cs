using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finalresult : MonoBehaviour
{
    int playerscore = Victorycounter.victorycounter;
    int cpuscore = Victorycounter.defeatcounter;

    public TextMeshProUGUI Result;

    // Start is called before the first frame update
    void Start()
    {
        if (playerscore > cpuscore)
        {
            Result.text = "WIN!!";
        }
        else if (playerscore < cpuscore)
        {
            Result.text = "LOSE...";
        }
        else if (playerscore == cpuscore)
        {
            Result.text = "DRAW...";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
