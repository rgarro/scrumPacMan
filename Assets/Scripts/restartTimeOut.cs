using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *            _________________________
 *          ,'        _____            `.
 *        ,'       _.'_____`._           `.
 *       :       .'.-'  12 `-.`.           \
 *       |      /,' 11  .   1 `.\           :
 *       ;     // 10    |     2 \\          |
 *     ,'     ::        |        ::         |
 *   , '       || 9   ---O      3 ||         |
 *  /         ::                 ;;         |
 * :           \\ 8           4 //          |
 * |            \`. 7       5 ,'/           |
 * |             '.`-.__6__.-'.'            |
 * :              ((-._____.-))             ;
 *  \             _))       ((_            /
 *   `.          '--'       '--'         ,'
 *     `.______________________________,'
 *         ,-.
 *         `-'
 *            O
 *             o
 *              .     ____________
 *             ,('`)./____________`-.-,|
 *            |'-----\\--------------| |
 *            |_______^______________|,|
 *            |                      |   SSt
 * Displays cancellable TimeOut until restarts the entire game
 * supposed to be Relayed remotely by player action
 *
 * Un Delegado es un Relay Remoto, decia un perverso que compro un titulo en la U latina y se posaba de dueno ...
 *
 *
 *
 *@author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class restartTimeOut : MonoBehaviour
{

    public float windowX = 10;
    public float windowY = 65;
    public float windowHeight = 170;
    public float windowWidth = 150;
	private Rect windowRect;
    
    public GUIStyle style;
    
    private string timeOutStr;
    private AudioSource soundPlayer;
    public AudioClip timerSoundClip;

    public bool playSoundOnTimerOn = true;
    public float soundVolume = 0.7F;
    public float timeOutFrom = 2.2F;//small time shot away ...

    // Start is called before the first frame update
    void Start()
    {
        this.servoSoundPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
