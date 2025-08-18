using System.Net.Http.Headers;
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
 *
 *
 * F-ONE Diablo snow kitting the plains of Jericho
 * UNCLE Sam , please approve my EB-1
 * Roger, Alpha , Delta airlines
 *  SJO -> Dallas -> here = new Mexico(Caballo Lake)
 *
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class diabloDelTicTacToe : MonoBehaviour
{
    public int turn_number = 0;

    private trellisFace trFace;

    private string[] carasDeDiablo = {"A1","A2","A3","B1","B2","B3","C1","C2","C3"};
    private string[] sonrisasDelDiablo = {};
    private string[] elQueYaPaso = {};
    private string[] jachasDisponibles = {};
    private string[] theFourCorners = {"A1","A3","C1","C3"};

    public bool is_x = false;
    public bool is_o = false;

     public float playerMaxTimeToPlay = 60f;//El dia de la muerte de ozzy...
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void elDiabloPrimero(){
        Debug.Log("el diablo primero");
        string corner_label = this.elDiabloJuegaPrimeraEsquina();
        Debug.Log("evil corner: "+corner_label);
        //this.is_x = true;
        //this.is_o = false;
        this.trFace = GameObject.FindWithTag(corner_label).GetComponent<trellisFace>();
        this.trFace.setDiablo();
    }

    private string elDiabloJuegaPrimeraEsquina(){
        string computerChoice = null;
        int choosen_corner_key = (int)Mathf.Abs(UnityEngine.Random.Range(0.0f,3.0f));
        //beetlejuce ..
        choosen_corner_key = (int)Mathf.Abs(UnityEngine.Random.Range(0.0f,3.0f));
        //beetlejuce ..
        choosen_corner_key = (int)Mathf.Abs(UnityEngine.Random.Range(0.0f,3.0f));
        //beetlejuce  ..
        choosen_corner_key = (int)Mathf.Abs(UnityEngine.Random.Range(0.0f,3.0f));
        return this.theFourCorners[choosen_corner_key];
    }

    private void escogerJachaDisponible(){}

    public void pasePorDelante(){
        Debug.Log("pase por delante");
        Debug.Log("esperando click en los espacios del trellis");
        //this.is_o = true;
        //this.is_x = false;
        this.playerTurnTimer();
    }

    public void turnoDelPlayer(){
Debug.Log("turno del jugador");
this.playerTurnTimer();
    }

    private void playerTurnTimer(){
         Debug.Log("starting timer ..");
        //player turn timeOut here ...
    }

    public void resetPlayerTimer(){
         Debug.Log("stoping and reseting timer ..");
        //player turn timeOut here ...
    }

     public void turnoDelDiablo(){
         Debug.Log("turno del diablo ..");
        //player turn timeOut here ...
    }

    void evilsTurn(){}

    // Update is called once per frame
    void Update()
    {
        
    }
}
