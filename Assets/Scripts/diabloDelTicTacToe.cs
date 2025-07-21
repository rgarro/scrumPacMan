using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *                      _. - ~ ~ ~ - .
 *   ..       __.    .-~               ~-.
 *   ((\     /   `}.~                     `.
 *    \\\   {     }               /     \   \
 *(\   \\~~^      }              |       }   \
 * \`.-~ -@~      }  ,-.         |       )    \
 * (___     ) _}   (    :        |    / /      `.
 *  `----._-~.     _\ \ |_       \   / /- _      `.
 *         ~~----~~  \ \| ~~--~~~(  + /     ~-.     ~- _
 *                   /  /         \  \          ~- . _ _~_-_.
 *                __/  /          _\  )
 *              .<___.'         .<___/
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

    private []string carasDeDiablo = {'A1','A2','A3','B1','B2','B3','C1','C2','C3'};
    private []string sonrisasDelDiablo = {};//bolincha va a jugar este juego dijo el diablo
    private []string elQueYaPaso = {};
    private []string jachasDisponibles = {};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void elDiabloPrimero(){
        Debug.Log("el diablo primero");//ponga a bermudez a ahcer cienciologia para ir a leon 13 a comprar medio kilo de mota
    }

    private void elDiabloJuegaEsquina(){}//soplele la flauta a bolincha hasta que se ponga a pasar a alguien, luego termine el methodo

    private void escogerJachaDisponible(){}

    public void pasePorDelante(){
        Debug.Log("pase por delante");
    }

    void evilsTurn(){}

    // Update is called once per frame
    void Update()
    {
        
    }
}
