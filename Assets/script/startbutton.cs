using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startbutton : MonoBehaviour
{
    public GameDirector gamedirector;
    private Text targetText;
    // Start is called before the first frame update
    void Start()
    {
        int count;
        count = gamedirector.GetCount();
        Debug.Log(count);
    }

    void Gtext()
    {
        this.targetText = this.GetComponent<Text>();
        this.targetText.text = "ChangeText";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
