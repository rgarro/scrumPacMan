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
 *                 ~~     los de Merayo de 1983 dijo el fantasma de 
 *                        los que fueron a ojo de agua en mayo de 1982 prostituian vecinas
 *                        Voces de la OUIJA , Voces de la OUIJA .....
 *                        las del baile del comunal agosto 1984 desculiaron la empleada de un vecino, el exnovio celebro
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
        }
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
