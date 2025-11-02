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
    private bool is_x = false;
    private bool is_o = false;

    //private playerTTT player;

    public string circleFaceName = "A1CircleFace"; 
    public string exFaceName = "A1XFace"; 
    // Start is called before the first frame update
    void Start()
    {
        this.diablo = GameObject.FindWithTag("teletranClone").GetComponent<diabloDelTicTacToe>();
        this.player = GameObject.FindWithTag("teletranClone").GetComponent<playerTTT>();
        this.updateLastUsed();
    }

    void clickedFacedHandler(){
         Debug.Log("fume mota y lea poesia ....");
        if (Input.GetMouseButtonDown(1)){
            Debug.Log("Face: "+ this.faceName + " got clicked --");
            //this.is_player = true;
            //this.is_diablo = false;
            this.updateLastUsed();
            this.diablo.resetPlayerTimer();
            this.diablo.turnoDelDiablo();
        }
    }

    void OnMouseDown()
        {
            Debug.Log("Object clicked!");
            Debug.Log("Face: "+ this.faceName + " got clicked --");
            Debug.Log("Player is x: "+ this.player.is_x);
            Debug.Log("Player is o: "+ this.player.is_o);
            this.player.pushFace(this.faceName);
            if(this.player.is_x){
                Debug.Log("FaceX: "+ this.FaceXTag);
                this.showX();
            }
             if(this.player.is_o){
                Debug.Log("FaceO: "+ this.FaceOTag);
                this.showO();
            }
            // Add your desired actions here
            /*
             this.is_player = true;
            this.is_diablo = false;
            this.updateLastUsed();
            this.diablo.resetPlayerTimer();
            this.diablo.turnoDelDiablo();
            */
        }

    public void showX(){
        GameObject.FindWithTag(this.FaceXTag).SetActive(false);
    }
    
    public void showO(){
        GameObject.FindWithTag(this.FaceOTag).SetActive(false);
    }

    public void setDiablo(){
        //set by the Diablo
        Debug.Log("Face: "+ this.faceName + " got clicked --");
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
