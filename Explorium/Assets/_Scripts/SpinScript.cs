using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpinScript : MonoBehaviour
{
    public float speed = 2f;
    public GameObject Quiz;
    //public TextMeshProUGUI test;



    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }

    void OnMouseDown()
    {
        //print("touch me");
        //test.SetText("Touch Me!");
        Quiz.SetActive(true);
    }

}
