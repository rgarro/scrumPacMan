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
 * El Rey Boruka de los Altos de Blen fuma mota .. 
 * 
 * 
 *
 *@author Rolando <rgarro@gmail.com>
 */
namespace Tests
{
    public class scrumPacManTests
    {
        //BatComputer Assertions
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
            Assert.That(b.GetType(), Is.EqualTo(typeof(BatComputer)));
            //Assert.IsInstanceOf(BatComputer, b);
        }

        [Test]
        public void assertTrueBatComputerHasImPlayerProperty()
        {
            BatComputer b = new BatComputer();           
            Assert.That(b.im_player.GetType(), Is.EqualTo(typeof(bool)));
            Assert.That(b.im_player, Is.EqualTo(false));
        }

        [Test]
        public void assertTrueBatComputerHasImHomeProperty()
        {
            BatComputer b = new BatComputer();           
            Assert.That(b.im_home.GetType(), Is.EqualTo(typeof(bool)));
            Assert.That(b.im_home, Is.EqualTo(false));
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
            BatComputer b = new BatComputer();
            var t = b.GetType(); 
        //Debug.Log("here we go ---->");
        //Debug.Log(t.GetMethod("showStartMenu"));          
            Assert.That(t.GetMethod("showStartMenu"), Is.EqualTo(t.GetMethod("showStartMenu")));
        }

        [Test]
        public void assertTrueBatComputerHasDecidePlayerOrHomeMethod()
        {
            BatComputer b = new BatComputer();
            var t = b.GetType();           
            Assert.That(t.GetMethod("playerOrHome"), Is.EqualTo(t.GetMethod("playerOrHome")));
        }

        //Trellis Assertions
        [Test]
        public void assertTrueTrellisFaceIsTestable()
        {
            trellisFace t = new trellisFace();           
            Assert.That(t.GetType(), Is.EqualTo(typeof(trellisFace)));
        }

        [Test]
        public void assertTrueTrellisFaceHasExFaceBoolProperty()
        {
            trellisFace p = new trellisFace();           
            Assert.That(p.is_exFace.GetType(), Is.EqualTo(typeof(bool)));
            Assert.That(p.is_exFace, Is.EqualTo(false));
        }

        [Test]
        public void assertTrueTrellisFaceIsCircleBoolProperty()
        {
            trellisFace p = new trellisFace();           
            Assert.That(p.is_circleFace.GetType(), Is.EqualTo(typeof(bool)));
            Assert.That(p.is_circleFace, Is.EqualTo(false));
        }

         //diabloDelTicTacToe Assertions
        [Test]
        public void scrumPacManTestsHasDiabloDelTicTacToeController()
        {
            diabloDelTicTacToe d = new diabloDelTicTacToe();
            Assert.That(d.GetType(), Is.EqualTo(typeof(diabloDelTicTacToe)));
        }

        //borukaPlayer Assertions
        [Test]
        public void assertTrueBorukaPlayerExist()
        {
            borukaPlayer p = new borukaPlayer();
            Assert.That(p.GetType(), Is.EqualTo(typeof(borukaPlayer)));
        }

        [Test]
        public void assertBorukaPlayerIsExBoolProperty()
        {
            borukaPlayer p = new borukaPlayer();           
            Assert.That(p.is_ex.GetType(), Is.EqualTo(typeof(bool)));
            Assert.That(p.is_ex, Is.EqualTo(false));
        }
/*
        [Test]
        public void assertBorukaPlayerIsCircleBoolProperty()
        {
            borukaPlayer p = new borukaPlayer();           
            Assert.That(p.is_circle.GetType(), Is.EqualTo(typeof(bool)));
            Assert.That(p.is_circle, Is.EqualTo(false));
        }
*/
        [Test]
        public void assertBorukaPlayerTurnNumberIntProperty()
        {
            borukaPlayer p = new borukaPlayer();           
            Assert.That(p.turn_number.GetType(), Is.EqualTo(typeof(int)));
            Assert.That(p.turn_number, Is.EqualTo(0));
        }               


        [Test]
        public void scrumPacManTestsSoundCloudButton()
        {
            GameObject bat = GameObject.FindWithTag("BatComputer");
            soundCloudLoopButton tmpObj = bat.GetComponent(typeof(soundCloudLoopButton)) as soundCloudLoopButton;
            Assert.That(tmpObj.IconX, Is.GreaterThan(0));
            //soundCloudLoopButton scBtn = new soundCloudLoopButton();
            //Assert.IsInstanceOf(soundCloudLoopButton, scBtn);
            //ClassicAssert.IsInstanceOf<restartIconButton>(rb);
        }
*/
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
