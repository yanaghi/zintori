using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text label1;
    public Text label2;
    public Text label3;
    public Text label4;
    public Text label5;

    public static int count1;
    public static int count2;
    public static int count3;
    public static int count4;
    public static int count5;

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
   //１個目//
    public void ClickUp1()
    { 
        if (count1 < 110)
        {
            count1=count1+10;
        }
        UpdateLabel();
    }

    //数字を下げる
    public void ClickDown1()
    {
        if (count1 > 10)
        {
            count1=count1-10;
        }       
        UpdateLabel();
    }
    //2個目//
    public void ClickUp2()
    {
        if (count2 < 110)
        {
            count2 = count2 + 10;
        }
        UpdateLabel();
    }

    //数字を下げる
    public void ClickDown2()
    {
        if (count2 > 10)
        {
            count2 = count2 - 10;
        }
        UpdateLabel();
    }
    //３個目//
    public void ClickUp3()
    {
        if (count3 < 110)
        {
            count3 = count3 + 10;
        }
        UpdateLabel();
    }

    //数字を下げる
    public void ClickDown3()
    {
        if (count3 > 10)
        {
            count3 = count3 - 10;
        }
        UpdateLabel();
    }
    //４個目//
    public void ClickUp4()
    {
        if (count4 < 110)
        {
            count4 = count4 + 10;
        }
        UpdateLabel();
    }

    //数字を下げる
    public void ClickDown4()
    {
        if (count4 > 10)
        {
            count4 = count4 - 10;
        }
        UpdateLabel();
    }
    //５個目//
    public void ClickUp5()
    {
        if (count5 < 110)
        {
            count5 = count5 + 10;
        }
        UpdateLabel();
    }

    //数字を下げる
    public void ClickDown5()
    {
        if (count5 > 10)
        {
            count5 = count5 - 10;
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
    // Update is called once per frame
    void Update()
    {
        
    }

    //取得用関数
    public static int GetCount(int n)
    {
        if (n == 1)
        {
            return count1;
        }
        else if(n==2)
        {
            return count2;
        }
        else if (n == 3)
        {
            return count3;
        }
        else if (n == 4)
        {
            return count4;
        }
        else if(n==5)
        {
            return count5;
        }
        else
        {
            return 0;
        }
    }
}
