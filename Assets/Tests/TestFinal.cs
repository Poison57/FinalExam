using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class TestScript
{
    [UnityTest]
    public IEnumerator _01PlayButtonStartsPlay()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Intro");

        yield return new WaitForSeconds(1f);

        GameObject playBut = GameObject.Find("PlayButton");

        Assert.IsNotNull(playBut, "play button not in Intro scene");

        playBut.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Game", SceneManager.GetActiveScene().name, "Game did not start");

    }


    [UnityTest]
    public IEnumerator _02StopButtonStopsPlay()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Intro");

       yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Game");

        yield return new WaitForSeconds(1f);

        GameObject stopBut = GameObject.Find("StopButton");

        Assert.IsNotNull(stopBut, "Stop button not in game scene");

        stopBut.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Exit", SceneManager.GetActiveScene().name, "Game did not end");
    }


    [UnityTest]
    public IEnumerator _03PlayAgainButtonRestartsGame()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Exit");

        yield return new WaitForSeconds(1f);

        GameObject playAgain = GameObject.Find("PlayAgainButton");

        Assert.IsNotNull(playAgain, "play again button not in Exit scene");

        playAgain.GetComponent<Button>().onClick.Invoke();

        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Intro", SceneManager.GetActiveScene().name, "Game did not start");
    }


    [UnityTest]
    public IEnumerator _04PlayerNameShownInGame()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Intro");
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Game");

        yield return new WaitForSeconds(1f);


        GameObject nameInput = GameObject.Find("NameText");

        Assert.IsNotNull(nameInput, "Name Input field does not exist");



    }


    [UnityTest]
    public IEnumerator _05DestroyingFiveTargetsStopsPlay()
    {
       yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Intro");
        
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Game");

        yield return new WaitForSeconds(1f);

        GameObject target = GameObject.Find("TargetManager");
        GameObject move = GameObject.Find("Player");


         Vector3 position = new Vector3(0, 1, 0);

        for(int i = 0; i < 5; i++){
        Object.Instantiate(target.GetComponent<TargetManager>().target, position, Quaternion.identity);
        }
        move.GetComponent<Movement>().MoveForward();


        yield return new WaitForSeconds(1f);

        Assert.AreEqual("Exit", SceneManager.GetActiveScene().name, "Game did not end");


    }


    [UnityTest]
    public IEnumerator _06NameFromIntroShowsInGameScene()
    {
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Intro");
        
        yield return new WaitForSeconds(1f);

        GameObject nameInput = GameObject.Find("NameInputField");

        string name1 = nameInput.GetComponent<InputField>().text = "Jack";

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("Game");

        yield return new WaitForSeconds(1f);

        GameObject nameInGame = GameObject.Find("NameText");

        string name2 = nameInGame.GetComponent<Text>().text;
        
        Assert.AreEqual(name1, name2, "Text is not equal.");

        



    }



}
