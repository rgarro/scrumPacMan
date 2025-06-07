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
 *EXODUS {26:5} Fifty loops shalt thou make in the one curtain, 
 *and fifty loops shalt thou make in the edge of the curtain that is in the coupling of the second; 
 *that the loops may take hold one of another
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
        int randomValue = Random.Range(1,15);
        //Moses , had memory errors, javascript processes cant be kill the lord Kingdom is the Solaris IBM Sun...
        while(X < 15){
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
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
