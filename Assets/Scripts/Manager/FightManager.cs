using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class FightManager : MonoBehaviour{

    public GameObject lifeEnemyText;
    public GameObject lifeMetallicText;
    public GameObject lifeJazzText;
    public GameObject lifeElectronicText;
    public GameObject lifeClassicText;
    public GameObject lifeEnemyBar;
    public GameObject lifeMetallicBar;
    public GameObject lifeJazzBar;
    public GameObject lifeElectronicBar;
    public GameObject lifeClassicBar;
    public GameObject goblin;
    public GameObject damageGoblin;
    public GameObject bat;
    public GameObject damageBat;
    public GameObject metallic;
    public GameObject damagedMetallic;
    public GameObject healMetallic;
    public GameObject jazz;
    public GameObject damagedJazz;
    public GameObject healJazz;
    public GameObject electronic;
    public GameObject damagedElectronic;
    public GameObject healElectronic;
    public GameObject classic;
    public GameObject damagedClassic;
    public GameObject UIEnemy;
    public GameObject UIMetallic;
    public GameObject UIJazz;
    public GameObject UIElectronic;
    public GameObject UIClassic;
    public GameObject UIHeal;
    public GameObject VFXMiss1;
    public GameObject VFXMissAlly1;
    public GameObject VFXMiss2;
    public GameObject VFXMissAlly2;
    public GameObject VFXMiss3;
    public GameObject VFXMissAlly3;
    public GameObject VFXMiss4;
    public GameObject VFXMissAlly4;
    public GameObject VFXHit1;
    public GameObject VFXHitAlly1;
    public GameObject VFXHit2;
    public GameObject VFXHitAlly2;
    public GameObject VFXHit3;
    public GameObject VFXHitAlly3;
    public GameObject VFXHit4;
    public GameObject VFXHitAlly4;
    public GameObject VFXFireBall;
    public GameObject fireBall;
    public GameObject hitAlly;
    public GameObject missAlly;
    public GameObject hit;
    public GameObject perfect;
    public GameObject miss;

    public AudioSource heal;

    public int metallicHealth;
    public int jazzHealth;
    public int electronicHealth;
    public int classicHealth;
    public int goblinHealth;
    public int goblin1Health;
    public int goblin2Health;
    public int goblin3Health;
    public int goblin4Health;
    public int goblin5Health;
    public int batHealth;
    public int bat1Health;
    public int bat2Health;
    public int bat3Health;
    public int bat4Health;
    public int metallicDamage;
    public int jazzDamage;
    public int electronicDamage;
    public int classicDamage;
    public int goblinDamage;
    public int batDamage;
    public int ally;
    public int whoHeal;

    public static FightManager FMInstance;

    public static bool fightEnd = false;

    public Vector3 positionWithAllyText = new Vector3(-430, -400, 0);
    public Vector3 positionWithAllyBar = new Vector3(-505, -450, 0);
    public Vector3 positionWithAllySprite = new Vector3(-4.5f, -5, 0);
    public Vector3 positionWithAllyUI = new Vector3(-400, -420, 0);
    public Vector3 positionStartUI = new Vector3(-4.5f, -4, 0);
    public Vector3 positionStoptUI = new Vector3(5, -4, 0);

    void Awake(){

        metallicHealth = GameManager.unitDictionaryHealth["Metalleux"];
        jazzHealth = GameManager.unitDictionaryHealth["Jazz"];
        electronicHealth = GameManager.unitDictionaryHealth["Electro"];
        classicHealth = GameManager.unitDictionaryHealth["Classic"];
        goblinHealth = GameManager.unitDictionaryHealth["Goblin"];
        goblin1Health = GameManager.unitDictionaryHealth["Goblin1"];
        goblin2Health = GameManager.unitDictionaryHealth["Goblin2"];
        goblin3Health = GameManager.unitDictionaryHealth["Goblin3"];
        goblin4Health = GameManager.unitDictionaryHealth["Goblin4"];
        goblin5Health = GameManager.unitDictionaryHealth["Goblin5"];
        batHealth = GameManager.unitDictionaryHealth["Chauve-Souris"];
        bat1Health = GameManager.unitDictionaryHealth["Chauve-Souris1"];
        bat2Health = GameManager.unitDictionaryHealth["Chauve-Souris2"];
        bat3Health = GameManager.unitDictionaryHealth["Chauve-Souris3"];
        bat4Health = GameManager.unitDictionaryHealth["Chauve-Souris4"];
        metallicDamage = GameManager.unitDictionaryDamage["Metalleux"];
        jazzDamage = GameManager.unitDictionaryDamage["Jazz"];
        electronicDamage = GameManager.unitDictionaryDamage["Electro"];
        classicDamage = GameManager.unitDictionaryDamage["Classic"];
        goblinDamage = GameManager.unitDictionaryDamage["Goblin"];
        batDamage = GameManager.unitDictionaryDamage["Chauve-Souris"];

        if(GameManager.neighbourList.Contains("Metalleux") && (GameManager.unitWhoHeal != 1 || GameManager.unitWhoHeal != 2 || GameManager.unitWhoHeal != 3)){

            metallicDamage += 2;
            ally = 1;

            hitAlly.SetActive(true);
            missAlly.SetActive(true);
        }

        if(GameManager.neighbourList.Contains("Jazz") && (GameManager.unitWhoHeal != 1 || GameManager.unitWhoHeal != 2 || GameManager.unitWhoHeal != 3)){

            jazzDamage += 2;
            ally = 2;

            hitAlly.SetActive(true);
            missAlly.SetActive(true);
        }

        if(GameManager.neighbourList.Contains("Electro") && (GameManager.unitWhoHeal != 1 || GameManager.unitWhoHeal != 2 || GameManager.unitWhoHeal != 3)){

            electronicDamage += 2;
            ally = 3;

            hitAlly.SetActive(true);
            missAlly.SetActive(true);
        }

        if(GameManager.neighbourList.Contains("Classic") && (GameManager.unitWhoHeal != 1 || GameManager.unitWhoHeal != 2 || GameManager.unitWhoHeal != 3)){

            classicDamage += 2;
            ally = 4;

            hitAlly.SetActive(true);
            missAlly.SetActive(true);
        }

        if(GameManager.unitWhoHeal == 1 && GameManager.fight == 2){

            whoHeal = 1;

            UIHeal.SetActive(true);
            hitAlly.SetActive(false);
            missAlly.SetActive(false);
        }

        if(GameManager.unitWhoHeal == 2 && GameManager.fight == 2){

            whoHeal = 2;

            UIHeal.SetActive(true);
            hitAlly.SetActive(false);
            missAlly.SetActive(false);
        }

        if(GameManager.unitWhoHeal == 3 && GameManager.fight == 2){

            whoHeal = 3;

            UIHeal.SetActive(true);
            hitAlly.SetActive(false);
            missAlly.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start(){
        
        FMInstance = this;
    }

    // Update is called once per frame
    void Update(){

        if((GameManager.whoEnemy == 1 || GameManager.whoEnemy == 2 || GameManager.whoEnemy == 3 || GameManager.whoEnemy == 4 || GameManager.whoEnemy == 5 || GameManager.whoEnemy == 6 || GameManager.whoFight == "Goblin" || GameManager.whoFight == "Goblin1" || GameManager.whoFight == "Goblin2" || GameManager.whoFight == "Goblin3" || GameManager.whoFight == "Goblin4" || GameManager.whoFight == "Goblin5") && GameManager.fight != 2){

            if(goblinHealth == 8 || goblin1Health == 8 || goblin2Health == 8 || goblin3Health == 8 || goblin4Health == 8 || goblin5Health == 8){

                lifeEnemyBar.transform.localScale = new Vector3(1, 1, 1);
            }

            if(goblinHealth == 7 || goblin1Health == 7 || goblin2Health == 7 || goblin3Health == 7 || goblin4Health == 7 || goblin5Health == 7){

                lifeEnemyBar.transform.localScale = new Vector3(0.875f, 1, 1);
            }

            if(goblinHealth == 6 || goblin1Health == 6 || goblin2Health == 6 || goblin3Health == 6 || goblin4Health == 6 || goblin5Health == 6){

                lifeEnemyBar.transform.localScale = new Vector3(0.75f, 1, 1);
            }

            if(goblinHealth == 5 || goblin1Health == 5 || goblin2Health == 5 || goblin3Health == 5 || goblin4Health == 5 || goblin5Health == 5){

                lifeEnemyBar.transform.localScale = new Vector3(0.625f, 1, 1);
            }

            if(goblinHealth == 4 || goblin1Health == 4 || goblin2Health == 4 || goblin3Health == 4 || goblin4Health == 4 || goblin5Health == 4){

                lifeEnemyBar.transform.localScale = new Vector3(0.5f, 1, 1);
            }

            if(goblinHealth == 3 || goblin1Health == 3 || goblin2Health == 3 || goblin3Health == 3 || goblin4Health == 3 || goblin5Health == 3){

                lifeEnemyBar.transform.localScale = new Vector3(0.375f, 1, 1);
            }

            if(goblinHealth == 2 || goblin1Health == 2 || goblin2Health == 2 || goblin3Health == 2 || goblin4Health == 2 || goblin5Health == 2){

                lifeEnemyBar.transform.localScale = new Vector3(0.25f, 1, 1);
            }

            if(goblinHealth == 1 || goblin1Health == 1 || goblin2Health == 1 || goblin3Health == 1 || goblin4Health == 1 || goblin5Health == 1){

                lifeEnemyBar.transform.localScale = new Vector3(0.125f, 1, 1);
            }

            if(goblinHealth <= 0 || goblin1Health <= 0 || goblin2Health <= 0 || goblin3Health <= 0 || goblin4Health <= 0 || goblin5Health <= 0){

                lifeEnemyBar.transform.localScale = new Vector3(0, 1, 1);
            }

            lifeEnemyText.SetActive(true);
            lifeEnemyBar.SetActive(true);
            goblin.SetActive(true);
            UIEnemy.SetActive(true);

            if(GameManager.whoFight == "Goblin" || GameManager.whoEnemy == 1){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + goblinHealth;
            }

            if(GameManager.whoFight == "Goblin1" || GameManager.whoEnemy == 2){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + goblin1Health;
            }

            if(GameManager.whoFight == "Goblin2" || GameManager.whoEnemy == 3){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + goblin2Health;
            }

            if(GameManager.whoFight == "Goblin3" || GameManager.whoEnemy == 4){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + goblin3Health;
            }

            if(GameManager.whoFight == "Goblin4" || GameManager.whoEnemy == 5){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + goblin4Health;
            }

            if(GameManager.whoFight == "Goblin5" || GameManager.whoEnemy == 6){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + goblin5Health;
            }
        }

        if((GameManager.whoEnemy == 7 || GameManager.whoEnemy == 8 || GameManager.whoEnemy == 9 || GameManager.whoEnemy == 10 || GameManager.whoEnemy == 11 || GameManager.whoFight == "Chauve-Souris" || GameManager.whoFight == "Chauve-souris1" || GameManager.whoFight == "Chauve-souris2" || GameManager.whoFight == "Chauve-souris3" || GameManager.whoFight == "Chauve-souris4") && GameManager.fight != 2){

            if(batHealth == 5 || bat1Health == 5 || bat2Health == 5 || bat3Health == 5 || bat4Health == 5){

                lifeEnemyBar.transform.localScale = new Vector3(1, 1, 1);
            }

            if(batHealth == 4 || bat1Health == 4 || bat2Health == 4 || bat3Health == 4 || bat4Health == 4){

                lifeEnemyBar.transform.localScale = new Vector3(0.8f, 1, 1);
            }

            if(batHealth == 3 || bat1Health == 3 || bat2Health == 3 || bat3Health == 3 || bat4Health == 3){

                lifeEnemyBar.transform.localScale = new Vector3(0.6f, 1, 1);
            }

            if(batHealth == 2 || bat1Health == 2 || bat2Health == 2 || bat3Health == 2 || bat4Health == 2){

                lifeEnemyBar.transform.localScale = new Vector3(0.4f, 1, 1);
            }

            if(batHealth == 1 || bat1Health == 1 || bat2Health == 1 || bat3Health == 1 || bat4Health == 1){

                lifeEnemyBar.transform.localScale = new Vector3(0.2f, 1, 1);
            }

            if(batHealth <= 0 || bat1Health <= 0 || bat2Health <= 0 || bat3Health <= 0 || bat4Health <= 0){

                lifeEnemyBar.transform.localScale = new Vector3(0, 1, 1);
            }

            lifeEnemyText.SetActive(true);
            lifeEnemyBar.SetActive(true);
            bat.SetActive(true);
            UIEnemy.SetActive(true);

            if(GameManager.whoFight == "Chauve-Souris" || GameManager.whoEnemy == 7){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + batHealth;
            }

            if(GameManager.whoFight == "Chauve-Souris1" || GameManager.whoEnemy == 8){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + bat1Health;
            }

            if(GameManager.whoFight == "Chauve-Souris2" || GameManager.whoEnemy == 9){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + bat2Health;
            }

            if(GameManager.whoFight == "Chauve-Souris3" || GameManager.whoEnemy == 10){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + bat3Health;
            }

            if(GameManager.whoFight == "Chauve-Souris4" || GameManager.whoEnemy == 11){

                lifeEnemyText.GetComponent<TextMeshProUGUI>().text = "HP: " + bat4Health;
            }
        }

        if(GameManager.unitWhoTarget == 1 || ally == 1 || GameManager.whoAttack == 1 || whoHeal == 1){

            if(metallicHealth == 11){

                lifeMetallicBar.transform.localScale = new Vector3(1, 1, 1);
            }

            if(metallicHealth == 10){

                lifeMetallicBar.transform.localScale = new Vector3(0.909f, 1, 1);
            }

            if(metallicHealth == 9){

                lifeMetallicBar.transform.localScale = new Vector3(0.818f, 1, 1);
            }

            if(metallicHealth == 8){

                lifeMetallicBar.transform.localScale = new Vector3(0.727f, 1, 1);
            }

            if(metallicHealth == 7){

                lifeMetallicBar.transform.localScale = new Vector3(0.636f, 1, 1);
            }

            if(metallicHealth == 6){

                lifeMetallicBar.transform.localScale = new Vector3(0.545f, 1, 1);
            }

            if(metallicHealth == 5){

                lifeMetallicBar.transform.localScale = new Vector3(0.454f, 1, 1);
            }

            if(metallicHealth == 4){

                lifeMetallicBar.transform.localScale = new Vector3(0.363f, 1, 1);
            }

            if(metallicHealth == 3){

                lifeMetallicBar.transform.localScale = new Vector3(0.272f, 1, 1);
            }

            if(metallicHealth == 2){

                lifeMetallicBar.transform.localScale = new Vector3(0.181f, 1, 1);
            }

            if(metallicHealth == 1){

                lifeMetallicBar.transform.localScale = new Vector3(0.09f, 1, 1);
            }

            if(metallicHealth <= 0){

                lifeMetallicBar.transform.localScale = new Vector3(0, 1, 1);
            }

            lifeMetallicText.SetActive(true);
            lifeMetallicBar.SetActive(true);
            metallic.SetActive(true);
            UIMetallic.SetActive(true);

            lifeMetallicText.GetComponent<TextMeshProUGUI>().text = "HP: " + metallicHealth;

            if(ally == 2 || ally == 3 || ally == 4 || whoHeal == 1){

                lifeMetallicText.transform.localPosition = positionWithAllyText;
                lifeMetallicBar.transform.localPosition = positionWithAllyBar;
                metallic.transform.localPosition = positionWithAllySprite;
                damagedMetallic.transform.localPosition = positionWithAllySprite;
                healMetallic.transform.localPosition = positionWithAllySprite;
                UIMetallic.transform.localPosition = positionWithAllyUI;
            }
        }

        if(GameManager.unitWhoTarget == 2 || ally == 2 || GameManager.whoAttack == 2 || whoHeal == 2){

            if(jazzHealth == 6){

                lifeJazzBar.transform.localScale = new Vector3(1, 1, 1);
            }

            if(jazzHealth == 5){

                lifeJazzBar.transform.localScale = new Vector3(0.833f, 1, 1);
            }

            if(jazzHealth == 4){

                lifeJazzBar.transform.localScale = new Vector3(0.666f, 1, 1);
            }

            if(jazzHealth == 3){

                lifeJazzBar.transform.localScale = new Vector3(0.499f, 1, 1);
            }

            if(jazzHealth == 2){

                lifeJazzBar.transform.localScale = new Vector3(0.332f, 1, 1);
            }

            if(jazzHealth == 1){

                lifeJazzBar.transform.localScale = new Vector3(0.165f, 1, 1);
            }

            if(jazzHealth <= 0){

                lifeJazzBar.transform.localScale = new Vector3(0, 1, 1);
            }

            lifeJazzText.SetActive(true);
            lifeJazzBar.SetActive(true);
            jazz.SetActive(true);
            UIJazz.SetActive(true);

            lifeJazzText.GetComponent<TextMeshProUGUI>().text = "HP: " + jazzHealth;

            if(ally == 1 || ally == 3 || ally == 4 || whoHeal == 2){

                lifeJazzText.transform.localPosition = positionWithAllyText;
                lifeJazzBar.transform.localPosition = positionWithAllyBar;
                jazz.transform.localPosition = positionWithAllySprite;
                damagedJazz.transform.localPosition = positionWithAllySprite;
                healJazz.transform.localPosition = positionWithAllySprite;
                UIJazz.transform.localPosition = positionWithAllyUI;
            }
        }

        if(GameManager.unitWhoTarget == 3 || ally == 3 || GameManager.whoAttack == 3 || whoHeal == 3){

            if(electronicHealth == 8){

                lifeElectronicBar.transform.localScale = new Vector3(1, 1, 1);
            }

            if(electronicHealth == 7){

                lifeElectronicBar.transform.localScale = new Vector3(0.875f, 1, 1);
            }

            if(electronicHealth == 6){

                lifeElectronicBar.transform.localScale = new Vector3(0.75f, 1, 1);
            }

            if(electronicHealth == 5){

                lifeElectronicBar.transform.localScale = new Vector3(0.625f, 1, 1);
            }

            if(electronicHealth == 4){

                lifeElectronicBar.transform.localScale = new Vector3(0.5f, 1, 1);
            }

            if(electronicHealth == 3){

                lifeElectronicBar.transform.localScale = new Vector3(0.375f, 1, 1);
            }

            if(electronicHealth == 2){

                lifeElectronicBar.transform.localScale = new Vector3(0.25f, 1, 1);
            }

            if(electronicHealth == 1){

                lifeElectronicBar.transform.localScale = new Vector3(0.125f, 1, 1);
            }

            if(electronicHealth <= 0){

                lifeElectronicBar.transform.localScale = new Vector3(0, 1, 1);
            }

            lifeElectronicText.SetActive(true);
            lifeElectronicBar.SetActive(true);
            electronic.SetActive(true);
            UIElectronic.SetActive(true);

            lifeElectronicText.GetComponent<TextMeshProUGUI>().text = "HP: " + electronicHealth;

            if(ally == 1 || ally == 2 || ally == 4 || whoHeal == 3){

                lifeElectronicText.transform.localPosition = positionWithAllyText;
                lifeElectronicBar.transform.localPosition = positionWithAllyBar;
                electronic.transform.localPosition = positionWithAllySprite;
                damagedElectronic.transform.localPosition = positionWithAllySprite;
                healElectronic.transform.localPosition = positionWithAllySprite;
                UIElectronic.transform.localPosition = positionWithAllyUI;
            }
        }

        if(GameManager.unitWhoTarget == 4 || ally == 4 || GameManager.whoAttack == 4){

            if(classicHealth == 8){

                lifeClassicBar.transform.localScale = new Vector3(1, 1, 1);
            }

            if(classicHealth == 7){

                lifeClassicBar.transform.localScale = new Vector3(0.875f, 1, 1);
            }

            if(classicHealth == 6){

                lifeClassicBar.transform.localScale = new Vector3(0.75f, 1, 1);
            }

            if(classicHealth == 5){

                lifeClassicBar.transform.localScale = new Vector3(0.625f, 1, 1);
            }

            if(classicHealth == 4){

                lifeClassicBar.transform.localScale = new Vector3(0.5f, 1, 1);
            }

            if(classicHealth == 3){

                lifeClassicBar.transform.localScale = new Vector3(0.375f, 1, 1);
            }

            if(classicHealth == 2){

                lifeClassicBar.transform.localScale = new Vector3(0.25f, 1, 1);
            }

            if(classicHealth == 1){

                lifeClassicBar.transform.localScale = new Vector3(0.125f, 1, 1);
            }

            if(classicHealth <= 0){

                lifeClassicBar.transform.localScale = new Vector3(0, 1, 1);
            }

            lifeClassicText.SetActive(true);
            lifeClassicBar.SetActive(true);
            classic.SetActive(true);
            UIClassic.SetActive(true);

            lifeClassicText.GetComponent<TextMeshProUGUI>().text = "HP: " + classicHealth;

            if(ally == 1 || ally == 2 || ally == 3){

                lifeClassicText.transform.localPosition = positionWithAllyText;
                lifeClassicBar.transform.localPosition = positionWithAllyBar;
                classic.transform.localPosition = positionWithAllySprite;
                damagedClassic.transform.localPosition = positionWithAllySprite;
                UIClassic.transform.localPosition = positionWithAllyUI;
            }
        }

        if(fightEnd){

            fightEnd = false;

            if(GameManager.fight == 1){

                fireBall.SetActive(true);

                if(GameManager.whoEnemy == 1 || GameManager.whoEnemy == 2 || GameManager.whoEnemy == 3 || GameManager.whoEnemy == 4 || GameManager.whoEnemy == 5 || GameManager.whoEnemy == 6){

                    damageGoblin.SetActive(true);
                }

                if(GameManager.whoEnemy == 7 || GameManager.whoEnemy == 8 || GameManager.whoEnemy == 9 || GameManager.whoEnemy == 10 || GameManager.whoEnemy == 11){

                    damageBat.SetActive(true);
                }

                if(GameManager.whoAttack == 1){

                    if(BeatsManager.beatHit <= BeatsManager.beatMax / 2){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= metallicDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= metallicDamage;
                        }
                    }

                    if(BeatsManager.beatHit > BeatsManager.beatMax / 2 && BeatsManager.beatHit <= BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= metallicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= metallicDamage + 2;
                        }
                    }

                    if(BeatsManager.beatHit == BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= metallicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= metallicDamage + 4;
                        }
                    }
                }

                if(GameManager.whoAttack == 2){

                    if(BeatsManager.beatHit <= BeatsManager.beatMax / 2){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= jazzDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= jazzDamage;
                        }
                    }

                    if(BeatsManager.beatHit > BeatsManager.beatMax / 2 && BeatsManager.beatHit <= BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= jazzDamage + 2;
                        }
                    }

                    if(BeatsManager.beatHit == BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= jazzDamage + 4;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= jazzDamage + 4;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= jazzDamage + 2;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= jazzDamage + 2;
                        }
                    }
                }

                if(GameManager.whoAttack == 3){

                    if(BeatsManager.beatHit <= BeatsManager.beatMax / 2){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= electronicDamage;
                        }
                    }

                    if(BeatsManager.beatHit > BeatsManager.beatMax / 2 && BeatsManager.beatHit <= BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= electronicDamage + 3;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= electronicDamage + 3;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= electronicDamage;
                        }
                    }

                    if(BeatsManager.beatHit == BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= electronicDamage + 5;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= electronicDamage + 5;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= electronicDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= electronicDamage;
                        }
                    }
                }

                if(GameManager.whoAttack == 4){

                    if(BeatsManager.beatHit <= BeatsManager.beatMax / 2){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= classicDamage;
                        }
                    }

                    if(BeatsManager.beatHit > BeatsManager.beatMax / 2 && BeatsManager.beatHit <= BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= classicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= classicDamage + 2;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= classicDamage;
                        }
                    }

                    if(BeatsManager.beatHit == BeatsManager.beatMax){

                        if(GameManager.whoEnemy == 1){

                            goblinHealth -= classicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 2){

                            goblin1Health -= classicDamage + 4;
                        }

                        if(GameManager.whoEnemy == 3){

                            goblin2Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 4){

                            goblin3Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 5){

                            goblin4Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 6){

                            goblin5Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 7){

                            batHealth -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 8){

                            bat1Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 9){

                            bat2Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 10){

                            bat3Health -= classicDamage;
                        }

                        if(GameManager.whoEnemy == 11){

                            bat4Health -= classicDamage;
                        }
                    }
                }

                GameManager.unitDictionaryHealth["Goblin"] = goblinHealth;
                GameManager.unitDictionaryHealth["Goblin1"] = goblin1Health;
                GameManager.unitDictionaryHealth["Goblin2"] = goblin2Health;
                GameManager.unitDictionaryHealth["Goblin3"] = goblin3Health;
                GameManager.unitDictionaryHealth["Goblin4"] = goblin4Health;
                GameManager.unitDictionaryHealth["Goblin5"] = goblin5Health;
                GameManager.unitDictionaryHealth["Chauve-Souris"] = batHealth;
                GameManager.unitDictionaryHealth["Chauve-Souris1"] = bat1Health;
                GameManager.unitDictionaryHealth["Chauve-Souris2"] = bat2Health;
                GameManager.unitDictionaryHealth["Chauve-Souris3"] = bat3Health;
                GameManager.unitDictionaryHealth["Chauve-Souris4"] = bat4Health;
            }

            if(GameManager.fight == 0){

                if(GameManager.unitWhoTarget == 1){

                    damagedMetallic.SetActive(true);
                }

                if(GameManager.unitWhoTarget == 2){

                    damagedJazz.SetActive(true);
                }

                if(GameManager.unitWhoTarget == 3){

                    damagedElectronic.SetActive(true);
                }

                if(GameManager.unitWhoTarget == 4){

                    damagedClassic.SetActive(true);
                }

                if((GameManager.unitWhoTarget == 1 || GameManager.unitWhoTarget == 2 || GameManager.unitWhoTarget == 3 || GameManager.unitWhoTarget == 4) && (GameManager.whoFight == "Goblin" || GameManager.whoFight == "Goblin1" || GameManager.whoFight == "Goblin2" || GameManager.whoFight == "Goblin3" || GameManager.whoFight == "Goblin4" || GameManager.whoFight == "Goblin5")){

                    if(QTEManager.QTEValide < QTEManager.QTECounter){

                        if(GameManager.unitWhoTarget == 1){

                            metallicHealth -= goblinDamage;
                        }

                        if(GameManager.unitWhoTarget == 2){

                            jazzHealth -= goblinDamage;
                        }

                        if(GameManager.unitWhoTarget == 3){

                            electronicHealth -= goblinDamage;
                        }

                        if(GameManager.unitWhoTarget == 4){

                            classicHealth -= goblinDamage;
                        }
                    }

                    if(QTEManager.QTEValide == QTEManager.QTECounter){

                        if(GameManager.unitWhoTarget == 1){

                            metallicHealth -= goblinDamage - 2;
                        }

                        if(GameManager.unitWhoTarget == 2){

                            jazzHealth -= goblinDamage - 2;
                        }

                        if(GameManager.unitWhoTarget == 3){

                            electronicHealth -= goblinDamage - 2;
                        }

                        if(GameManager.unitWhoTarget == 4){

                            classicHealth -= goblinDamage - 2;
                        }
                    }

                    GameManager.unitDictionaryHealth["Metalleux"] = metallicHealth;
                    GameManager.unitDictionaryHealth["Electro"] = electronicHealth;
                    GameManager.unitDictionaryHealth["Classic"] = classicHealth;
                    GameManager.unitDictionaryHealth["Jazz"] = jazzHealth;
                }

                if((GameManager.unitWhoTarget == 1 || GameManager.unitWhoTarget == 2 || GameManager.unitWhoTarget == 3 || GameManager.unitWhoTarget == 4) && (GameManager.whoFight == "Chauve-Souris" || GameManager.whoFight == "Chauve-souris1" || GameManager.whoFight == "Chauve-souris2" || GameManager.whoFight == "Chauve-souris3" || GameManager.whoFight == "Chauve-souris4")){

                    if(QTEManager.QTEValide < QTEManager.QTECounter){

                        if(GameManager.unitWhoTarget == 1){

                            metallicHealth -= batDamage;
                        }

                        if(GameManager.unitWhoTarget == 2){

                            jazzHealth -= batDamage;
                        }

                        if(GameManager.unitWhoTarget == 3){

                            electronicHealth -= batDamage;
                        }

                        if(GameManager.unitWhoTarget == 4){

                            classicHealth -= batDamage;
                        }
                    }

                    if(QTEManager.QTEValide == QTEManager.QTECounter){

                        if(GameManager.unitWhoTarget == 1){

                            metallicHealth -= batDamage - 2;
                        }

                        if(GameManager.unitWhoTarget == 2){

                            jazzHealth -= batDamage - 2;
                        }

                        if(GameManager.unitWhoTarget == 3){

                            electronicHealth -= batDamage - 2;
                        }

                        if(GameManager.unitWhoTarget == 4){

                            classicHealth -= batDamage - 2;
                        }
                    }

                    GameManager.unitDictionaryHealth["Metalleux"] = metallicHealth;
                    GameManager.unitDictionaryHealth["Jazz"] = jazzHealth;
                    GameManager.unitDictionaryHealth["Electro"] = electronicHealth;
                    GameManager.unitDictionaryHealth["Classic"] = classicHealth;

                    GameManager.unitWhoTarget = 0;
                    GameManager.whoFight = "";
                    GameManager.whoAttack = 0;
                    GameManager.whoEnemy = 0;
                    
                    ally = 0;
                }
            }

            if(GameManager.fight == 2){

                heal.Play();

                if(whoHeal == 1){

                    healMetallic.SetActive(true);

                    if(BeatsManager.beatHit <= BeatsManager.beatMax / 2){

                        if(metallicHealth + 3 >= GameManager.metalmanHealthMax){

                            metallicHealth = GameManager.metalmanHealthMax;
                        }
                        else{

                            metallicHealth += 3;
                        }
                    }

                    if(BeatsManager.beatHit > BeatsManager.beatMax / 2 && BeatsManager.beatHit <= BeatsManager.beatMax){

                        if(metallicHealth + 6 >= GameManager.metalmanHealthMax){

                            metallicHealth = GameManager.metalmanHealthMax;
                        }
                        else{

                            metallicHealth += 6;
                        }
                    }

                    if(BeatsManager.beatHit == BeatsManager.beatMax){

                        if(metallicHealth + 10 >= GameManager.metalmanHealthMax){

                            metallicHealth = GameManager.metalmanHealthMax;
                        }
                        else{

                            metallicHealth += 10;
                        }
                    }

                    GameManager.unitDictionaryHealth["Metalleux"] = metallicHealth;
                }

                if(whoHeal == 2){

                    healJazz.SetActive(true);

                    if(BeatsManager.beatHit <= BeatsManager.beatMax / 2){

                        if(jazzHealth + 3 >= GameManager.jazzmanHealthMax){

                            jazzHealth = GameManager.jazzmanHealthMax;
                        }
                        else{

                            jazzHealth += 3;
                        }
                    }

                    if(BeatsManager.beatHit > BeatsManager.beatMax / 2 && BeatsManager.beatHit <= BeatsManager.beatMax){

                        if(jazzHealth + 6 >= GameManager.jazzmanHealthMax){

                            jazzHealth = GameManager.jazzmanHealthMax;
                        }
                        else{

                            jazzHealth += 6;
                        }
                    }

                    if(BeatsManager.beatHit == BeatsManager.beatMax){

                        if(jazzHealth + 10 >= GameManager.jazzmanHealthMax){

                            jazzHealth = GameManager.jazzmanHealthMax;
                        }
                        else{

                            jazzHealth += 10;
                        }
                    }

                    GameManager.unitDictionaryHealth["Jazz"] = jazzHealth;
                }

                if(whoHeal == 3){

                    healElectronic.SetActive(true);

                    if(BeatsManager.beatHit <= BeatsManager.beatMax / 2){

                        if(electronicHealth + 3 >= GameManager.electronicmanHealthMax){

                            electronicHealth = GameManager.electronicmanHealthMax;
                        }
                        else{

                            electronicHealth += 3;
                        }
                    }

                    if(BeatsManager.beatHit > BeatsManager.beatMax / 2 && BeatsManager.beatHit <= BeatsManager.beatMax){

                        if(electronicHealth + 6 >= GameManager.electronicmanHealthMax){

                            electronicHealth = GameManager.electronicmanHealthMax;
                        }
                        else{

                            electronicHealth += 6;
                        }
                    }

                    if(BeatsManager.beatHit == BeatsManager.beatMax){

                        if(electronicHealth + 10 >= GameManager.electronicmanHealthMax){

                            electronicHealth = GameManager.electronicmanHealthMax;
                        }
                        else{

                            electronicHealth += 10;
                        }
                    }

                    GameManager.unitDictionaryHealth["Electro"] = electronicHealth;
                }

                whoHeal = 0;
            }

            if(GameManager.unitWhoTarget == 0 || GameManager.whoFight == "" || GameManager.whoAttack == 0 || GameManager.whoEnemy == 0 || whoHeal == 0){

                lifeClassicBar.SetActive(false);
                lifeClassicText.SetActive(false);
                classic.SetActive(false);
                UIClassic.SetActive(false);

                lifeElectronicBar.SetActive(false);
                lifeElectronicText.SetActive(false);
                electronic.SetActive(false);
                UIElectronic.SetActive(false);

                lifeJazzBar.SetActive(false);
                lifeJazzText.SetActive(false);
                jazz.SetActive(false);
                UIJazz.SetActive(false);

                lifeMetallicBar.SetActive(false);
                lifeMetallicText.SetActive(false);
                metallic.SetActive(false);
                UIMetallic.SetActive(false);

                lifeEnemyBar.SetActive(false);
                lifeEnemyText.SetActive(false);
                goblin.SetActive(false);
                bat.SetActive(false);
                UIEnemy.SetActive(false);

                UIHeal.SetActive(false);

                hitAlly.SetActive(false);
                missAlly.SetActive(false);
            }

            StopAllCoroutines();
            StartCoroutine(FightFinish());
        }
    }

    IEnumerator FightFinish(){

        MusicSettings.MSInstance.PlayMusic();

        yield return new WaitForSeconds(5f);

        damageBat.SetActive(false);
        damageGoblin.SetActive(false);
        damagedClassic.SetActive(false);
        damagedElectronic.SetActive(false);
        damagedJazz.SetActive(false);
        damagedMetallic.SetActive(false);

        healMetallic.SetActive(false);
        healJazz.SetActive(false);
        healElectronic.SetActive(false);

        fireBall.SetActive(false);

        GameManager.indexScene = true;
        GameManager.whoAttack = 0;

        SceneManager.LoadScene(2);
    }
}
