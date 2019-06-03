using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Victorycounter : MonoBehaviour
{
    int[] Battle_Result = Secondresult.BattleResult;
    string[] Battle_Resulttext = new string[3];

    public TextMeshProUGUI Result1;
    public TextMeshProUGUI Result2;
    public TextMeshProUGUI Result3;

    public TextMeshProUGUI Victorycount;
    public TextMeshProUGUI Defeatcount;

    public static int victorycounter = 0;
    public static int defeatcounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        for (int n=0; n<=2; n++)
        {
            switch (Battle_Result[n])
            {
                case 1:
                    Battle_Resulttext[n] = "WIN";
                    victorycounter++;
                    break;
                case 2:
                    Battle_Resulttext[n] = "LOSE";
                    defeatcounter++;
                    break;
                case 3:
                    Battle_Resulttext[n] = "DRAW";
                    break;
            }
        }

        Result1.text = Battle_Resulttext[0];
        Result2.text = Battle_Resulttext[1];
        Result3.text = Battle_Resulttext[2];

        Invoke("Show", 2);
    }

    void Show()
    {
        Victorycount.text = victorycounter + "";
        Defeatcount.text = defeatcounter + "";
    }

    public void ShowResult()
    {
        SceneManager.LoadScene("END");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
