using System.Threading;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                       _. - ~ ~ ~ - .
 *   ..       __.    .-~               ~-.
 *   ((\     /   `}.~                     `.
 *    \\\   {     }               /     \   \
 *(\   \\~~^      }              |       }   \
 * \`.-~ -@~      }  ,-.         |       )    \
 * (___     ) _}   (    :        |    / /      `.
 *  `----._-~.     _\ \ |_       \   / /- _      `.
 *         ~~----~~  \ \| ~~--~~~(  + /     ~-.     ~- _
 *                   /  /         \  \          ~- . _ _~_-_.
 *                __/  /          _\  )
 *              .<___.'         .<___/
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
    private diabloDelTicTacToe diablo;
    //public Button start_btn;

    void Start()
    {
        //Debug.Log("starting start click handler");
        this.diablo = GameObject.FindWithTag("teletranClone").GetComponent<diabloDelTicTacToe>();
        //this.start_btn.AddListener(clickHandler);
    }

    public void clickHandler(){
         //Debug.Log("start button got clicked");
        this.whoStarts();
        if(this.playerStart){
            Debug.Log("player starts");
            this.hideStartScreen();
            this.diablo.pasePorDelante();
        }
        if(this.computerStart){
            Debug.Log("computer starts");
            this.hideStartScreen();
            this.diablo.elDiabloPrimero();
        }
        //return null;
    }

    void hideStartScreen(){
        GameObject.FindWithTag("startMenuTag").SetActive(false);
    }

    public void gameStarterComputer(){

    }

    public void gameStarterPlayer(){

    }

    void whoStarts(){
        int randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,10.0f));
        //Debug.Log("starting Random: "+randomValue);
        //Moses , had memory errors, javascript processes cant be kill the lord Kingdom is the Solaris IBM Sun...
        int x = 0;
        while(x < 15){
            randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,10.0f));
            randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,10.0f));
            randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,10.0f));
            randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,10.0f));
            x++;
        }
        //Debug.Log("Random: "+randomValue);
        if(randomValue>5){
            this.playerStart = true;
            this.computerStart = false;
        }
        if(randomValue<6){
            this.computerStart = true;
            this.playerStart = false;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
