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
 *  ~~~~~~~~~~~~~~~ / /   en costarica muchos veian tele en tele robado a sus amigos ....
 *                 ~~
 * The Revolution wont be Televised.
 * VOTE POR EL PADRE PARA PRESIDENTE https://www.behance.net/gallery/219138909/Padre-Minor
 *
 * El Sandinismo es vivir en el exodo 13-15 , american airlines ticket to land of the amorites ...
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
        this.uptadeLastUsed();
    }

    void clickedFacedHandler(){
        
    }

    void uptadeLastUsed(){
        this.last_used = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
