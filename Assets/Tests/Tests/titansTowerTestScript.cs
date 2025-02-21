using System.Runtime.InteropServices;
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
 *jgs  `/`  ` \  |||  / `  `\`
 *      `",_  \\=^~^=//  _,"`
 *          "=,\'-=-'/,="
 *              '---'
 *
 *
 *@author Rolando <rgarro@gmail.com>
 */
namespace Tests
{
    public class titansTowerTestScript
    {
        // A Test behaves as an ordinary method
        [Test]
        public void titansTowerTestScriptSimplePasses()
        {
            scrumPacman obj = new scrumPacman();
            Assert.Expect(obj.test_flag,EqualTo(true));
            // Use the Assert class to test conditions
        }

        /*[Test]
        public void batComputerHasRestartButtonTest(){

        }

        [Test]
        public void batComputerHasSoundOffButtonTest(){
            
        }*/
            
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
