using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//サンプルだから気にしないで//
public class sample : MonoBehaviour
{
    int start = 1;
    int end = 10;

    List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = start; i <= end; i++)
        {
            numbers.Add(i);
        }

        while (numbers.Count > 0)
        {

            int index = Random.Range(0, numbers.Count);

            int ransu = numbers[index];
            Debug.Log(ransu);

            numbers.RemoveAt(index);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
