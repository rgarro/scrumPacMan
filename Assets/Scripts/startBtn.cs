using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBtn : MonoBehaviour
{
    // Start is called before the first frame update

    
    public bool playerStart = false;
    public bool computerStart = false;

    void Start()
    {
        Debug.Log("start button got clicked");
        this.whoStarts();
        if(this.playerStart){
            
        }
        if(this.computerStart){
            
        }
    }

    void gameStarterComputer(){

    }

    void gameStarterPlayer(){

    }

    void whoStarts(){
        /*int randomValue = Random.Range(1,10);
        //heating random seed generator
        randomValue = Random.Range(1,10);
        randomValue = Random.Range(1,10);
        randomValue = Random.Range(1,10);
        randomValue = Random.Range(1,10);
        if(randomValue>5){
            this.playerStart = true;
            this.computerStart = false;
        }
        if(randomValue<5){
            this.computerStart = true;
            this.playerStart = false;
        }*/
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
