//using System.Diagnostics;
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
 * this.IS the AI of a Tictactoe 2d  Game
 *  El diablo era un pescador de Fray Casiano , que volaba un F-ONE Diablo 
 *  a 25 millas nauticas de cabo blanco , y pescaba peces que sanaban a pacientes
 * del Monsenor Sanabria cuando les comian.
 * 
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
    private List<string> sonrisasDelDiablo = new List<string>(){};//las que el diablo ya jugo
    private List<string> elQueYaPaso = new List<string>(){};
    private List<string> jachasDisponibles = new List<string>(){};
    private List<string> theFourCorners = new List<string>(){"A1","A3","C1","C3"};

    public bool is_x = false;
    public bool is_o = false;

     public float playerMaxTimeToPlay = 60f;
     private flasyText updateText;
     private playerTTT player;
     private restartTimeOut playerTimer;

    // Start is called before the first frame update
    void Start()
    {
        this.updateText = GameObject.FindWithTag("teletranClone").GetComponent<flasyText>();
        this.player = GameObject.FindWithTag("teletranClone").GetComponent<playerTTT>();
        this.playerTimer = GameObject.FindWithTag("teletranClone").GetComponent<restartTimeOut>();
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
        //Debug.Log("ocupadas del diablo .." +this.sonrisasDelDiablo.Join());
        //Debug.Log("ocupadas del player .." +this.player.clickedFaces.Join());
        this.elQueYaPaso =this.sonrisasDelDiablo.Concat(this.player.clickedFaces);
        //Debug.Log("elQueYaPaso .." +this.elQueYaPaso.Join());
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
