using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Resultscript : MonoBehaviour
{
    public TextMeshProUGUI battleresult1, battleresult2, battleresult3, battleresult4, battleresult5;

    public TextMeshProUGUI resultpoint1, resultpoint2, resultpoint3, resultpoint4, resultpoint5;

    public TextMeshProUGUI winnerhand1, winnerhand2, winnerhand3, winnerhand4, winnerhand5;

    public TextMeshProUGUI PlayerGooPoint;
    public TextMeshProUGUI PlayerChokiPoint;
    public TextMeshProUGUI PlayerPaPoint;
    public TextMeshProUGUI CPUGooPoint;
    public TextMeshProUGUI CPUChokiPoint;
    public TextMeshProUGUI CPUPaPoint;

    public static int pGooPoint;
    public static int pChokiPoint;
    public static int pPaPoint;
    public static int cGooPoint;
    public static int cChokiPoint;
    public static int cPaPoint;

    // Start is called before the first frame update
    void Start()
    {
        int[] resultpoint = next.ResultPoint;
        int[] battlestatus = next.BattleStatus;
        string[] winnerhand = next.Winnerhand;

        resultpoint1.text = resultpoint[0] + "p";
        resultpoint2.text = resultpoint[1] + "p";
        resultpoint3.text = resultpoint[2] + "p";
        resultpoint4.text = resultpoint[3] + "p";
        resultpoint5.text = resultpoint[4] + "p";

        winnerhand1.text = winnerhand[0];
        winnerhand2.text = winnerhand[1];
        winnerhand3.text = winnerhand[2];
        winnerhand4.text = winnerhand[3];
        winnerhand5.text = winnerhand[4];
        //なぜかfor文でうまくいかなかったからそれぞれやる//
        //１回目//
        if (battlestatus[0] == 1)
            {
                battleresult1.text = "WIN!!";
            }
            else if (battlestatus[0] == 2)
            {
                battleresult1.text = "LOSE..";
            }
            else if (battlestatus[0] == 3)
            {
                battleresult1.text = "DRAW";
            }
        //２回目//
            if (battlestatus[1] == 1)
            {
                battleresult2.text = "WIN!!";
            }
            else if (battlestatus[1] == 2)
            {
                battleresult2.text = "LOSE..";
            }
            else if (battlestatus[1] == 3)
            {
                battleresult2.text = "DRAW";
            }
            //３回目//
            if (battlestatus[2] == 1)
            {
                battleresult3.text = "WIN!!";
            }
            else if (battlestatus[2] == 2)
            {
                battleresult3.text = "LOSE..";
            }
            else if (battlestatus[2] == 3)
            {
                battleresult3.text = "DRAW";
            }

            if (battlestatus[3] == 1)
            {
                battleresult4.text = "WIN!!";
            }
            else if (battlestatus[3] == 2)
            {
                battleresult4.text = "LOSE..";
            }
            else if (battlestatus[3] == 3)
            {
                battleresult4.text = "DRAW";
            }

            if (battlestatus[4] == 1)
            {
                battleresult5.text = "WIN!!";
            }
            else if (battlestatus[4] == 2)
            {
                battleresult5.text = "LOSE..";
            }
            else if (battlestatus[4] == 3)
            {
                battleresult5.text = "DRAW";
            }

        //２回戦用にそれぞれのポイントをじゃんけんの手ごとに集計//

            for(int n = 0; n <= 4; n++)
        {
            

            if (battlestatus[n] == 1)   //勝ったとき,手によってポイントを振り分ける//
            {
                if (winnerhand[n] == "Goo")
                {
                    pGooPoint = pGooPoint + resultpoint[n];
                }
                else if (winnerhand[n] == "Choki")
                {
                    pChokiPoint = pChokiPoint + resultpoint[n];
                }
                else if (winnerhand[n] == "Pa")
                {
                    pPaPoint = pPaPoint + resultpoint[n];
                }
            }
            else if (battlestatus[n] == 2)　　　//負けたとき//
            {
                if (winnerhand[n] == "Goo")
                {
                    cGooPoint =cGooPoint + resultpoint[n];
                }
                else if (winnerhand[n] == "Choki")
                {
                    cChokiPoint = cChokiPoint + resultpoint[n];
                }
                else if (winnerhand[n] == "Pa")
                {
                    cPaPoint = cPaPoint + resultpoint[n];
                }
            }

            PlayerGooPoint.text = pGooPoint + "p";
            PlayerChokiPoint.text = pChokiPoint + "p";
            PlayerPaPoint.text = pPaPoint + "p";
            CPUGooPoint.text = cGooPoint + "p";
            CPUChokiPoint.text = cChokiPoint + "p";
            CPUPaPoint.text = cPaPoint + "p";
        }

    }

    public void GoNext()
    {
        SceneManager.LoadScene("2ndSetting");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
