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

    public GameDirector director1;
    public GameDirector director2;
    public GameDirector director3;
    public GameDirector director4;
    public GameDirector director5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sum = director1.GetCount() + director2.GetCount() + director3.GetCount() + director4.GetCount() + director5.GetCount();
        sumP.text ="現在"+ sum+"p";

        rest = 150 - (director1.GetCount() + director2.GetCount() + director3.GetCount() + director4.GetCount() + director5.GetCount());
        restP.text="残り"+rest+"p";
    }

    public void Startbutton()
    {
      
            if (sum == 150)
            {
                SceneManager.LoadScene("Resultscene");    //Resultsceneというシーンに移る//
            }
            else
            {
                Debug.Log("not 150");
            }
            //選択されたトグルのテキストを読み取ってそれをコンソールに表示//
            //1個目//
            string selectedLabel1 = toggleGroup1.ActiveToggles()
            .First().GetComponentsInChildren<Text>()
            .First(t => t.name == "Label").text;

            Debug.Log("selected " + selectedLabel1);
            //2個目//
            string selectedLabel2 = toggleGroup2.ActiveToggles()
            .First().GetComponentsInChildren<Text>()
            .First(t => t.name == "Label").text;

            Debug.Log("selected " + selectedLabel2);
        　　//3個目//
            string selectedLabel3 = toggleGroup3.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;

            Debug.Log("selected " + selectedLabel3);
        　　//4個目//
            string selectedLabel4 = toggleGroup4.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;

            Debug.Log("selected " + selectedLabel4);
        　　//5個目//
            string selectedLabel5 = toggleGroup5.ActiveToggles()
                .First().GetComponentsInChildren<Text>()
                .First(t => t.name == "Label").text;

            Debug.Log("selected " + selectedLabel5);


    }



}
