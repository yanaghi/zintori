using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class mouseover : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource AS;
    public AudioClip select2;
    public void OnPointerEnter(PointerEventData eventData)
    {
        AS.PlayOneShot(select2);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
