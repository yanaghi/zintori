using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip effect1;
    public GameObject button;

    int pGooPoint = Resultscript.pGooPoint;
    int pChokiPoint = Resultscript.pChokiPoint;
    int pPaPoint = Resultscript.pPaPoint;
    int cGooPoint = Resultscript.cGooPoint;
    int cChokiPoint = Resultscript.cChokiPoint;
    int cPaPoint = Resultscript.cPaPoint;

    int viccount = Secondresult.victorycount;
    int defcount = Secondresult.defeatcount;

    public void Gobacktitle()
    {
        pGooPoint = 0;
        pChokiPoint = 0;
        pPaPoint = 0;
        cGooPoint = 0;
        cChokiPoint = 0;
        cPaPoint = 0;
        viccount = 0;
        defcount = 0;

        AS.PlayOneShot(effect1);
        FadeManager.Instance.LoadScene("Title", 1.2f); ;
    }

}
