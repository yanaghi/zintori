using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class Secondresult : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip select2,select3;

    public Image[] panel = new Image[3];
    Sprite[] irodori = secondBattle.irodori;
    int[] colornum = secondBattle.colornum;

    public Text Phand1;
    public Text Phand2;
    public Text Phand3;

    public Text Chand1;
    public Text Chand2;
    public Text Chand3;

    public Text Pbeforepoint1;
    public Text Pbeforepoint2;
    public Text Pbeforepoint3;

    public Text Cbeforepoint1;
    public Text Cbeforepoint2;
    public Text Cbeforepoint3;

    public Text Pafterpoint1;
    public Text Pafterpoint2;
    public Text Pafterpoint3;

    public Text Cafterpoint1;
    public Text Cafterpoint2;
    public Text Cafterpoint3;

    public GameObject Pafterp1;
    public GameObject result1, result2, result3;

    public Text Result1, Result2, Result3, Resultsum;

    //プレイヤーの選んだ手とポイント//
    int secondpp1 = secondBattle.power1;
    int secondpp2 = secondBattle.power2;
    int secondpp3 = secondBattle.power3;
    string secondph1 = secondBattle.handtext1;
    string secondph2 = secondBattle.handtext2;
    string secondph3 = secondBattle.handtext3;

    int cpuGoo = secondBattle.c_GooPoint;
    int cpuChoki = secondBattle.c_ChokiPoint;
    int cpuPa = secondBattle.c_PaPoint;

    int secondcp1;
    int secondcp2;
    int secondcp3;
    string secondch1;
    string secondch2;
    string secondch3;

    //1が勝ち、2が負け、3が引き分け//
    public int[] JankenResult = new int[3];
    public static int[] BattleResult = new int[3];
    
    int[] Secondpp = new int[3];
    string[] Secondph = new string[3];
    int[] Secondcp = new int[3];
    string[] Secondch = new string[3];

    //倍率かかった後のポイント//
    int[] SPP = new int[3];
    int[] SCP = new int[3];

    public static int victorycount = 0;
    public static int defeatcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        Text[] Phand = new Text[3] { Phand1, Phand2, Phand3 };
        Text[] Chand = new Text[3] { Chand1, Chand2, Chand3 };
        Text[] Pafterpoint = new Text[3] { Pafterpoint1, Pafterpoint2, Pafterpoint3 };
        Text[] Cafterpoint = new Text[3] { Cafterpoint1, Cafterpoint2, Cafterpoint3 };

        string[] hand = new string[3] { "Goo", "Choki", "Pa" };
        result1.SetActive(false);
        result2.SetActive(false);
        result3.SetActive(false);

        //CPUのポイント割り振りを決める//
        if ((cpuGoo > 0) && (cpuChoki > 0) && (cpuPa > 0))          //グーチョキパー全部ポイントあり//
        {
            int[] point = new int[3] { cpuGoo, cpuChoki, cpuPa };

            //重複なしシャッフル//
            System.Random rng = new System.Random();
            int n = point.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int tmp = point[k];
                string tmp2 = hand[k];
                point[k] = point[n];
                hand[k] = hand[n];
                point[n] = tmp;
                hand[n] = tmp2;
            }
            secondcp1 = point[0];
            secondcp2 = point[1];
            secondcp3 = point[2];
            secondch1 = hand[0];
            secondch2 = hand[1];
            secondch3 = hand[2];
        }
        else if ((cpuGoo > 0) && (cpuChoki > 0) && (cpuPa == 0))  //パーだけポイントなし//
        {
            string randomhand = hand[Random.Range(0, 3)];

            int[] point = new int[3] { cpuGoo, cpuChoki, 0 };
            string[] hand2 = new string[3] { "Goo", "Choki", randomhand };

            //重複なしシャッフル//
            System.Random rng = new System.Random();
            int n = point.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int tmp = point[k];
                string tmp2 = hand2[k];
                point[k] = point[n];
                hand2[k] = hand2[n];
                point[n] = tmp;
                hand2[n] = tmp2;
            }
            secondcp1 = point[0];
            secondcp2 = point[1];
            secondcp3 = point[2];
            secondch1 = hand2[0];
            secondch2 = hand2[1];
            secondch3 = hand2[2];
        }
        else if ((cpuGoo > 0) && (cpuChoki == 0) && (cpuPa > 0))  //チョキだけポイントなし//
        {
            string randomhand = hand[Random.Range(0, 3)];

            int[] point = new int[3] { cpuGoo, 0, cpuPa };
            string[] hand3 = new string[3] { "Goo", randomhand, "Pa" };

            //重複なしシャッフル//
            System.Random rng = new System.Random();
            int n = point.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int tmp = point[k];
                string tmp2 = hand3[k];
                point[k] = point[n];
                hand3[k] = hand3[n];
                point[n] = tmp;
                hand3[n] = tmp2;
            }
            secondcp1 = point[0];
            secondcp2 = point[1];
            secondcp3 = point[2];
            secondch1 = hand3[0];
            secondch2 = hand3[1];
            secondch3 = hand3[2];
        }
        else if ((cpuGoo == 0) && (cpuChoki > 0) && (cpuPa > 0))  //グーだけポイントなし//
        {
            string randomhand = hand[Random.Range(0, 3)];

            int[] point = new int[3] { 0, cpuChoki, cpuPa };
            string[] hand4 = new string[3] { randomhand, "Choki", "Pa" };

            //重複なしシャッフル//
            System.Random rng = new System.Random();
            int n = point.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int tmp = point[k];
                string tmp2 = hand4[k];
                point[k] = point[n];
                hand4[k] = hand4[n];
                point[n] = tmp;
                hand4[n] = tmp2;
            }
            secondcp1 = point[0];
            secondcp2 = point[1];
            secondcp3 = point[2];
            secondch1 = hand4[0];
            secondch2 = hand4[1];
            secondch3 = hand4[2];
        }
        else if ((cpuGoo > 0) && (cpuChoki == 0) && (cpuPa == 0))  //グーだけポイントあり//
        {
            int gooA = 0;
            int gooB = 0;
            string randomhand = "";
            int[] point = new int[3] { gooA, gooB, 0 };
            string[] hand5 = new string[3] { "Goo", "Goo", randomhand };

            randomhand = hand[Random.Range(0, 3)];

            if (cpuGoo % 20 == 0)
            {
                gooA = cpuGoo / 2;
                gooB = cpuGoo / 2;
            }
            else if (cpuGoo % 20 == 10)
            {
                gooA = (cpuGoo / 2) + 5;
                gooB = (cpuGoo / 2) - 5;
            }

            //重複なしシャッフル//
            System.Random rng = new System.Random();
            int n = point.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int tmp = point[k];
                string tmp2 = hand5[k];
                point[k] = point[n];
                hand5[k] = hand5[n];
                point[n] = tmp;
                hand5[n] = tmp2;
            }
            secondcp1 = point[0];
            secondcp2 = point[1];
            secondcp3 = point[2];
            secondch1 = hand5[0];
            secondch2 = hand5[1];
            secondch3 = hand5[2];
        }
        else if ((cpuGoo == 0) && (cpuChoki > 0) && (cpuPa == 0))  //チョキだけポイントあり//
        {
            int chokiA = 0;
            int chokiB = 0;
            string randomhand = "";
            int[] point = new int[3] { chokiA, chokiB, 0 };
            string[] hand6 = new string[3] { "Choki", "Choki", randomhand };

            randomhand = hand[Random.Range(0, 3)];

            if (cpuChoki % 20 == 0)
            {
                chokiA = cpuChoki / 2;
                chokiB = cpuChoki / 2;
            }
            else if (cpuChoki % 20 == 10)
            {
                chokiA = (cpuChoki / 2) + 5;
                chokiB = (cpuChoki / 2) - 5;
            }

            //重複なしシャッフル//
            System.Random rng = new System.Random();
            int n = point.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int tmp = point[k];
                string tmp2 = hand6[k];
                point[k] = point[n];
                hand6[k] = hand6[n];
                point[n] = tmp;
                hand6[n] = tmp2;
            }
            secondcp1 = point[0];
            secondcp2 = point[1];
            secondcp3 = point[2];
            secondch1 = hand6[0];
            secondch2 = hand6[1];
            secondch3 = hand6[2];
        }
        else if ((cpuGoo == 0) && (cpuChoki == 0) && (cpuPa > 0))   //パーだけポイントあり//
        {
            int paA = 0;
            int paB = 0;
            string randomhand = "";
            int[] point = new int[3] { paA, paB, 0 };
            string[] hand7 = new string[3] { "Pa", "Pa", randomhand };

            randomhand = hand[Random.Range(0, 3)];

            if (cpuPa % 20 == 0)
            {
                paA = cpuPa / 2;
                paB = cpuPa / 2;
            }
            else if (cpuPa % 20 == 10)
            {
                paA = (cpuPa / 2) + 5;
                paB = (cpuPa / 2) - 5;
            }

            //重複なしシャッフル//
            System.Random rng = new System.Random();
            int n = point.Length;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int tmp = point[k];
                string tmp2 = hand7[k];
                point[k] = point[n];
                hand7[k] = hand7[n];
                point[n] = tmp;
                hand7[n] = tmp2;
            }
            secondcp1 = point[0];
            secondcp2 = point[1];
            secondcp3 = point[2];
            secondch1 = hand7[0];
            secondch2 = hand7[1];
            secondch3 = hand7[2];
        }
        else if((cpuGoo==0)&&(cpuChoki==0)&&(cpuPa==0))       //何もなし//
        {
            secondcp1 = 0;
            secondcp2 = 0;
            secondcp3 = 0;
            secondch1 = hand[Random.Range(0, 3)];
            secondch2 = hand[Random.Range(0, 3)];
            secondch3 = hand[Random.Range(0, 3)];
        }

        Secondpp[0] = secondpp1;
        Secondpp[1] = secondpp2;
        Secondpp[2] = secondpp3;

        Secondph[0] = secondph1;
        Secondph[1] = secondph2;
        Secondph[2] = secondph3;

        Secondcp[0] = secondcp1;    
        Secondcp[1] = secondcp2;
        Secondcp[2] = secondcp3;

        Secondch[0] = secondch1;    
        Secondch[1] = secondch2;
        Secondch[2] = secondch3;

        for (int n=0; n<=2; n++)
        {
            switch (Secondph[n])
            {
                case "Goo":
                    Phand[n].color = Color.red;
                    break;
                case "Choki":
                    Phand[n].color = Color.green;
                    break;
                case "Pa":
                    Phand[n].color = Color.blue;
                    break;                    
            }
            switch (Secondch[n])
            {
                case "Goo":
                    Chand[n].color = Color.red;
                    break;
                case "Choki":
                    Chand[n].color = Color.green;
                    break;
                case "Pa":
                    Chand[n].color = Color.blue;
                    break;
            }


            switch (Secondph[n])
            {
                case "Goo":
                    switch (Secondch[n])
                    {
                        case "Goo":
                            JankenResult[n] = 3;
                            SPP[n] = Secondpp[n];
                            SCP[n] = Secondcp[n];
                            break;
                        case "Choki":
                            JankenResult[n] = 1;
                            SPP[n] = Secondpp[n] * 2;
                            SCP[n] = Secondcp[n];
                            break;
                        case "Pa":
                            JankenResult[n] = 2;
                            SPP[n] = Secondpp[n];
                            SCP[n] = Secondcp[n] * 2;
                            break;
                    }
                    break;
                case "Choki":
                    switch (Secondch[n])
                    {
                        case "Goo":
                            JankenResult[n] = 2;
                            SPP[n] = Secondpp[n];
                            SCP[n] = Secondcp[n]*2;
                            break;
                        case "Choki":
                            JankenResult[n] = 3;
                            SPP[n] = Secondpp[n];
                            SCP[n] = Secondcp[n];
                            break;
                        case "Pa":
                            JankenResult[n] = 1;
                            SPP[n] = Secondpp[n]*2;
                            SCP[n] = Secondcp[n];
                            break;
                    }
                    break;
                case "Pa":
                    switch (Secondch[n])
                    {
                        case "Goo":
                            JankenResult[n] = 1;
                            SPP[n] = Secondpp[n]*2;
                            SCP[n] = Secondcp[n];
                            break;
                        case "Choki":
                            JankenResult[n] = 2;
                            SPP[n] = Secondpp[n];
                            SCP[n] = Secondcp[n]*2;
                            break;
                        case "Pa":
                            JankenResult[n] = 3;
                            SPP[n] = Secondpp[n];
                            SCP[n] = Secondcp[n];
                            break;
                    }
                    break;
            }

            switch (colornum[n])
            {
                case 0:
                    if (Secondph[n] == "Goo")
                    {
                        SPP[n] = SPP[n] * 2;
                    }
                    if (Secondch[n] == "Goo")
                    {
                        SCP[n] = SCP[n] * 2;
                    }
                    break;
                case 1:
                    if (Secondph[n] == "Choki")
                    {
                        SPP[n] = SPP[n] * 2;
                    }
                    if (Secondch[n] == "Choki")
                    {
                        SCP[n] = SCP[n] * 2;
                    }
                    break;
                case 2:
                    if (Secondph[n] == "Pa")
                    {
                        SPP[n] = SPP[n] * 2;
                    }
                    if (Secondch[n] == "Pa")
                    {
                        SCP[n] = SCP[n] * 2;
                    }
                    break;
                default:
                    break;
            }

            if (SPP[n] > SCP[n])
            {
                Pafterpoint[n].color = Color.yellow;
                BattleResult[n] = 1;
                victorycount++;
            }
            else if (SPP[n] < SCP[n])
            {
                Cafterpoint[n].color = Color.yellow;
                BattleResult[n] = 2;
                defeatcount++;
            }
            else if (SPP[n] == SCP[n])
            {
                BattleResult[n] = 3;
            }
        }

        switch (BattleResult[0])
        {
            case 1:
                Result1.text = "WIN!!";
                Result1.color = Color.red;
                break;
            case 2:
                Result1.text = "LOSE...";
                Result1.color = Color.blue;
                break;
            case 3:
                Result1.text = "DRAW";
                Result1.color = Color.gray;
                break;
        }
        switch (BattleResult[1])
        {
            case 1:
                Result2.text = "WIN!!";
                Result2.color = Color.red;
                break;
            case 2:
                Result2.text = "LOSE...";
                Result2.color = Color.blue;
                break;
            case 3:
                Result2.text = "DRAW";
                Result2.color = Color.gray;
                break;
        }
        switch (BattleResult[2])
        {
            case 1:
                Result3.text = "WIN!!";
                Result3.color = Color.red;
                break;
            case 2:
                Result3.text = "LOSE...";
                Result3.color = Color.blue;
                break;
            case 3:
                Result3.text = "DRAW";
                Result3.color = Color.gray;
                break;
        }

        for(int n = 0; n < 2; n++)
        {
            panel[n].sprite = irodori[n];
        }
    }

    public void Go_nextscene()
    {
        DontDestroyOnLoad(this);
        Destroy(this.gameObject, 0.5f);
        FadeManager.Instance.LoadScene("END", 1.0f); ;
        AS.PlayOneShot(select3);
    }

    // Update is called once per frame
    void Update()
    {
        Phand1.text = Secondph[0];
        Phand2.text = Secondph[1];
        Phand3.text = Secondph[2];

        Chand1.text = Secondch[0];
        Chand2.text = Secondch[1];
        Chand3.text = Secondch[2];

        Pbeforepoint1.text = Secondpp[0] + "p";
        Pbeforepoint2.text = Secondpp[1] + "p";
        Pbeforepoint3.text = Secondpp[2] + "p";

        Cbeforepoint1.text = Secondcp[0] + "p";
        Cbeforepoint2.text = Secondcp[1] + "p";
        Cbeforepoint3.text = Secondcp[2] + "p";

        Pafterpoint1.text = SPP[0] + "p";
        Pafterpoint2.text = SPP[1] + "p";
        Pafterpoint3.text = SPP[2] + "p";

        Cafterpoint1.text = SCP[0] + "p";
        Cafterpoint2.text = SCP[1] + "p";
        Cafterpoint3.text = SCP[2] + "p";

        Resultsum.text = victorycount + " - " + defeatcount;
    }

   /* public void Showresult()
    {
        AS.PlayOneShot(select2);

        if (result1.activeSelf==false)
        {
            result1.SetActive(true);
            result2.SetActive(true);
            result3.SetActive(true);
        }
        else if(result1.activeSelf==true)
        {
            result1.SetActive(false);
            result2.SetActive(false);
            result3.SetActive(false);
        }
    }*/
}
