using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * ---------------+---------------
 *           ___ /^^[___              _
 *          /|^+----+   |#___________//
 *        ( -+ |____|    ______-----+/
 *         ==_________--'            \
 *           ~_|___|__
 * Yeah-yeah, some folks inherit : star-spangled eyes
 * 0.00f, they send you down to war, Lord()
 * And when you ask em, How much should we give?
 * 0.00f, they only answer, More, more, more, more
 *
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
public class playerTTT : MonoBehaviour
{

    public bool is_x = false;
    public bool is_o = false;
    //private string[] clickedFaces = {};
    private List<string> clickedFaces = {};
    //private string[] clickedXFaces = {};
    private List<string> clickedXFaces = {};
    //private string[] clickedOFaces = {};
    private List<string> clickedOFaces = {};
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void pushFace(string faceTag){
        this.clickedFaces.Push(faceTag);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
