//using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Globalization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
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
 * this.IS the AI of a Tictactoe 2d  Game
 *  Put a Deviled Ham Logo sticker on your Car , put your play after corner turn
 * eat a cracker cookie you had on your ride and eat it with deviled ham at the end
 * is like livin in a relational curve when 4 crackers got a tiny jam can divided on them
 * but what happens with the time you rode them and the circumbalating gases and front car
 * engine radiations transmutating the cookie ...
 * connecting this to a cakePHP REST and upload it from Snowbird might produce the magic cookie
 * since this project had an initial TDD effort
 * BE AWARE : THIS ONLY WORKS FOR THE AUTHOR UNLESS YOU HAVE PAID SOME MONEY TO HIM AND HIM is able to confirm he got the cash 
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
    public List<string> sonrisasDelDiablo = new List<string>(){};//las que el diablo ya jugo
    private List<string> elQueYaPaso = new List<string>(){};
    private List<string> jachasDisponibles = new List<string>(){};
    private List<string> theFourCorners = new List<string>(){"A1","A3","C1","C3"};

    public bool is_x = false;
    public bool is_o = false;

     public float playerMaxTimeToPlay = 60f;
     private flasyText updateText;
     private playerTTT player;
     private restartTimeOut playerTimer;
     private oUjia guija;

    // Start is called before the first frame update
    void Start()
    {
        this.updateText = GameObject.FindWithTag("teletranClone").GetComponent<flasyText>();
        this.player = GameObject.FindWithTag("teletranClone").GetComponent<playerTTT>();
        this.playerTimer = GameObject.FindWithTag("teletranClone").GetComponent<restartTimeOut>();
        this.guija = GameObject.FindWithTag("teletranClone").GetComponent<oUjia>();
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
        //debug clicked faces
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

    private void escogerJachaDisponible(){
        Debug.Log("escogiendo jacha disponibles ..");
        this.setJachasDisponibles(); 
    }

    private void escogerEsquinaDisponible(){
        Debug.Log("escogiendo esquina disponibles ..");
        this.setJachasDisponibles(); 
    }

    private void setJachasDisponibles(){
        Debug.Log("setting jacha disponibles ..");
        Debug.Log("ocupadas del diablo .." +this.sonrisasDelDiablo.ToString());
        //Debug.Log("ocupadas del player .." +this.player.clickedFaces.Join());
        this.elQueYaPaso =this.sonrisasDelDiablo.Concat(this.player.clickedFaces).ToList();
        Debug.Log("elQueYaPaso .." +this.elQueYaPaso.ToString());//verificar x del click
        this.guija.diabloEvalGame();//ojo esta va atras
        //this.jachasDisponibles restar a caras de diablo el que ya paso
    }

    public void pasePorDelante(){
        this.updateText.setFlashMsg("Waiting Player Click on Trellis Space ");
        //this.is_o = true;
        //this.is_x = false;
        this.playerTurnTimer();
    }

    public void turnoDelPlayer(){
        this.updateText.setFlashMsg("Player Turn ");
        this.playerTurnTimer();
    }

    private void playerTurnTimer(){
        this.playerTimer.startTimer();
    }

    public void resetPlayerTimer(){
         Debug.Log("stoping and reseting timer ..");
        //player turn timeOut here ...
    }

     public void turnoDelDiablo(){
         Debug.Log("turno del diablo ..");
        //player turn timeOut here ...
        if(this.escogerEsquinaOCara()){
            //esquina
            this.escogerEsquinaDisponible();
        }else{
            //cara
            this.escogerJachaDisponible();
        }
    }

    //falso esquina true cara
    private bool escogerEsquinaOCara(){
        int randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,50.0f));
        //Beetlejuice ! ..
        randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,50.0f));
        //Beetlejuice ! ..
        randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,50.0f));
        //Beetlejuice ! ..
        randomValue = (int)Mathf.Abs(UnityEngine.Random.Range(1.0f,50.0f));
        if(randomValue < 25){
            return false;
        }else{
            return true;
        }
    }

    void evilsTurn(){}
/* invocar evaluador de gane aki*/

    // Update is called once per frame
    void Update()
    {
       
    }
}
