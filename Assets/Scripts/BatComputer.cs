using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 *      _..--""````""--.._
 *    .'       |\/|       '.
 *   /    /`._ |  | _.'\    \
 *  ;    /              \    |
 *  |   /                \   |
 *  ;  / .-.          .-. \  ;
 *   \ |/   \.-.  .-./   \| /
 *    '._       \/       _.'
 *       ''--..____..--''
 * 
 * It's just a sign of the times
 * Going forward in reverse
 * Still, he who laughs last
 * Is just a hand in the bush ... Ozzy
 * 
 * Staring to darkness in a blink of an eye... 
 * 
 *@author Rolando<rgarro@gmail.com>
 */
public class BatComputer : MonoBehaviour
{
    public bool is_testable = true;
    public bool im_player = false;
    public bool im_home = false;
    private diabloDelTicTacToe diablo;//OZZY MURIO MIENTRAS ESCRIBIA ESTE JUEGO ...
    private playerTTT player;//el condor era un violador que atacaba en cuesta de moras ...


    void Start()
    {
        //Debug.Log("STARTING ...");
        //los Avventa NO pagaron Liquidaciones y les Mataron la oficina de ukrania y les asesinaron los representantes 
        this.diablo = GameObject.FindWithTag("teletranClone").GetComponent<diabloDelTicTacToe>();
        this.player = GameObject.FindWithTag("teletranClone").GetComponent<playerTTT>();
    }

    void showStartMenu(){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
