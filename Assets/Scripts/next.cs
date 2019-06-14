using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    public Image[] panel = new Image[5];
    Sprite[] colorpanel = SumPoint.color_panel;
    int[] colornum = SumPoint.colornum;

    public Text PointText_c1, PointText_c2, PointText_c3, PointText_c4, PointText_c5;
    public Text HandText_c1, HandText_c2, HandText_c3, HandText_c4, HandText_c5;
    public Text HandText_p1, HandText_p2, HandText_p3, HandText_p4, HandText_p5;
    public Text PointText_p1, PointText_p2, PointText_p3, PointText_p4, PointText_p5;
    public Text Presulttext1, Presulttext2, Presulttext3, Presulttext4, Presulttext5;
    public Text Cresulttext1, Cresulttext2, Cresulttext3, Cresulttext4, Cresulttext5;

    public AudioSource AS;
    public AudioClip effect;
 
    //１回戦の数値勝負の結果、１＝勝ち、２＝負け、３＝引き分け//
    public static int BattleStatus1 = 0;
    public static int BattleStatus2 = 0;
    public static int BattleStatus3 = 0;
    public static int BattleStatus4 = 0;
    public static int BattleStatus5 = 0;
    public static int[] BattleStatus = new int[5];

    //自分と相手のポイントの差//
    static int ResultPoint1 = 0;
    static int ResultPoint2 = 0;
    static int ResultPoint3 = 0;
    static int ResultPoint4 = 0;
    static int ResultPoint5 = 0;
    public static int[] ResultPoint = new int[5];

    //勝負に勝った方の手を記録する配列//
    static string Winnerhand1="";
    static string Winnerhand2="";
    static string Winnerhand3="";
    static string Winnerhand4="";
    static string Winnerhand5="";
    public static string[] Winnerhand = new string[5];

    string phand1, phand2, phand3, phand4, phand5;

    string chand1, chand2, chand3, chand4, chand5;

    //1=win, 2=draw, 3=lose//
    int jankenstatus1 = 0, jankenstatus2 = 0, jankenstatus3 = 0, jankenstatus4 = 0, jankenstatus5 = 0;   

    // Start is called before the first frame update
    void Start()
    {     
        BattleStatus[0] = BattleStatus1;
        BattleStatus[1] = BattleStatus2;
        BattleStatus[2] = BattleStatus3;
        BattleStatus[3] = BattleStatus4;
        BattleStatus[4] = BattleStatus5;

        ResultPoint[0] = ResultPoint1;
        ResultPoint[1] = ResultPoint2;
        ResultPoint[2] = ResultPoint3;
        ResultPoint[3] = ResultPoint4;
        ResultPoint[4] = ResultPoint5;

        Winnerhand[0] = Winnerhand1;
        Winnerhand[1] = Winnerhand2;
        Winnerhand[2] = Winnerhand3;
        Winnerhand[3] = Winnerhand4;
        Winnerhand[4] = Winnerhand5;

        PointText_c1.text = 50 + "";
        PointText_c2.text = 40 + "";
        PointText_c3.text = 10 + "";
        PointText_c4.text = 20 + "";
        PointText_c5.text = 30 + "";

        //プレイヤーの出す手//
        phand1 = SumPoint.Getmyhand(1);
        phand2 = SumPoint.Getmyhand(2);
        phand3 = SumPoint.Getmyhand(3);
        phand4 = SumPoint.Getmyhand(4);
        phand5 = SumPoint.Getmyhand(5);

        //CPUの出す手//
        chand1 = Getch(0);
        chand2 = Getch(1);
        chand3 = Getch(2);
        chand4 = Getch(3);
        chand5 = Getch(4);

        //プレイヤーのポイント//
        int PP1 = SumPoint.count1;
        int PP2 = SumPoint.count2;
        int PP3 = SumPoint.count3;
        int PP4 = SumPoint.count4;
        int PP5 = SumPoint.count5; 

        //CPUのポイント//
        int CP1 = 50;
        int CP2 = 40;
        int CP3 = 10;
        int CP4 = 20;
        int CP5 = 30;

        int[] PP = new int[5] { PP1, PP2, PP3, PP4, PP5 }; //プレイヤーのポイント、倍率かかった後//
        int[] PPP = new int[5] { PP1, PP2, PP3, PP4, PP5 };　//プレイヤーのポイント、倍率かかる前//
        int[] CP = new int[5] { CP1, CP2, CP3, CP4, CP5 };
        string[] phand = new string[5] { phand1, phand2, phand3, phand4, phand5 };
        string[] chand = new string[5] { chand1, chand2, chand3, chand4, chand5 };
        int[] jankenstatus = new int[5] { jankenstatus1, jankenstatus2, jankenstatus3, jankenstatus4, jankenstatus5 };

        for (int n = 0; n <= 4; n++)
        {
            switch (phand[n])
            {
                case "Goo":
                    switch (chand[n])
                    {
                        case "Goo":
                            jankenstatus[n] = 2;
                            break;
                        case "Choki":
                            jankenstatus[n] = 1;
                            break;
                        case "Pa":
                            jankenstatus[n] = 3;
                            break;
                    }
                    break;
                case "Choki":
                    switch (chand[n])
                    {
                        case "Goo":
                            jankenstatus[n] = 3;
                            break;
                        case "Choki":
                            jankenstatus[n] = 2;
                            break;
                        case "Pa":
                            jankenstatus[n] = 1;
                            break;
                    }
                    break;
                case "Pa":
                    switch (chand[n])
                    {
                        case "Goo":
                            jankenstatus[n] = 1;
                            break;
                        case "Choki":
                            jankenstatus[n] = 3;
                            break;
                        case "Pa":
                            jankenstatus[n] = 2;
                            break;
                    }
                    break;
            }

            if (jankenstatus[n] == 1)
            {
                PP[n] = PP[n] * 2;

            }
            else if (jankenstatus[n] == 3)
            {
                CP[n] = CP[n] * 2;
            }

            switch (colornum[n])
            {
                case 0:
                    if (phand[n] == "Goo")
                    {
                        PP[n] = PP[n] + 20;
                    }
                    if (chand[n] == "Goo")
                    {
                        CP[n] = CP[n] + 20;
                    }
                    break;
                case 1:
                    if (phand[n] == "Choki")
                    {
                        PP[n] = PP[n] + 20;
                    }
                    if (chand[n] == "Choki")
                    {
                        CP[n] = CP[n] + 20;
                    }
                    break;
                case 2:
                    if (phand[n] == "Pa")
                    {
                        PP[n] = PP[n] + 20;
                    }
                    if (chand[n] == "Pa")
                    {
                        CP[n] = CP[n] + 20;
                    }
                    break;
                default:
                    break;
            }

            if (PP[n] > CP[n])
            {
                ResultPoint[n] = PP[n] - CP[n];
                BattleStatus[n] = 1;
                Winnerhand[n] = phand[n];
            }
            else if (PP[n] < CP[n])
            {
                ResultPoint[n] = CP[n] - PP[n];
                BattleStatus[n] = 2;
                Winnerhand[n] = chand[n];
            }
            else
            {
                BattleStatus[n] = 3;
                Winnerhand[n] = null;
            }
        }

        HandText_p1.text = phand[0];
        HandText_p2.text = phand[1];
        HandText_p3.text = phand[2];
        HandText_p4.text = phand[3];
        HandText_p5.text = phand[4];

        PointText_p1.text = PPP[0] + "";
        PointText_p2.text = PPP[1] + "";
        PointText_p3.text = PPP[2] + "";
        PointText_p4.text = PPP[3] + "";
        PointText_p5.text = PPP[4] + "";

        Presulttext1.text = PP[0] + "";
        Presulttext2.text = PP[1] + "";
        Presulttext3.text = PP[2] + "";
        Presulttext4.text = PP[3] + "";
        Presulttext5.text = PP[4] + "";

        Cresulttext1.text = CP[0] + "";
        Cresulttext2.text = CP[1] + "";
        Cresulttext3.text = CP[2] + "";
        Cresulttext4.text = CP[3] + "";
        Cresulttext5.text = CP[4] + "";

        //テキストの色を変える//
        Text[] text_p = new Text[5] { Presulttext1, Presulttext2, Presulttext3, Presulttext4, Presulttext5 };
        Text[] text_c = new Text[5] { Cresulttext1, Cresulttext2, Cresulttext3, Cresulttext4, Cresulttext5 };
        Text[] hand_p = new Text[5] { HandText_p1, HandText_p2, HandText_p3, HandText_p4, HandText_p5 };
        Text[] hand_c = new Text[5] { HandText_c1, HandText_c2, HandText_c3, HandText_c4, HandText_c5 };

        for (int n = 0; n <= 4; n++)
        {
            switch (phand[n])
            {
                case "Goo":
                    hand_p[n].color = Color.red;
                    break;
                case "Choki":
                    hand_p[n].color = Color.green;
                    break;
                case "Pa":
                    hand_p[n].color = Color.blue;
                    break;
            }

            switch (chand[n])
            {
                case "Goo":
                    hand_c[n].color = Color.red;
                    break;
                case "Choki":
                    hand_c[n].color = Color.green;
                    break;
                case "Pa":
                    hand_c[n].color = Color.blue;
                    break;
            }

            if (BattleStatus[n] == 1)
            {
                text_p[n].color = Color.yellow;
            }
            else if (BattleStatus[n] == 2)
            {
                text_c[n].color = Color.yellow;
            }
        }

        for(int n = 0; n <= 4; n++)
        {
            panel[n].sprite = colorpanel[n];
        }
    }

    public void NextButton()
    {
        DontDestroyOnLoad(this);
        Destroy(this.gameObject, 0.5f);
        SceneManager.LoadScene("1stResult");
        AS.PlayOneShot(effect);
        
    }

    //cpuのポイントを取得//
    int Getcp(int i)
    {
        int[] cp = new int[] { 10, 20, 30, 40, 50 };

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

        return cp[i];
    }

    //cpuの手を取得する//
    string Getch(int i)
    {
        string[] hand = new string[3] { "Goo", "Choki", "Pa" };

            switch (i)
            {
                case 0:
                    HandText_c1.text = "Goo";
                    return HandText_c1.text;
                case 1:
                    HandText_c2.text = "Pa";
                    return HandText_c2.text;
                case 2:
                    HandText_c3.text = "Choki";
                    return HandText_c3.text;
                case 3:
                    HandText_c4.text = "Pa";
                    return HandText_c4.text;
                case 4:
                    HandText_c5.text = "Pa";
                    return HandText_c5.text;
                default:
                    return null;
            }
        

    }

}
