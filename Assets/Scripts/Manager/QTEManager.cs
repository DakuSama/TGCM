using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QTEManager : MonoBehaviour{
    
    public GameObject displayBox;
    public GameObject passBox;
    public GameObject startUI;
    public GameObject QTEUI;
    public GameObject BeatsManager;
    public GameObject VFXPass;
    public GameObject countText;

    public AudioSource QTE;
    public AudioSource QTEHit;
    public AudioSource QTEFail;

    public int QTEGen;
    public int waitingForInput;
    public int correctInput;
    public int countingDown;
    public int QTERestart;

    public static QTEManager QMInstance;

    public static int QTECounter;
    public static int QTEValide;

    public bool QTEEnd = true;
    public bool QTEStart = false;

    void Awake(){

        if(GameManager.fight == 0){

            QTEUI.SetActive(true);
            BeatsManager.SetActive(false);

            QTECounter = 0;
            QTEValide = 0;
        }
    }

    void Start(){

        QMInstance = this;

        QTE.Play();
    }

    void Update(){

        if(Input.anyKeyDown){

            startUI.SetActive(false);

            QTEStart = true;
        }

        if((QTEStart || QTERestart == 1) && QTECounter < 5){

            Debug.Log("QTE Restart");

            QTERestart = 0;

            if(waitingForInput == 0){

                QTEGen = Random.Range(1, 4);
                countingDown = 1;
                QTECounter += 1;

                countText.GetComponent<TextMeshProUGUI>().text = "QTE: " + QTECounter + "/5";

                StopAllCoroutines();
                StartCoroutine(CountDown());

                if(QTEGen == 1){

                    waitingForInput = 1;

                    displayBox.GetComponent<TextMeshProUGUI>().text = "[Q]";
                }

                if(QTEGen == 2){

                    waitingForInput = 1;

                    displayBox.GetComponent<TextMeshProUGUI>().text = "[S]";
                }
                
                if(QTEGen == 3){

                    waitingForInput = 1;

                    displayBox.GetComponent<TextMeshProUGUI>().text = "[D]";
                }
            }
        }

        if(QTEGen == 1){

            if(Input.anyKeyDown){

                if(Input.GetButtonDown("QKey")){

                    correctInput = 1;
                    
                    StartCoroutine(InputPressing());
                }
                else{

                    correctInput = 2;
                    
                    StartCoroutine(InputPressing());
                }
            }
        }

        if(QTEGen == 2){

            if(Input.anyKeyDown){

                if(Input.GetButtonDown("SKey")){

                    correctInput = 1;
                    
                    StartCoroutine(InputPressing());
                }
                else{

                    correctInput = 2;
                    
                    StartCoroutine(InputPressing());
                }
            }
        }

        if(QTEGen == 3){

            if(Input.anyKeyDown){

                if(Input.GetButtonDown("DKey")){

                    correctInput = 1;
                    
                    StartCoroutine(InputPressing());
                }
                else{

                    correctInput = 2;
                    
                    StartCoroutine(InputPressing());
                }
            }
        }

        if(QTECounter == 5 && QTEEnd == true){

            QTEEnd = false;

            StartCoroutine(EndQTE());
        }
    }

    IEnumerator EndQTE(){

        yield return new WaitForSeconds(7f);

        FightManager.fightEnd = true;
    }

    IEnumerator InputPressing(){

        QTEGen = 4;

        if(correctInput == 1){

            VFXPass.SetActive(true);

            QTEHit.Play();

            countingDown = 2;

            passBox.GetComponent<TextMeshProUGUI>().text = "Pass";
            passBox.GetComponent<TextMeshProUGUI>().color = new Color(0, 1, 0, 1);

            yield return new WaitForSeconds(1f);

            correctInput = 0;

            passBox.GetComponent<TextMeshProUGUI>().text = "";
            displayBox.GetComponent<TextMeshProUGUI>().text = "";

            yield return new WaitForSeconds(1f);

            waitingForInput = 0;
            countingDown = 1;
            QTERestart = 1;

            QTEValide += 1;
        }

        if(correctInput == 2){

            QTEFail.Play();

            countingDown = 2;

            passBox.GetComponent<TextMeshProUGUI>().text = "Fail";
            passBox.GetComponent <TextMeshProUGUI>().color = new Color(1, 0, 0, 1);

            yield return new WaitForSeconds(1f);

            correctInput = 0;

            passBox.GetComponent<TextMeshProUGUI>().text = "";
            displayBox.GetComponent<TextMeshProUGUI>().text = "";

            yield return new WaitForSeconds(1f);

            waitingForInput = 0;
            countingDown = 1;
            QTERestart = 1;
        }
    }

    IEnumerator CountDown(){

        yield return new WaitForSeconds(3f);

        if(countingDown == 1){

            QTEFail.Play();

            QTEGen = 4;
            countingDown = 2;

            passBox.GetComponent<TextMeshProUGUI>().text = "Fail";
            passBox.GetComponent<TextMeshProUGUI>().color = new Color(1, 0, 0, 1);

            yield return new WaitForSeconds(1f);

            correctInput = 0;

            passBox.GetComponent<TextMeshProUGUI>().text = "";
            displayBox.GetComponent<TextMeshProUGUI>().text = "";

            yield return new WaitForSeconds(1f);

            waitingForInput = 0;
            countingDown = 1;
            QTERestart = 1;
        }
    }
}
