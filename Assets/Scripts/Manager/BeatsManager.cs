using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BeatsManager : MonoBehaviour{

    public AudioSource metallicMusic;
    public AudioSource jazzMusic;
    public AudioSource electronicMusic;
    public AudioSource classicMusic;
    public AudioSource healMusic;
    public AudioSource miss;

    public BeatScroller metallicBeatScroller;
    public BeatScroller jazzBeatScroller;
    public BeatScroller electronicBeatScroller;
    public BeatScroller classicBeatScroller;
    public BeatScroller healBeatScroller;

    public GameObject startUI;
    public GameObject rythmeUI;
    public GameObject QTEManager;
    public GameObject beatZoneUp;
    public GameObject beatZoneDown;
    public GameObject beatZoneLeft;
    public GameObject beatZoneRight;

    public static BeatsManager BMInstance;

    public bool isPlaying;
    public bool onceLoop = true;

    public static float metallicCount;
    public static float jazzCount;
    public static float electronicCount;
    public static float classicCount;
    public static float healCount;

    public static int beatHit;
    public static int beatMax;


    void Awake(){

        if(GameManager.fight == 1 || GameManager.fight == 2){

            rythmeUI.SetActive(true);
            QTEManager.SetActive(false);

            metallicCount = 0f;
            jazzCount = 0f;
            electronicCount = 0f;
            classicCount = 0f;
            healCount = 0f;
            beatHit = 0;
            beatMax = 0;
        }
    }

    void Start(){
        
        BMInstance = this;

        isPlaying = false;
    }

    void Update(){
        
        if(!isPlaying){

            if(Input.anyKeyDown){

                startUI.SetActive(false);

                isPlaying = true;

                if(GameManager.whoAttack == 1){

                    metallicCount = 0.15f;

                    metallicMusic.Play();

                    metallicBeatScroller.hasStarted = true;
                }

                if(GameManager.whoAttack == 2){

                    jazzCount = 0.15f;

                    jazzMusic.Play();

                    jazzBeatScroller.hasStarted = true;
                }

                if(GameManager.whoAttack == 3){

                    electronicCount = 0.15f;

                    electronicMusic.Play();

                    electronicBeatScroller.hasStarted = true;
                }

                if(GameManager.whoAttack == 4 && GameManager.fight != 2){

                    classicCount = 0.15f;

                    classicMusic.Play();

                    classicBeatScroller.hasStarted = true;
                }

                if(GameManager.heal && GameManager.fight != 1){

                    healCount = 0.15f;

                    healMusic.Play();

                    healBeatScroller.hasStarted = true;
                }
            }
        }

        if(GameManager.whoAttack == 1){

            if(metallicMusic.time >= metallicCount && metallicCount <= 7){

                MetallicBeats.MBInstance.SpawnMetallicBeats();

                beatMax++;
            }
        }

        if(GameManager.whoAttack == 2){

            if(jazzMusic.time >= jazzCount && jazzCount <= 15){

                JazzBeats.JBInstance.SpawnJazzBeats();

                beatMax++;
            }
        }

        if(GameManager.whoAttack == 3){

            if(electronicMusic.time >= electronicCount && electronicCount <= 6){

                ElectronicBeats.EBInstance.SpawnElectronicBeats();

                beatMax++;
            }
        }

        if(GameManager.whoAttack == 4 && GameManager.fight != 2){

            if(classicMusic.time >= classicCount && classicCount <= 11){

                ClassicBeats.CBInstance.SpawnClassicBeats();

                beatMax++;
            }
        }

        if(GameManager.heal && GameManager.fight != 1){

            if(healMusic.time >= healCount && healCount <= 12){

                HealBeats.HBInstance.SpawnHealBeats();

                beatMax++;
            }
        }

        if((metallicCount >= 7 || jazzCount >= 15 || electronicCount >= 6 || classicCount >= 11 || healCount >= 12) && onceLoop){

            onceLoop = false;

            StopAllCoroutines();
            StartCoroutine(Delay());
        }
    }

    public void BeatMissed(){

        miss.Play();

        int random = Random.Range(0, 4);

        if(random == 0){

            GameObject miss1 = Instantiate(FightManager.FMInstance.VFXMiss1, new Vector3(-6f, -1, 0), Quaternion.identity);

            miss1.transform.Rotate(-90, 0, 0);

            miss1.SetActive(true);

            if(FightManager.FMInstance.missAlly.activeSelf == true){

                GameObject missAlly1 = Instantiate(FightManager.FMInstance.VFXMiss1, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                missAlly1.transform.Rotate(-90, 0, 0);
                
                missAlly1.SetActive(true);
            }
        }

        if(random == 1){

            GameObject miss2 = Instantiate(FightManager.FMInstance.VFXMiss2, new Vector3(-6f, -1, 0), Quaternion.identity);

            miss2.transform.Rotate(-90, 0, 0);

            miss2.SetActive(true);

            if(FightManager.FMInstance.missAlly.activeSelf == true){

                GameObject missAlly2 = Instantiate(FightManager.FMInstance.VFXMiss2, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                missAlly2.transform.Rotate(-90, 0, 0);
                
                missAlly2.SetActive(true);
            }
        }

        if(random == 2){

            GameObject miss3 = Instantiate(FightManager.FMInstance.VFXMiss3, new Vector3(-6f, -1, 0), Quaternion.identity);

            miss3.transform.Rotate(-90, 0, 0);

            miss3.SetActive(true);

            if(FightManager.FMInstance.missAlly.activeSelf == true){

                GameObject missAlly3 = Instantiate(FightManager.FMInstance.VFXMiss3, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                missAlly3.transform.Rotate(-90, 0, 0);
                
                missAlly3.SetActive(true);
            }
        }

        if(random == 3){

            GameObject miss4 = Instantiate(FightManager.FMInstance.VFXMiss4, new Vector3(-6f, -1, 0), Quaternion.identity);

            miss4.transform.Rotate(-90, 0, 0);

            miss4.SetActive(true);

            if(FightManager.FMInstance.missAlly.activeSelf == true){

                GameObject missAlly4 = Instantiate(FightManager.FMInstance.VFXMiss4, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                missAlly4.transform.Rotate(-90, 0, 0);
                
                missAlly4.SetActive(true);
            }
        }
    }

    public void BeatHit(){

        beatHit += 1;

        int random = Random.Range(0, 4);

        if(random == 0){

            GameObject hit1 = Instantiate(FightManager.FMInstance.VFXHit1, new Vector3(-6f, -1, 0), Quaternion.identity);

            hit1.transform.Rotate(-90, 0, 0);

            hit1.SetActive(true);

            if(FightManager.FMInstance.hitAlly.activeSelf == true){

                GameObject hitAlly1 = Instantiate(FightManager.FMInstance.VFXHit1, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                hitAlly1.transform.Rotate(-90, 0, 0);
                
                hitAlly1.SetActive(true);
            }
        }

        if(random == 1){

            GameObject hit2 = Instantiate(FightManager.FMInstance.VFXHit2, new Vector3(-6f, -1, 0), Quaternion.identity);

            hit2.transform.Rotate(-90, 0, 0);

            hit2.SetActive(true);

            if(FightManager.FMInstance.hitAlly.activeSelf == true){

                GameObject hitAlly2 = Instantiate(FightManager.FMInstance.VFXHit2, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                hitAlly2.transform.Rotate(-90, 0, 0);
                
                hitAlly2.SetActive(true);
            }
        }

        if(random == 2){

            GameObject hit3 = Instantiate(FightManager.FMInstance.VFXHit3, new Vector3(-6f, -1, 0), Quaternion.identity);

            hit3.transform.Rotate(-90, 0, 0);

            hit3.SetActive(true);

            if(FightManager.FMInstance.hitAlly.activeSelf == true){

                GameObject hitAlly3 = Instantiate(FightManager.FMInstance.VFXHit3, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                hitAlly3.transform.Rotate(-90, 0, 0);
                
                hitAlly3.SetActive(true);
            }
        }

        if(random == 3){

            GameObject hit4 = Instantiate(FightManager.FMInstance.VFXHit4, new Vector3(-6f, -1, 0), Quaternion.identity);

            hit4.transform.Rotate(-90, 0, 0);

            hit4.SetActive(true);

            if(FightManager.FMInstance.hitAlly.activeSelf == true){

                GameObject hitAlly4 = Instantiate(FightManager.FMInstance.VFXHit4, new Vector3(-3f, -1, 0), Quaternion.identity);
                
                hitAlly4.transform.Rotate(-90, 0, 0);
                
                hitAlly4.SetActive(true);
            }
        }
    }

    IEnumerator Delay(){

        yield return new WaitForSeconds(5f);

        FightManager.fightEnd = true;
    }
}
