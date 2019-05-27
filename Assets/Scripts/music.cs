﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class music : MonoBehaviour
{
    public AudioClip musicSound;
    private AudioSource audioSource;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { audioSource.PlayOneShot(musicSound); }
    }
}
