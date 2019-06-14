using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Resultscript : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip select3;

    public Image[] panel = new Image[5];
    Sprite[] colorpanel = SumPoint.color_panel;
    int[] colornum = SumPoint.colornum;

    public Text battleresult1, battleresult2, battleresult3, battleresult4, battleresult5;
    public Text resultpoint1, resultpoint2, resultpoint3, resultpoint4, resultpoint5;
    public Text winnerhand1, winnerhand2, winnerhand3, winnerhand4, winnerhand5;

    public Text PlayerGooPoint;
    public Text PlayerChokiPoint;
    public Text PlayerPaPoint;
    public Text CPUGooPoint;
    public Text CPUChokiPoint;
    public Text CPUPaPoint;

    public static int pGooPoint;
    public static int pChokiPoint;
    public static int pPaPoint;
    public static int cGooPoint;
    public static int cChokiPoint;
    public static int cPaPoint;

    // Start is called before the first frame update
    void Start()
    {
        pGooPoint = 0;
        pChokiPoint = 0;
        pPaPoint = 0;
        cGooPoint = 0;
        cChokiPoint = 0;
        cPaPoint = 0;
        int[] resultpoint = next.ResultPoint;
        int[] battlestatus = next.BattleStatus;
        string[] winnerhand = next.Winnerhand;
        Text[] battleresult = new Text[5] { battleresult1, battleresult2, battleresult3, battleresult4, battleresult5 };
        Text[] handtext = new Text[5] { winnerhand1, winnerhand2, winnerhand3, winnerhand4, winnerhand5 };

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

        string[] result = new string[5];
        Color[] status = new Color[5];

        for (int n = 0; n <= 4; n++)
        {
            switch (battlestatus[n])
            { 
                case 1:
                    result[n] = "WIN!!";
                    status[n] = Color.red;
                    break;
                case 2:
                    result[n] = "LOSE...";
                    status[n] = Color.blue;
                    break;
                case 3:
                    result[n] = "DRAW";
                    status[n] = Color.gray;
                    break;
            }

            switch (winnerhand[n])
            {
                case "Goo":
                    handtext[n].color = Color.red;
                    break;
                case "Choki":
                    handtext[n].color = Color.green;
                    break;
                case "Pa":
                    handtext[n].color = Color.blue;
                    break;
            }
        }
        battleresult1.text = result[0];
        battleresult2.text = result[1];
        battleresult3.text = result[2];
        battleresult4.text = result[3];
        battleresult5.text = result[4];
        battleresult1.color = status[0];
        battleresult2.color = status[1];
        battleresult3.color = status[2];
        battleresult4.color = status[3];
        battleresult5.color = status[4];

        //２回戦用にそれぞれのポイントをじゃんけんの手ごとに集計//

        for (int n = 0; n <= 4; n++)
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
                    cGooPoint = cGooPoint + resultpoint[n];
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

        for(int n = 0; n <= 4; n++)
        {
            panel[n].sprite = colorpanel[n];
        }

    }

    public void GoNext()
    {
        AS.PlayOneShot(select3);
        FadeManager.Instance.LoadScene("2ndSetting", 1.0f);
    }
}
