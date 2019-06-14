using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class finalresult : MonoBehaviour
{
    int playerscore = Secondresult.victorycount;
    int cpuscore = Secondresult.defeatcount;

    public Text Result;
    Color textcolor;

    public AudioSource AS;
    public AudioClip win, lose, unicoon;


    // Start is called before the first frame update
    void Start()
    {
        textcolor = Result.color;

        if (playerscore > cpuscore)
        {
            AS.PlayOneShot(unicoon);
            Result.text = "WIN!!";
            textcolor = Color.red;
            textcolor.a = 0;
        }
        else if (playerscore < cpuscore)
        {
            AS.PlayOneShot(lose);
            Result.text = "LOSE...";
            textcolor = Color.blue;
            textcolor.a = 0;
        }
        else if (playerscore == cpuscore)
        {
            AS.PlayOneShot(lose);
            Result.text = "DRAW...";
            textcolor = Color.gray;
            textcolor.a = 0;
        }

    }

    private void Update()
    {
        Fadein();
    }

    void Fadein()
    {
        if (textcolor.a <= 1)
        {
            textcolor.a += 0.008f;
            Result.color = textcolor;
        }
    }
}
