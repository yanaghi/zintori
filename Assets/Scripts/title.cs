using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip select,effect1;

    public GameObject manual1;
    public GameObject manual2;
    public GameObject manual3;
    public GameObject credit;

    // Start is called before the first frame update
    void Start()
    {
        manual1.SetActive(false);
        credit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Startbutton()
    {
        AS.PlayOneShot(effect1);
        FadeManager.Instance.LoadScene("1stSetting", 1.0f);
    }

    public void Manualbutton()
    {
        AS.PlayOneShot(select);
        manual1.SetActive(true);
    }

    public void Creditbutton()
    {
        AS.PlayOneShot(select);
        credit.SetActive(true);
    }

    public void Creditback()
    {
        AS.PlayOneShot(select);
        credit.SetActive(false);
    }

    public void Manualback1()
    {
        AS.PlayOneShot(select);
        manual1.SetActive(false);
    }
    public void Manualback2()
    {
        AS.PlayOneShot(select);
        manual2.SetActive(false);
    }
    public void Manualback3()
    {
        AS.PlayOneShot(select);
        manual3.SetActive(false);
    }
}
