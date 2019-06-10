using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class title : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip select,effect1;

    public GameObject manual;
    public GameObject credit;

    // Start is called before the first frame update
    void Start()
    {
        manual.SetActive(false);
        credit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Startbutton()
    {
        DontDestroyOnLoad(this);
        Destroy(this.gameObject, 0.5f);
        AS.PlayOneShot(effect1);
        FadeManager.Instance.LoadScene("1stSetting", 1.0f);
    }

    public void Manualbutton()
    {
        AS.PlayOneShot(select);
        manual.SetActive(true);
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

    public void Manualback()
    {
        AS.PlayOneShot(select);
        manual.SetActive(false);
    }
}
