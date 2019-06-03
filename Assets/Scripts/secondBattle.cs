using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class secondBattle : MonoBehaviour
{   //powerを表示するテキスト//
    public Text label1;
    public Text label2;
    public Text label3;
    //1回戦目の結果を表示しておくテキスト//
    public TextMeshProUGUI PpointG;
    public TextMeshProUGUI PpointC;
    public TextMeshProUGUI PpointP;
    public TextMeshProUGUI CpointG;
    public TextMeshProUGUI CpointC;
    public TextMeshProUGUI CpointP;

    public static int power1 ;
    public static int power2 ;
    public static int power3 ;

    int p_GooPoint=Resultscript.pGooPoint;
    int p_ChokiPoint = Resultscript.pChokiPoint;
    int p_PaPoint = Resultscript.pPaPoint;
    public static int c_GooPoint = Resultscript.cGooPoint;
    public static int c_ChokiPoint = Resultscript.cChokiPoint;
    public static int c_PaPoint = Resultscript.cPaPoint;

    int p_GooPoint0 = Resultscript.pGooPoint;
    int p_ChokiPoint0 = Resultscript.pChokiPoint;
    int p_PaPoint0 = Resultscript.pPaPoint;
    int c_GooPoint0 = Resultscript.cGooPoint;
    int c_ChokiPoint0 = Resultscript.cChokiPoint;
    int c_PaPoint0 = Resultscript.cPaPoint;

    public ToggleGroup Checkbox1;
    public ToggleGroup Checkbox2;
    public ToggleGroup Checkbox3;

    public static string handtext1;
    public static string handtext2;
    public static string handtext3;

    // Start is called before the first frame update
    void Start()
    {

        power1 = 0;
        power2 = 0;
        power3 = 0;
        PpointG.text = p_GooPoint + "p";
        PpointC.text = p_ChokiPoint + "p";
        PpointP.text = p_PaPoint + "p";
        CpointG.text = c_GooPoint + "p";
        CpointC.text = c_ChokiPoint + "p";
        CpointP.text = c_PaPoint + "p";
        Updatelabel();  
    }

    // Update is called once per frame
    void Update()
    {
        if (Checkbox1.AnyTogglesOn() == false)
        {
            handtext1 = null;
        }
        else
        {
            handtext1 = Checkbox1.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;
        }
        if (Checkbox2.AnyTogglesOn() == false)
        {
            handtext2 = null;
        }
        else
        {
            handtext2 = Checkbox2.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;
        }
        if (Checkbox3.AnyTogglesOn() == false)
        {
            handtext3 = null;
        }
        else
        {
            handtext3 = Checkbox3.ActiveToggles()
              .First().GetComponentsInChildren<Text>()
              .First(t => t.name == "Label").text;
        }
       
    }
        //１個目//
    public void ClickUp1()
    {


        if (handtext1 != null)
        {
            power1 = power1 + 10;

            if (handtext1 == "Goo")
            {
                p_GooPoint = p_GooPoint - 10;
            }
            else if (handtext1 == "Choki")
            {
                p_ChokiPoint = p_ChokiPoint - 10;
            }
            else if (handtext1 == "Pa")
            {
                p_PaPoint = p_PaPoint - 10;
            }

            Updatelabel();
        }
    }

    public void ClickDown1()
    {
        if ((power1 > 0)&&(handtext1!=null))
        {
            power1 = power1 - 10;

            if (handtext1 == "Goo")
            {
                p_GooPoint = p_GooPoint + 10;
            }
            else if (handtext1 == "Choki")
            {
                p_ChokiPoint = p_ChokiPoint + 10;
            }
            else if (handtext1 == "Pa")
            {
                p_PaPoint = p_PaPoint + 10;
            }

            Updatelabel();
        }
    }
        //2個目//
    public void ClickUp2()
    {
      
        if (handtext2 != null)
        {
            power2 = power2 + 10;

            if (handtext2 == "Goo")
            {
                p_GooPoint = p_GooPoint - 10;
            }
            else if (handtext2 == "Choki")
            {
                p_ChokiPoint = p_ChokiPoint - 10;
            }
            else if (handtext2 == "Pa")
            {
                p_PaPoint = p_PaPoint - 10;
            }

            Updatelabel();
        }
    }

    public void ClickDown2()
    {
        if ((power2 > 0) && (handtext2 != null))
        {
            power2 = power2 - 10;

            if (handtext2 == "Goo")
            {
                p_GooPoint = p_GooPoint + 10;
            }
            else if (handtext2 == "Choki")
            {
                p_ChokiPoint = p_ChokiPoint + 10;
            }
            else if (handtext2 == "Pa")
            {
                p_PaPoint = p_PaPoint + 10;
            }

            Updatelabel();
        }
    }
        //3個目//
    public void ClickUp3()
    {
       

        if (handtext3 != null)
        {
            power3 = power3 + 10;

            if (handtext3 == "Goo")
            {
                p_GooPoint = p_GooPoint - 10;
            }
            else if (handtext3 == "Choki")
            {
                p_ChokiPoint = p_ChokiPoint - 10;
            }
            else if (handtext3 == "Pa")
            {
                p_PaPoint = p_PaPoint - 10;
            }

            Updatelabel();
        }
    }

    public void ClickDown3()
    {
        if ((power3 > 0) && (handtext3 != null))
        {
            power3 = power3 - 10;

            if (handtext3 == "Goo")
            {
                p_GooPoint = p_GooPoint + 10;
            }
            else if (handtext3 == "Choki")
            {
                p_ChokiPoint = p_ChokiPoint + 10;
            }
            else if (handtext3 == "Pa")
            {
                p_PaPoint = p_PaPoint + 10;
            }

            Updatelabel();
        }
     }

    void Updatelabel()
    {
        label1.text = power1 + "p";
        label2.text = power2 + "p";
        label3.text = power3 + "p";
        PpointG.text =p_GooPoint + "p";
        PpointC.text =p_ChokiPoint + "p";
        PpointP.text =p_PaPoint + "p";
    }

    public void togglechanged()
    {
        power1 = 0;
        power2 = 0;
        power3 = 0;
        p_GooPoint = p_GooPoint0;
        p_ChokiPoint = p_ChokiPoint0;
        p_PaPoint = p_PaPoint0;
        Updatelabel();
    }

    public void start2ndBattle()
    {
        SceneManager.LoadScene("2ndResult");
    }
}
