using System.Threading;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                                 /(        )`
 *                                 \ \___   / |
 *                                 /- _  `-/  '
 *                                (/\/ \ \   /\
 *                                / /   | `    \
 *                                O O   ) /    |
 *                                `-^--'`<     '
 *                    TM         (_.)  _  )   /
 * |  | |\  | ~|~ \ /             `.___/`    /
 * |  | | \ |  |   X                `-----' /
 * `__| |  \| _|_ / \  <----.     __ / __   \
 *                     <----|====O)))==) \) /====
 *                     <----'    `--' `.__,' \
 *                                  |        |
 *                                   \       /
 *                              ______( (_  / \______
 *                            ,'  ,-----'   |        \
 *                            `--{__________)        \/
 * EXODUS {26:5} Fifty loops shalt thou make in the one curtain, 
 * and fifty loops shalt thou make in the edge of the curtain that is in the coupling of the second; 
 * that the loops may take hold one of another
 *  THE LORD WANTED US TO MAKE A NESTED LOOP ...
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class startBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public bool playerStart = false;
    public bool computerStart = false;
    //public Button start_btn;

    void Start()
    {
        Debug.Log("starting click handler");
        //this.start_btn.AddListener(clickHandler);
    }

    public void clickHandler(){
         Debug.Log("start button got clicked");
        this.whoStarts();
        if(this.playerStart){
            Debug.Log("player starts");
        }
        if(this.computerStart){
            Debug.Log("computer starts");
        }
    }

    public void gameStarterComputer(){

    }

    public void gameStarterPlayer(){

    }

    void whoStarts(){
        int randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,15.0f));
        Debug.Log("Random: "+randomValue);
        //Moses , had memory errors, javascript processes cant be kill the lord Kingdom is the Solaris IBM Sun...
        /*while(X < 15){
            randomValue = Random.Range(1,15);
            randomValue = Random.Range(1,15);
            randomValue = Random.Range(1,15);
            randomValue = Random.Range(1,15);
            x++;
        }
        
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
