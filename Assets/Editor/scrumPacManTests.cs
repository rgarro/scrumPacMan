//using System.Reflection.PortableExecutable;
//using System.Reflection.Assembly;
using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Debug = UnityEngine.Debug;
/**
 *================================================.
 *     .-.   .-.     .--.                         |
 *    | OO| | OO|   / _.-' .-.   .-.  .-.   .''.  |
 *    |   | |   |   \  '-. '-'   '-'  '-'   '..'  |
 *    '^^^' '^^^'    '--'                         |
 *===============.  .-.  .================.  .-.  |
 *               | |   | |                |  '-'  |
 *               | |   | |                |       |
 *               | ':-:' |                |  .-.  |
 *l42            |  '-'  |                |  '-'  |
 *==============='       '================'       |
 * El Rey Boruka de los Altos de Blen fuma mota 
 * 
 *
 *@author Rolando <rgarro@gmail.com>
 */
namespace Tests
{
    public class scrumPacManTests
    {
        // A Test behaves as an ordinary method
        [Test]
        public void scrumPacManTestsSimplePasses()
        {
            //GameObject tObj = new GameObject();
            //BatComputer b = tObj.addComponent<BatComputer>();//new BatComputer();
            BatComputer b = new BatComputer();
            //Debug.Log(b.is_testable);
            Assert.That(b.is_testable, Is.EqualTo(true));
        }

        [Test]
        public void assertTrueBatComputerIsBatComputerType()
        {
            BatComputer b = new BatComputer();
            //Type t = typeof(b);
Debug.Log("here we go ...");
//Debug.Log(typeof(b));
//Debug.Log(b.GetObjecType());
            //Assert.That(typeof(b), Is.EqualTo(BatComputer));
            //Assert.IsInstanceOf(BatComputer, b);
        }

        [Test]
        public void assertTrueBatComputerHasRestartButton()
        {
            //restartIconButton rb = new restartIconButton();
            //Assert.IsInstanceOf(restartIconButton, rb);
            //ClassicAssert.IsInstanceOf<restartIconButton>(rb);
        }

        [Test]
        public void assertTrueBatComputerHasShowStartMenuMethod()
        {
            
        }
/*
        [Test]
        public void scrumPacManTestsSoundCloudButton()
        {
            soundCloudLoopButton scBtn = new soundCloudLoopButton();
            //Assert.IsInstanceOf(soundCloudLoopButton, scBtn);
            //ClassicAssert.IsInstanceOf<restartIconButton>(rb);
        }

        [Test]
        public void scrumPacManTestsHasDiabloDelTicTacToeController()
        {
            diabloDelTicTacToe gameContoller = new diabloDelTicTacToe();
            //ClassicAssert.IsInstanceOf(diabloDelTicTacToe , gameContoller);
            //ClassicAssert.IsInstanceOf<restartIconButton>(rb);
        }

        [Test]
        public void diabloDelTicTacToeControllerHasPlayerOneGameObject()
        {
            
        }

        [Test]
        public void diabloDelTicTacToeControllerHasPlayerTwoGameObject()
        {
            
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator scrumPacManTestsWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }*/
    }
}
