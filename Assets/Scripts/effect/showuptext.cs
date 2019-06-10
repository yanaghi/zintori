using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showuptext : MonoBehaviour
{
    public GameObject text;
    public AudioSource AS;
    public AudioClip effect;
    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        Invoke("showupT", 1.4f);
    }

    public void showupT()
    {
        text.SetActive(true);
        AS.PlayOneShot(effect);
    }
}
