using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text label;
    public int count;
    //取得用関数,これって何だっけ
    public int GetCount()
    {
        return count;
    }
   
    // Start is called before the first frame update
    void Start()
    {
        count = 10;
        UpdateLabel();
        Debug.Log(count);
    }
    //1個目
    public void Click1()
    {
        if (count < 110)
        {
            count=count+10;
        }
        UpdateLabel();
    }

    //数字を下げる
    public void Click2()
    {
        if (count > 10)
        {
            count=count-10;
        }       
        UpdateLabel();
    }
  

    void UpdateLabel()
    {
        label.text = count+"p" ;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
