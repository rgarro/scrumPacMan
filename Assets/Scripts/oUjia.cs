using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
/**
 * ---------------------------
 * |       YES      NO       |
 * |                         |
 * |      ABCDEFGHIJKLM      |
 * |      NOPQRSTUVWXYZ      |
 * |                         |
 * |       1234567890        |
 * |                         |
 * |      x I LOVE YOU x     |
 * ---------------------------
 *  The dragon stood on the shore of the sea. 
 * And I saw a beast coming out of the sea. 
 * It had ten horns and seven heads, 
 * with ten crowns on its horns, 
 * and on each head a blasphemous name. 
 *      DOUTONE REBEL 13 , Playa Azul 14 knots North ....
 * 
 *
 *
 *
 *@author Rolando <rgarro@gmail.com> <https://emptyart.github.io>
 */
public class oUjia : MonoBehaviour
{
    
    private List<string> LineA1 = new List<string>(){"A1","B2","C3"};//C# type
    private List<string> LineA2 = new List<string>(){"A3","B2","C1"};
    private List<string> LineA3 = new List<string>(){"A2","B2","C2"};
    private List<string> LineA4 = new List<string>(){"A1","B1","C1"};
    private List<string> LineA5 = new List<string>(){"A3","B3","C3"};
    private List<string> LineA6 = new List<string>(){"A1","A2","A3"};
    private List<string> LineB1 = new List<string>(){"B1","B2","B3"};
    private List<string> LineC1 = new List<string>(){"C1","C2","C3"};

    private playerTTT player;
    private diabloDelTicTacToe diablo;

    public string diabloGano = "gol del Municipal de Santana";
    public string playerGano = "Gol del Player";
    private flasyText updateText;

    public GameObject TallyA1;
    public GameObject TallyA2;
    public GameObject TallyA3;
    public GameObject TallyA4;
    public GameObject TallyA5;
    public GameObject TallyA6;
    public GameObject TallyB1;
    public GameObject TallyC1;        

    // Start is called before the first frame update
    void Start()
    {
        this.diablo = GameObject.FindWithTag("teletranClone").GetComponent<diabloDelTicTacToe>();
        this.player = GameObject.FindWithTag("teletranClone").GetComponent<playerTTT>();
        this.updateText = GameObject.FindWithTag("teletranClone").GetComponent<flasyText>();
    }

    public bool playerEvalGame(){
        bool evalLed = false;
Debug.Log("playerEvalGame..");
Debug.Log("clicked faces" + this.player.clickedFaces.Count);
        if(this.player.clickedFaces.Count >= 3){
         Debug.Log("grater Count");   
            if(this.findTallyInFaces(this.player.clickedFaces)){

               return true; 
            }
        }else{
            Debug.Log("lower Count");   
        }
        return evalLed;
    }

       public bool diabloEvalGame(){
        bool evalLed = false;
Debug.Log("oujia evaluando el gane diablo..");
        if(this.diablo.sonrisasDelDiablo.Count >= 3){
            if(this.findTallyInFaces(this.diablo.sonrisasDelDiablo)){
                
                return true;
            }
        }else{
            Debug.Log("lower Count");   
        }
        return evalLed;
    }

    bool findTallyInFaces(List<string> clickedFaces){
        bool existsContains = false;//bowling tenacios D
Debug.Log("hay tally o no?..");  
Debug.Log("clickedfaces:"+clickedFaces);//busque la standar de c#      
        //bool existsContains = clickedFaces.Contains(this.LineA1);// first check if entire lis might be found or need an extra iteration
        return existsContains;
    }

    void playerWins(){
        this.updateText.setFlashMsg("Player Won !!");
    }

    void ganaElDiablo(){

    }

    private void tallyTHeWin(){}

    // Update is called once per frame
    void Update()
    {
        
    }
}
