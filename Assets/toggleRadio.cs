using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleRadio : MonoBehaviour
{
    public GameObject radioOn, radioOff;
    public static bool radioIsOn = true;
    public static bool radioIsOff = false;

    public void turnOff()
    {
        if(radioIsOn)
        {
            radioOn.SetActive(false);
            radioOff.SetActive(true);
            radioIsOn = false;
            radioIsOff = true;
        }

    }

    public void turnOn()
    {
        if (radioIsOff)
        {
            radioOn.SetActive(true);
            radioOff.SetActive(false);
            radioIsOn = true;
            radioIsOff = false;
        }
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
