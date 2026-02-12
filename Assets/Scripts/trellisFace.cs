//using System.Diagnostics;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *  _______________
 * |,----------.  |\
 * ||           |=| |
 * ||          || | |
 * ||       . _o| | | __
 * |`-----------' |/ /~/
 *  ~~~~~~~~~~~~~~~ / /   face of the hash sign trellis ....
 *                 ~~        
 *  
 *
 *
 *@author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class trellisFace : MonoBehaviour
{
 
    public bool is_player = false;
    public bool is_diablo = false;
    public bool is_exFace = false;
    public bool is_circleFace = false;
    public string faceName = "B1";
    public string FaceXTag = "XB1";
    public string FaceOTag = "OB1";
    private float last_used = 0.0f;
    private diabloDelTicTacToe diablo;
    private playerTTT player;
    private flasyText updateText;
    private bool is_x = false;
    private bool is_o = false;

    //private playerTTT player;

    public string circleFaceName = "A1CircleFace"; 
    public string exFaceName = "A1XFace";
    private restartTimeOut playerTimer;

    // Start is called before the first frame update
    void Start()
    {
        this.diablo = GameObject.FindWithTag("teletranClone").GetComponent<diabloDelTicTacToe>();
        this.player = GameObject.FindWithTag("teletranClone").GetComponent<playerTTT>();
        this.playerTimer = GameObject.FindWithTag("teletranClone").GetComponent<restartTimeOut>();
        this.updateText = GameObject.FindWithTag("teletranClone").GetComponent<flasyText>();
        this.updateLastUsed();
    }

    void clickedFacedHandler(){//existe pero no se invoca ..
        if (Input.GetMouseButtonDown(1)){
            //Debug.Log("Object OB clicked!");//
        }
    }

    void OnMouseDown()
        {
            this.updateText.setFlashMsg("Player Plays Corner "+this.faceName);
            this.player.pushFace(this.faceName);
            if(this.player.is_x){
                this.showX();
            }
             if(this.player.is_o){
                this.showO();
            }
            this.playerTimer.stopTimer();
            this.diablo.turnoDelDiablo();
            // Add your desired actions here
        }

    public void showX(){
            GameObject childObject = transform.Find(this.exFaceName)?.gameObject;
            if (childObject != null)
            {
                childObject.SetActive(true);
            }
    }
    
    public void showO(){
            GameObject childObject = transform.Find(this.circleFaceName)?.gameObject;
            if (childObject != null)
            {
                childObject.SetActive(true);
            }
    }

    public void setDiablo(){
        //set by the Diablo
        //Debug.Log("Face: "+ this.faceName + " got clicked --");
        if(this.is_diablo){
            this.showX();
        }
        if(this.is_player){
            this.showX();
        }
        this.updateLastUsed();
        this.diablo.turnoDelPlayer();
    }

    void setFaceSprite(){
        
    }

    void updateLastUsed(){
        this.last_used = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        this.clickedFacedHandler();
    }
}
