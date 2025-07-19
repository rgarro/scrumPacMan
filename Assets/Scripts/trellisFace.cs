using System.Threading;
using System.Diagnostics;
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
 *  ~~~~~~~~~~~~~~~ / /   en CostaRica muchos veian tele en tele robado a sus amigos ....
 *                 ~~   mas miedo que un Bar de periqueros cerca de Ojo de Agua en 1978 ...
 *                
 *  
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class trellisFace : MonoBehaviour
{
 
    public bool is_player = false;
    public bool is_diablo = false;
    public bool is_exFace = false;
    public bool is_circleFace = false;
    public string faceName = "B1";
    private float last_used = 0.0f;

    public string circleFaceName = "A1CircleFace"; 
    public string exFaceName = "A1XFace"; 
    // Start is called before the first frame update
    void Start()
    {
        this.updateLastUsed();
    }

    void clickedFacedHandler(){
        if (Input.GetMouseButtonDown(1)){
            //Debug.Log("Face: "+ this.faceName + " got clicked --");
            this.is_player = true;
            this.is_diablo = false;
        }
    }

    void setDiablo(){
        //set by the Diablo
        this.is_diablo = true;
        this.is_player = false;
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
