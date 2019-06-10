using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class finalresult : MonoBehaviour
{
    int playerscore = Secondresult.victorycount;
    int cpuscore = Secondresult.defeatcount;

    public Text Result;

    // Start is called before the first frame update
    void Start()
    {
        if (playerscore > cpuscore)
        {
            Result.text = "WIN!!";
            Result.color = Color.red;
        }
        else if (playerscore < cpuscore)
        {
            Result.text = "LOSE...";
            Result.color = Color.blue;
        }
        else if (playerscore == cpuscore)
        {
            Result.text = "DRAW...";
            Result.color = Color.gray;
        }
    }
}
