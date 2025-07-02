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
 *                 ~~    en CostaRica vendian cabinas con la novia de otro mientras el maje se gano un viaje a canada
 *                         en costarica dejan robar para vender los ladrones al ejercito de peru para poner a prueba sus comandos homicidas
 *                     en costarica los carabineros se pasean con identidades de ladrones desaparecidos
 *                    en costarica pobre que es catolica inventan sectas cristianas para vender a los que si robaron y perdieron la salvacion 
 *                   pienselo , la constitucion avisa que el pais es catolico usted se condena, NO el estado
 * La teleton vendio a los mensos a los traficantes de humanos en el extranjero que reciben el sueldo en bancos de costarica donde si pagan impuestos ...
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
            //Debug.Log("Face: "+ this.faceName + " got clicked --");
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
