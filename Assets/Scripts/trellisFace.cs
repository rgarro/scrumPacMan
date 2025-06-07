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
 *                 ~~     cuando gato tenga 18 meses de incinerado en la morgue del siquiatrico yo dejo de fumar mota
 *                        garro no le pago ni le pagara a bolincha
 *                        bolincha huele a kk
 *                         si aparece el muerto de gato yo vuelvo a fumar mota
 *                       bolincha espia el padron de votantes y juega de base de datos con vecinos
 *                       a un maje de moravia ya lo mataron por jugar asi
 *                         policias centroamericanos mataron a ladrones de tilaran en la interamericana
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
    
    // Start is called before the first frame update
    void Start()
    {
        this.updateLastUsed();
    }

    void clickedFacedHandler(){
        if (Input.GetMouseButtonDown(1)){
            Debug.Log("Face: "+ this.faceName + " got clicked --");
            this.is_player = true;
        }
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
