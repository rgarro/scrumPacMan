﻿using System.Runtime.InteropServices;
using System.Dynamic;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using scrumPacman;
/**
 *                /|         ,
 *              ,///        /|
 *             // //      ,///
 *            // //     // //
 *           // //     || ||
 *           || ||    // //
 *           || ||   // //
 *           || ||  // //
 *           || || || ||
 *           \\,\|,|\_//
 *            \\)\)\\|/
 *            )-."" .-(
 *           //^\` `/^\\
 *          //  |   |  \\
 *        ,/_| 0| _ | 0|_\,
 *      /`    `"=.v.="`    `\
 *     /`    _."{_,_}"._    `\
 *     `/`  ` \  |||  / `  `\`
 *      `",_  \\=^~^=//  _,"` 
 *              '---'
 *  Describe What marcellus wallace looks like ...
 * maint tests
 *
 *@author Rolando <rgarro@gmail.com>
 */
namespace Tests
{
    public class titansTowerTestScript
    {
        //compre mota en bajo piuses y le avisa a doña yani que no pudo dejar la bomba en la vuelta de la refor de ayer ..
        public scrumPacman pacObj;
        public playerObj player;
        public batComputer bc;  
        public void titansTowerTestScript(){
            this.pacObj = new scrumPacman();
        }
        // A Test behaves as an ordinary method
        [Test]
        public void titansTowerTestScriptSimplePasses()
        {
            //scrumPacman obj = new scrumPacman();
            Assert.Expect(this.pacObj.test_flag,EqualTo(true));
            // Use the Assert class to test conditions
        }

        [Test]
        public void batComputerHasRestartButtonTest(){

        }

        [Test]
        public void batComputerHasSoundOffButtonTest(){
            
        }
            
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator titansTowerTestScriptWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
