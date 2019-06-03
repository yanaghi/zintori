using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class SumPoint : MonoBehaviour
{
    public Text label1,label2,label3,label4,label5;
 
    public static int count1,count2,count3,count4,count5;

    //それぞれのパネルの選択肢//
    public ToggleGroup toggleGroup1, toggleGroup2, toggleGroup3, toggleGroup4, toggleGroup5;

    public int sum;
    public int rest;
    public Text SumP;
    public Text RestP;

    public static string selectedLabel1, selectedLabel2, selectedLabel3, selectedLabel4, selectedLabel5;

    public AudioSource AS;
    public AudioClip beep, select, select2, select3;

    bool checkedT1, checkedT2, checkedT3, checkedT4, checkedT5;

    // Start is called before the first frame update
    void Start()
    {
        count1 = 10;
        count2 = 10;
        count3 = 10;
        count4 = 10;
        count5 = 10;

        UpdateLabel();
    }

    // Update is called once per frame
    void Update()
    {
        sum = count1 + count2 + count3 + count4 + count5;
        SumP.text ="現在"+ sum+"p";

        rest = 150 - (count1 + count2 + count3 + count4 + count5);
        RestP.text="残り"+rest+"p";

        checkedT1 = toggleGroup1.AnyTogglesOn();
        checkedT2 = toggleGroup2.AnyTogglesOn();
        checkedT3 = toggleGroup3.AnyTogglesOn();
        checkedT4 = toggleGroup4.AnyTogglesOn();
        checkedT5 = toggleGroup5.AnyTogglesOn();
    }
    
    //STARTボタンを押したときの処理//
    public void Startbutton()
    {     
            if ((sum == 150)&&(checkedT1==true)&&(checkedT2==true)&&(checkedT3==true)&&(checkedT4==true)&&(checkedT5==true))
            {
                DontDestroyOnLoad(this);
                AS.PlayOneShot(select3);
                SceneManager.LoadScene("ShowHands");    //シーン移動//
                Invoke("Destroy", 2);
            }
            else
            {
            AS.PlayOneShot(beep);
            }

            //Goo.Choki,Paのどれが選ばれたのかをstringで取得//
            selectedLabel1 = toggleGroup1.ActiveToggles()
            .First().GetComponentsInChildren<Text>()
            .First(t => t.name == "Label").text;
        
            selectedLabel2 = toggleGroup2.ActiveToggles()
            .First().GetComponentsInChildren<Text>()
            .First(t => t.name == "Label").text;

            selectedLabel3 = toggleGroup3.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;
        
            selectedLabel4 = toggleGroup4.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;

            selectedLabel5 = toggleGroup5.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;
    }

    public void ClickUp1()
    {
        if (sum < 150)
        {
            AS.PlayOneShot(select);
            count1 = count1 + 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickDown1()
    {
        if (count1 > 10)
        {
            AS.PlayOneShot(select);
            count1 = count1 - 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickUp2()
    {
        if (sum < 150)
        {
            AS.PlayOneShot(select);
            count2 = count2 + 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickDown2()
    {
        if (count2 > 10)
        {
            AS.PlayOneShot(select);
            count2 = count2 - 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickUp3()
    {
        if (sum < 150)
        {
            AS.PlayOneShot(select);
            count3 = count3 + 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickDown3()
    {
        if (count3 > 10)
        {
            AS.PlayOneShot(select);
            count3 = count3 - 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickUp4()
    {
        if (sum < 150)
        {
            AS.PlayOneShot(select);
            count4 = count4 + 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickDown4()
    {
        if (count4 > 10)
        {
            AS.PlayOneShot(select);
            count4 = count4 - 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickUp5()
    {
        if (sum < 150)
        {
            AS.PlayOneShot(select);
            count5 = count5 + 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    public void ClickDown5()
    {
        if (count5 > 10)
        {
            AS.PlayOneShot(select);
            count5 = count5 - 10;
        }
        else
        {
            AS.PlayOneShot(beep);
        }
        UpdateLabel();
    }

    void UpdateLabel()
    {
        label1.text = count1 + "p";
        label2.text = count2 + "p";
        label3.text = count3 + "p";
        label4.text = count4 + "p";
        label5.text = count5 + "p";

    }

    //selectedlabelを取得する関数//
    public static string Getmyhand(int n)
    {
        if (n == 1)
        {
            return selectedLabel1;
        }
        else if (n == 2)
        {
            return selectedLabel2;
        }
        else if (n == 3)
        {
            return selectedLabel3;
        }
        else if (n == 4)
        {
            return selectedLabel4;
        }
        else if (n == 5)
        {
            return selectedLabel5;
        }
        else
        {
            return null;
        }
    }

    public void ToggleClicked()
    {
        AS.PlayOneShot(select2);
    }

    public void Destroy()
    {
        DestroyImmediate(this);
    }

}
