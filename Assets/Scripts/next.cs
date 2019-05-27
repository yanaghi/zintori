using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public CH ch;
    public CP cp;

    public Text phandtext1;
    public Text phandtext2;
    public Text phandtext3;
    public Text phandtext4;
    public Text phandtext5;

    public Text ppointtext1;
    public Text ppointtext2;
    public Text ppointtext3;
    public Text ppointtext4;
    public Text ppointtext5;

    public Text Presulttext1;
    public Text Presulttext2;
    public Text Presulttext3;
    public Text Presulttext4;
    public Text Presulttext5;

    public Text Cresulttext1;
    public Text Cresulttext2;
    public Text Cresulttext3;
    public Text Cresulttext4;
    public Text Cresulttext5;
    //１回戦の数値勝負の結果、１＝勝ち、２＝負け、３＝引き分け//
    public static int BattleStatus1 = 0;
    public static int BattleStatus2 = 0;
    public static int BattleStatus3 = 0;
    public static int BattleStatus4 = 0;
    public static int BattleStatus5 = 0;

    public static int[] BattleStatus = new int[5] { BattleStatus1, BattleStatus2, BattleStatus3, BattleStatus4, BattleStatus5 };

    //自分と相手のポイントの差//
    static int ResultPoint1 = 0;
    static int ResultPoint2 = 0;
    static int ResultPoint3 = 0;
    static int ResultPoint4 = 0;
    static int ResultPoint5 = 0;

    public static int[] ResultPoint = new int[5] { ResultPoint1, ResultPoint2, ResultPoint3, ResultPoint4, ResultPoint5 };

    //勝負に勝った方の手を記録する配列//
    static string Winnerhand1;
    static string Winnerhand2;
    static string Winnerhand3;
    static string Winnerhand4;
    static string Winnerhand5;

    public static string[] Winnerhand = new string[5] { Winnerhand1, Winnerhand2, Winnerhand3, Winnerhand4, Winnerhand5 };

    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーの出す手//
        string phand1 = SumPoint.Getmyhand(1);
        string phand2 = SumPoint.Getmyhand(2);
        string phand3 = SumPoint.Getmyhand(3);
        string phand4 = SumPoint.Getmyhand(4);
        string phand5 = SumPoint.Getmyhand(5);
        //CPUの出す手//
        string chand1 = ch.Getcpuhand(1);
        string chand2 = ch.Getcpuhand(2);
        string chand3 = ch.Getcpuhand(3);
        string chand4 = ch.Getcpuhand(4);
        string chand5 = ch.Getcpuhand(5);
        //プレイヤーのポイント//
        int PP1 = GameDirector.GetCount(1);
        int PP2 = GameDirector.GetCount(2);
        int PP3 = GameDirector.GetCount(3);
        int PP4 = GameDirector.GetCount(4);
        int PP5 = GameDirector.GetCount(5);
        //CPUのポイント//
        int CP1 = cp.Getcp(0);
        int CP2 = cp.Getcp(1);
        int CP3 = cp.Getcp(2);
        int CP4 = cp.Getcp(3);
        int CP5 = cp.Getcp(4);


        //1=win, 2=draw, 3=loseで条件分岐させるつもり//
        int jankenstatus1 = 0;
        int jankenstatus2 = 0;
        int jankenstatus3 = 0;
        int jankenstatus4 = 0;
        int jankenstatus5 = 0;

        string[] phand = new string[5] { phand1, phand2, phand3, phand4, phand5 };
        string[] chand = new string[5] { chand1, chand2, chand3, chand4, chand5 };
        int[] PP = new int[5] { PP1, PP2, PP3, PP4, PP5 }; //プレイヤーのポイント、倍率かかった後//
        int[] PPP = new int[5] { PP1, PP2, PP3, PP4, PP5 };　//プレイヤーのポイント、倍率かかる前//
        int[] CP = new int[5] { CP1, CP2, CP3, CP4, CP5 };
        int[] jankenstatus = new int[5] { jankenstatus1, jankenstatus2, jankenstatus3, jankenstatus4, jankenstatus5 };


        for (int n = 0; n <= 4; n++)
        {


            if ((phand[n] == "Goo") && (chand[n] == "Goo"))
            { 
                jankenstatus[n] = 2;
            }
            else if ((phand[n] == "Goo") && (chand[n] == "Choki"))
            {
                jankenstatus[n] = 1;
            }
            else if ((phand[n] == "Goo") && (chand[n] == "Pa"))
            {
                jankenstatus[n] = 3;
            }
            else if ((phand[n] == "Choki") && (chand[n] == "Goo"))
            {
                jankenstatus[n] = 3;
            }
            else if ((phand[n] == "Choki") && (chand[n] == "Choki"))
            {
                jankenstatus[n] = 2;
            }
            else if ((phand[n] == "Choki") && (chand[n] == "Pa"))
            {
                jankenstatus[n] = 1;
            }
            else if ((phand[n] == "Pa") && (chand[n] == "Goo"))
            {
                jankenstatus[n] = 1;
            }
            else if ((phand[n] == "Pa") && (chand[n] == "Choki"))
            {
                jankenstatus[n] = 3;
            }
            else if ((phand[n] == "Pa") && (chand[n] == "Pa"))
            {
                jankenstatus[n] = 2;
            }

            if (jankenstatus[n] == 1)
            {
                PP[n] = PP[n] * 2;
            }
            else if (jankenstatus[n] == 3)
            {
                CP[n] = CP[n] * 2;
            }

            Debug.Log((n + 1) + "回戦　" + phand[n] + "　vs　" + chand[n]);

            if (PP[n] > CP[n])
            {
                ResultPoint[n] = PP[n] - CP[n];
                Debug.Log("プレイヤーの勝ち! ２回戦目で　" + phand[n] + "　の　" + ResultPoint[n] + "　pが使用できます");
                BattleStatus[n] = 1;
                Winnerhand[n] = phand[n];
            }
            else if (PP[n] < CP[n])
            {
                ResultPoint[n] = CP[n] - PP[n];
                Debug.Log("プレイヤーの負け…　２回戦目でCPUが　" + chand[n] + "　の　" + ResultPoint[n] + "　pを使用します");
                BattleStatus[n] = 2;
                Winnerhand[n] = chand[n];
            }
            else
            {
                Debug.Log("引き分け");
                BattleStatus[n] = 3;
                Winnerhand[n] = null;
            }
        }

        phandtext1.text = phand[0];
        phandtext2.text = phand[1];
        phandtext3.text = phand[2];
        phandtext4.text = phand[3];
        phandtext5.text = phand[4];

        ppointtext1.text = PPP[0] + "p";
        ppointtext2.text = PPP[1] + "p";
        ppointtext3.text = PPP[2] + "p";
        ppointtext4.text = PPP[3] + "p";
        ppointtext5.text = PPP[4] + "p";

        Presulttext1.text = PP[0] + "p";
        Presulttext2.text = PP[1] + "p";
        Presulttext3.text = PP[2] + "p";
        Presulttext4.text = PP[3] + "p";
        Presulttext5.text = PP[4] + "p";

        Cresulttext1.text = CP[0] + "p";
        Cresulttext2.text = CP[1] + "p";
        Cresulttext3.text = CP[2] + "p";
        Cresulttext4.text = CP[3] + "p";
        Cresulttext5.text = CP[4] + "p";
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
