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
 * this.IS the AI of a tictactoe 2d  Game
 * call the F-ONE Diablo snow kitting the plains of Jericho
 * UNCLE Sam , please approve my EB-1
 * Roger, Alpha , Delta airlines
 *  SJO -> Dallas -> here = new Mexico(Caballo Lake)
 * 
 *
 *
 *@author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class diabloDelTicTacToe : MonoBehaviour
{
    public int turn_number = 0;

    private trellisFace trFace;

    private List<string> carasDeDiablo = new List<string>(){"A1","A2","A3","B1","B2","B3","C1","C2","C3"};
    private List<string> sonrisasDelDiablo = new List<string>(){};
    private List<string> elQueYaPaso = new List<string>(){};
    private List<string> jachasDisponibles = new List<string>(){};
    private List<string> theFourCorners = new List<string>(){"A1","A3","C1","C3"};

    public bool is_x = false;
    public bool is_o = false;

     public float playerMaxTimeToPlay = 60f;//El dia de la muerte de ozzy...
     private flasyText updateText;
    
    // Start is called before the first frame update
    void Start()
    {
        this.updateText = GameObject.FindWithTag("teletranClone").GetComponent<flasyText>();
    }

    public void diabloRie(string faceTag){
        //this.sonrisasDelDiablo.Push(faceTag);
        this.sonrisasDelDiablo.Add(faceTag);
    }

    public void elDiabloPrimero(){
        //Debug.Log("el diablo primero");
        string corner_label = this.elDiabloJuegaPrimeraEsquina();
        //Debug.Log("evil corner: "+corner_label);
        this.updateText.setFlashMsg("Computer Plays Corner "+corner_label);
        //this.is_x = true;
        //this.is_o = false;
        this.trFace = GameObject.FindWithTag(corner_label).GetComponent<trellisFace>();
        this.trFace.setDiablo();
        this.diabloRie(corner_label);
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
        //Debug.Log("pase por delante");
        //Debug.Log("esperando click en los espacios del trellis");
        this.updateText.setFlashMsg("Waiting Player Click on Trellis Space ");
        //this.is_o = true;
        //this.is_x = false;
        this.playerTurnTimer();
    }

    public void turnoDelPlayer(){
Debug.Log("turno del jugador");
this.updateText.setFlashMsg("Player Turn ");
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
        /*
        if (countdownTime > 0)
        {
            countdownTime -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(countdownTime / 60);
            int seconds = Mathf.FloorToInt(countdownTime % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            countdownTime = 0;
            timerText.text = "00:00";
            // Trigger an action when time is up (e.g., game over)
        }*/
    }
}
