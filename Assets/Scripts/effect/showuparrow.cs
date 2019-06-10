using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showuparrow : MonoBehaviour
{
    public GameObject arrow;
    public AudioSource AS;
    public AudioClip effect1;

    // Start is called before the first frame update
    void Start()
    {
        arrow.SetActive(false);
        Invoke("showupA", 0.7f);
    }

    public void showupA()
    {
        arrow.SetActive(true);
        AS.PlayOneShot(effect1);
    }
}
