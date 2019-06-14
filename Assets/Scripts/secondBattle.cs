using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class secondBattle : MonoBehaviour
{   //powerを表示するテキスト//

    public AudioSource AS;
    public AudioClip beep, select, select2, select3;

    //UnityのUI上でいろいろ指定//
    public Image[] panel = new Image[3];
    public Sprite[] color_panel = new Sprite[4];
    public static Sprite[] irodori = new Sprite[3];
    public static int[] colornum = new int[3];

    public Text label1;
    public Text label2;
    public Text label3;

    //1回戦目の結果を表示しておくテキスト//
    public Text PpointG;
    public Text PpointC;
    public Text PpointP;
    public Text CpointG;
    public Text CpointC;
    public Text CpointP;

    public static int power1 ;
    public static int power2 ;
    public static int power3 ;

    int p_GooPoint=Resultscript.pGooPoint;
    int p_ChokiPoint = Resultscript.pChokiPoint;
    int p_PaPoint = Resultscript.pPaPoint;
    int c_GooPoint = Resultscript.cGooPoint;
    int c_ChokiPoint = Resultscript.cChokiPoint;
    int c_PaPoint = Resultscript.cPaPoint;

    int p_GooPoint0 = Resultscript.pGooPoint;
    int p_ChokiPoint0 = Resultscript.pChokiPoint;
    int p_PaPoint0 = Resultscript.pPaPoint;
    int c_GooPoint0 = Resultscript.cGooPoint;
    int c_ChokiPoint0 = Resultscript.cChokiPoint;
    int c_PaPoint0 = Resultscript.cPaPoint;

    public ToggleGroup Checkbox1;
    public ToggleGroup Checkbox2;
    public ToggleGroup Checkbox3;

    bool checkedT1, checkedT2, checkedT3;

    public static string handtext1;
    public static string handtext2;
    public static string handtext3;

    int tempgoo1=0, tempchoki1=0, temppa1=0;
    int tempgoo2=0, tempchoki2=0, temppa2=0;
    int tempgoo3=0, tempchoki3=0, temppa3=0;

    // Start is called before the first frame update
    void Start()
    {
        power1 = 0;
        power2 = 0;
        power3 = 0;
        PpointG.text = p_GooPoint + "p";
        PpointC.text = p_ChokiPoint + "p";
        PpointP.text = p_PaPoint + "p";
        CpointG.text = c_GooPoint0 + "p";
        CpointC.text = c_ChokiPoint0 + "p";
        CpointP.text = c_PaPoint0 + "p";
        Updatelabel();  

        for(int n = 0; n <= 2; n++)
        {
            colornum[n] = Random.Range(0, 4);
            panel[n].sprite = color_panel[colornum[n]];
            irodori[n] = panel[n].sprite;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Checkbox1.AnyTogglesOn() == false)
        {
            handtext1 = null;
            checkedT1 = false;
        }
        else
        {
            handtext1 = Checkbox1.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;
            checkedT1 = true;
        }

        if (Checkbox2.AnyTogglesOn() == false)
        {
            handtext2 = null;
            checkedT2 = false;
        }
        else
        {
            handtext2 = Checkbox2.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;
            checkedT2 = true;
        }

        if (Checkbox3.AnyTogglesOn() == false)
        {
            handtext3 = null;
            checkedT3 = false;
        }
        else
        {
            handtext3 = Checkbox3.ActiveToggles()
              .First().GetComponentsInChildren<Text>()
              .First(t => t.name == "Label").text;
            checkedT3 = true;
        }
       
    }
        //１個目//
    public void ClickUp1()
    {
        if ((handtext1 != null))
        {
            switch (handtext1)
            {
                case "Goo":
                    if (p_GooPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power1 = power1 + 10;
                        tempgoo1 = tempgoo1 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
                case "Choki":
                    if (p_ChokiPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power1 = power1 + 10;
                        tempchoki1 = tempchoki1 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
                case "Pa":
                    if (p_PaPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power1 = power1 + 10;
                        temppa1 = temppa1 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
            }
            Updatelabel();
        }
        else
        {
            AS.PlayOneShot(beep);
        }
    }

    public void ClickDown1()
    {
        if ((power1 > 0)&&(handtext1!=null))
        {
            power1 = power1 - 10;

            switch (handtext1)
            {
                case "Goo":
                    AS.PlayOneShot(select);
                    tempgoo1 = tempgoo1 - 10;
                    break;
                case "Choki":
                    AS.PlayOneShot(select);
                    tempchoki1 = tempchoki1 - 10;                    
                    break;
                case "Pa":
                    AS.PlayOneShot(select);
                    temppa1 = temppa1 - 10;
                    break;
            }

            Updatelabel();

        }
        else
        {
            AS.PlayOneShot(beep);
        }
    }
        //2個目//
    public void ClickUp2()
    {    
        if (handtext2 != null)
        {            
            switch (handtext2)
            {
                case "Goo":
                    if (p_GooPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power2 = power2 + 10;
                        tempgoo2 = tempgoo2 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
                case "Choki":
                    if (p_ChokiPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power2 = power2 + 10;
                        tempchoki2 = tempchoki2 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
                case "Pa":
                    if (p_PaPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power2 = power2 + 10;
                        temppa2 = temppa2 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
            }
            Updatelabel();
        }
        else
        {
            AS.PlayOneShot(beep);
        }
    }

    public void ClickDown2()
    {
        if ((power2 > 0) && (handtext2 != null))
        {
            power2 = power2 - 10;

            switch (handtext2)
            {
                case "Goo":
                    AS.PlayOneShot(select);
                    tempgoo2 = tempgoo2 - 10;                    
                    break;
                case "Choki":
                    AS.PlayOneShot(select);
                    tempchoki2 = tempchoki2 - 10;
                    break;
                case "Pa":
                    AS.PlayOneShot(select);
                    temppa2 = temppa2 - 10;
                    break;
            }

            Updatelabel();
        }
        else
        {
            AS.PlayOneShot(beep);
        }
    }
        //3個目//
    public void ClickUp3()
    {
        if (handtext3 != null)
        {
            switch (handtext3)
            {
                case "Goo":
                    if (p_GooPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power3 = power3 + 10;
                        tempgoo3 = tempgoo3 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
                case "Choki":
                    if (p_ChokiPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power3 = power3 + 10;
                        tempchoki3 = tempchoki3 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
                case "Pa":
                    if (p_PaPoint > 0)
                    {
                        AS.PlayOneShot(select);
                        power3 = power3 + 10;
                        temppa3 = temppa3 + 10;
                    }
                    else
                    {
                        AS.PlayOneShot(beep);
                    }
                    break;
            }

            Updatelabel();
        }
        else
        {
            AS.PlayOneShot(beep);
        }
    }

    public void ClickDown3()
    {
        if ((power3 > 0) && (handtext3 != null))
        {
            power3 = power3 - 10;

            switch (handtext3)
            {
                case "Goo":
                    AS.PlayOneShot(select);
                    tempgoo3 = tempgoo3 - 10;
                    break;
                case "Choki":
                    AS.PlayOneShot(select);
                    tempchoki3 = tempchoki3 - 10;
                    break;
                case "Pa":
                    AS.PlayOneShot(select);
                    temppa3 = temppa3 - 10;
                    break;
            }

            Updatelabel();
        }
        else
        {
            AS.PlayOneShot(beep);
        }
     }

    void Updatelabel()
    {
        p_GooPoint = p_GooPoint0 - (tempgoo1 + tempgoo2 + tempgoo3);
        p_ChokiPoint = p_ChokiPoint0 - (tempchoki1 + tempchoki2 + tempchoki3);
        p_PaPoint = p_PaPoint0 - (temppa1 + temppa2 + temppa3);

        label1.text = power1 + "p";
        label2.text = power2 + "p";
        label3.text = power3 + "p";

        PpointG.text =p_GooPoint + "p";
        PpointC.text =p_ChokiPoint + "p";
        PpointP.text =p_PaPoint + "p";
    }

    public void togglechanged1()
    {
        power1 = 0;
        tempgoo1 = 0;
        tempchoki1 = 0;
        temppa1 = 0;
        Updatelabel();
        AS.PlayOneShot(select2);
    }

    public void togglechanged2()
    {
        power2 = 0;
        tempgoo2 = 0;
        tempchoki2 = 0;
        temppa1 = 0;
        Updatelabel();
        AS.PlayOneShot(select2);
    }

    public void togglechanged3()
    {
        power3 = 0;
        tempgoo3 = 0;
        tempchoki3 = 0;
        temppa3 = 0;
        Updatelabel();
        AS.PlayOneShot(select2);
    }

    public void start2ndBattle()
    {
        if ((checkedT1 == true) && (checkedT2 == true) && (checkedT3 == true))
        {
            DontDestroyOnLoad(this);
            Destroy(this.gameObject, 0.5f);
            SceneManager.LoadScene("2ndResult");
            AS.PlayOneShot(select3);
        }
        else
        {
            AS.PlayOneShot(beep);
        }

    }
}
