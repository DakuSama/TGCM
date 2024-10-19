using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatObject : MonoBehaviour{

    public bool canBePressed;

    private int beatType;

    public KeyCode keyToPress;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        if(Input.GetKeyDown(keyToPress)){

            if(canBePressed){

                Destroy(gameObject);

                BeatsManager.BMInstance.BeatHit();

                if(beatType == 1){

                    GameObject hitUp = Instantiate(FightManager.FMInstance.hit, new Vector3(-4.4f, 5.35f, 0), Quaternion.identity);
                    GameObject perfectUp = Instantiate(FightManager.FMInstance.perfect, new Vector3(-7f, 5f, 0), Quaternion.identity);

                    perfectUp.transform.Rotate(-90, 0, 0);

                    hitUp.SetActive(true);
                    perfectUp.SetActive(true);
                }

                if(beatType == 2){

                    GameObject hitDown = Instantiate(FightManager.FMInstance.hit, new Vector3(-4.4f, 4.35f, 0), Quaternion.identity);
                    GameObject perfectDown = Instantiate(FightManager.FMInstance.perfect, new Vector3(-7f, 4f, 0), Quaternion.identity);

                    perfectDown.transform.Rotate(-90, 0 ,0);

                    hitDown.SetActive(true);
                    perfectDown.SetActive(true);
                }

                if(beatType == 3){

                    GameObject hitLeft = Instantiate(FightManager.FMInstance.hit, new Vector3(-4.4f, 3.35f, 0), Quaternion.identity);
                    GameObject perfectLeft = Instantiate(FightManager.FMInstance.perfect, new Vector3(-7f, 3f, 0), Quaternion.identity);

                    perfectLeft.transform.Rotate(-90, 0, 0);

                    hitLeft.SetActive(true);
                    perfectLeft.SetActive(true);
                }

                if(beatType == 4){

                    GameObject hitRight = Instantiate(FightManager.FMInstance.hit, new Vector3(-4.4f, 2.35f, 0), Quaternion.identity);
                    GameObject perfectRight = Instantiate(FightManager.FMInstance.perfect, new Vector3(-7f, 2f, 0), Quaternion.identity);

                    perfectRight.transform.Rotate(-90, 0, 0);

                    hitRight.SetActive(true);
                    perfectRight.SetActive(true);
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.tag == "Beat"){

            canBePressed = true;

            if(other.gameObject.name == "BeatUp"){

                beatType = 1;
            }

            if(other.gameObject.name == "BeatDown"){

                beatType = 2;
            }

            if(other.gameObject.name == "BeatLeft"){

                beatType = 3;
            }

            if(other.gameObject.name == "BeatRight"){

                beatType = 4;
            }
        }

        if(other.tag == "Dead"){
            
            canBePressed = false;

            if(other.gameObject.name == "BeatUp"){

                beatType = 5;
            }

            if(other.gameObject.name == "BeatDown"){

                beatType = 6;
            }

            if(other.gameObject.name == "BeatLeft"){

                beatType = 7;
            }

            if(other.gameObject.name == "BeatRight"){

                beatType = 8;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other){

        if(other.tag == "Beat"){

            Destroy(gameObject);

            BeatsManager.BMInstance.BeatMissed();

            if(beatType == 5){

                GameObject missUp = Instantiate(FightManager.FMInstance.miss, new Vector3(-7f, 5f, 0), Quaternion.identity);

                missUp.transform.Rotate(-90, 0, 0);

                missUp.SetActive(true);
            }

            if(beatType == 6){

                GameObject missDown = Instantiate(FightManager.FMInstance.miss, new Vector3(-7f, 4f, 0), Quaternion.identity);

                missDown.transform.Rotate(-90, 0, 0);

                missDown.SetActive(true);
            }

            if(beatType == 7){

                GameObject missLeft = Instantiate(FightManager.FMInstance.miss, new Vector3(-7f, 3f, 0), Quaternion.identity);

                missLeft.transform.Rotate(-90, 0, 0);

                missLeft.SetActive(true);
            }

            if(beatType == 8){

                GameObject missRight = Instantiate(FightManager.FMInstance.miss, new Vector3(-7f, 2f, 0), Quaternion.identity);

                missRight.transform.Rotate(-90, 0, 0);

                missRight.SetActive(true);
            }
        }

        if(other.tag == "Enter"){

            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
