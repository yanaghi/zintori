using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip effect1;
    public GameObject button;

    public void Gobacktitle()
    {
        AS.PlayOneShot(effect1);
        DontDestroyOnLoad(button);
        Destroy(button, 1.0f);
        FadeManager.Instance.LoadScene("Title", 1.0f); ;
    }

}
