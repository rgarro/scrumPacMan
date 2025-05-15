using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBtn : MonoBehaviour
{
    // Start is called before the first frame update

    
    public bool playerStart = false;
    void Start()
    {
        Debug.Log("start button got clicked");
        if(this.whoStarts()){
            
        }
    }

    void gameStarter(){

    }

    bool whoStarts(){
        return false;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
