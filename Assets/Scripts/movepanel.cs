using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movepanel : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip select;
    public GameObject panelOld;
    public GameObject panelNew;
    public GameObject panelThis;
    // Start is called before the first frame update

    public void MoveNextPanel()
    {
        AS.PlayOneShot(select);
        panelThis.SetActive(false);
        panelNew.SetActive(true);
    }

    public void MoveBoforePanel()
    {
        AS.PlayOneShot(select);
        panelThis.SetActive(false);
        panelOld.SetActive(true);
    }
}
