using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SumPoint : MonoBehaviour
{
    int sum;
    public Text sump;
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
        sump.text = sum+"p";
    }

    public void Startbutton()
    {
      
            if (sum == 150)
            {
                SceneManager.LoadScene("sample");
            }
            else
            {
                Debug.Log("not 150");
            }
        
           

    }



}
