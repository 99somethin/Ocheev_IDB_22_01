using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bush : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    [SerializeField] int count_obj;


    public void OnTriggerEnter(Collider other)
    {
        count_obj++;

        _text.text = count_obj.ToString();

        
    }
}
