using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class secondBattle : MonoBehaviour
{
    public Text label1;
    public Text label2;
    public Text label3;

    public TextMeshProUGUI PpointG;
    public TextMeshProUGUI PpointC;
    public TextMeshProUGUI PpointP;
    public TextMeshProUGUI CpointG;
    public TextMeshProUGUI CpointC;
    public TextMeshProUGUI CpointP;

    static int power1 ;
    static int power2 ;
    static int power3 ;

    public int[] hand_point = Resultscript.Hand_Point;

    // Start is called before the first frame update
    void Start()
    {
        power1 = 0;
        power2 = 0;
        power3 = 0;
        Updatelabel();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        //１個目//
    public void ClickUp1()
    {
        power1 = power1 + 10;
        Updatelabel();
    }

    public void ClickDown1()
    {
        if (power1 > 0)
        {
            power1 = power1 - 10;
        }    
        Updatelabel();
    }
        //2個目//
        public void ClickUp2()
        {
            power2 = power2 + 10;
            Updatelabel();
        }

        public void ClickDown2()
        {
          if (power2 > 0)
        {
            power2 = power2 - 10;
        }
          Updatelabel();
        }
        //3個目//
        public void ClickUp3()
        {
            power3 = power3 + 10;
            Updatelabel();
        }

        public void ClickDown3()
        {
        if (power3 > 0)
        {
            power3 = power3 - 10;
        }
            Updatelabel();
        }

    void Updatelabel()
    {
        label1.text = power1 + "p";
        label2.text = power2 + "p";
        label3.text = power3 + "p";
        PpointG.text = hand_point[0] + "p";
        PpointC.text = hand_point[1] + "p";
        PpointP.text = hand_point[2] + "p";
        CpointG.text = hand_point[3] + "p";
        CpointC.text = hand_point[4] + "p";
        CpointP.text = hand_point[5] + "p";
    }
}
