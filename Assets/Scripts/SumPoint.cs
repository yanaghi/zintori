using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class SumPoint : MonoBehaviour
{
    //Toggleグループを作った//
    public ToggleGroup toggleGroup1;
    public ToggleGroup toggleGroup2;
    public ToggleGroup toggleGroup3;
    public ToggleGroup toggleGroup4;
    public ToggleGroup toggleGroup5;

    public int sum;
    public int rest;
    public Text sumP;
    public Text restP;

    public static string selectedLabel1;
    public static string selectedLabel2;
    public static string selectedLabel3;
    public static string selectedLabel4;
    public static string selectedLabel5;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sum = GameDirector.GetCount(1) + GameDirector.GetCount(2) + GameDirector.GetCount(3) + GameDirector.GetCount(4) + GameDirector.GetCount(5);
        sumP.text ="現在"+ sum+"p";

        rest = 150 - (GameDirector.GetCount(1) + GameDirector.GetCount(2) + GameDirector.GetCount(3) + GameDirector.GetCount(4) + GameDirector.GetCount(5));
        restP.text="残り"+rest+"p";
    }

    public void Startbutton()
    {
      
            if (sum == 150)
            {
                SceneManager.LoadScene("Battlescene");    //Battlesceneに移る//
            }
            else
            {
                Debug.Log("not 150");
            }
            //選択されたトグルのテキストを読み取る//
            //1個目//
            selectedLabel1 = toggleGroup1.ActiveToggles()
            .First().GetComponentsInChildren<Text>()
            .First(t => t.name == "Label").text;
        
            //2個目//
            selectedLabel2 = toggleGroup2.ActiveToggles()
            .First().GetComponentsInChildren<Text>()
            .First(t => t.name == "Label").text;

        　　//3個目//
            selectedLabel3 = toggleGroup3.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;
        
        　　//4個目//
            selectedLabel4 = toggleGroup4.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;

        　　//5個目//
            selectedLabel5 = toggleGroup5.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;


    }
    //プレイヤーの手を取得する関数//
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
        else
        {
            return selectedLabel5;
        }
        
    }

}
