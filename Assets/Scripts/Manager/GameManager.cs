using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static GridCombatSystem;
using TMPro;

public class GameManager : MonoBehaviour{

    public GameObject goblin;
    public GameObject goblin1;
    public GameObject goblin2;
    public GameObject goblin3;
    public GameObject goblin4;
    public GameObject goblin5;
    public GameObject bat;
    public GameObject bat1;
    public GameObject bat2;
    public GameObject bat3;
    public GameObject bat4;
    public GameObject metalman;
    public GameObject jazzman;
    public GameObject electronicman;
    public GameObject classicman;
    public GameObject attackMenuToAppearGoblin;
    public GameObject attackMenuToAppearGoblin1;
    public GameObject attackMenuToAppearGoblin2;
    public GameObject attackMenuToAppearGoblin3;
    public GameObject attackMenuToAppearGoblin4;
    public GameObject attackMenuToAppearGoblin5;
    public GameObject attackMenuToAppearBat;
    public GameObject attackMenuToAppearBat1;
    public GameObject attackMenuToAppearBat2;
    public GameObject attackMenuToAppearBat3;
    public GameObject attackMenuToAppearBat4;
    public GameObject statEnemyUI;
    public GameObject statEnemyText;
    public GameObject statPlayerUI;
    public GameObject statPlayerText;

    public static GameObject healMenuToAppearMetalman;
    public static GameObject healMenuToAppearJazzman;
    public static GameObject healMenuToAppearElectronicman;

    public int goblinHealthMax;
    public int batHealthMax;

    public static int whoAttack;
    public static int whoEnemy;
    public static int fight;
    public static int unitWhoTarget;
    public static int currentTurn = 1;
    public static int metalmanHealthMax;
    public static int jazzmanHealthMax;
    public static int electronicmanHealthMax;
    public static int classicmanHealthMax;
    public static int unitWhoHeal;
    public static int saveIndexCurrentEnemy;

    public static Dictionary<string, Vector3> unitDictionaryPosition = new Dictionary<string, Vector3>();
    public static Dictionary<string, int> unitDictionaryHealth = new Dictionary<string, int>();
    public static Dictionary<string, int> unitDictionaryDamage = new Dictionary<string, int>();
    public static Dictionary<string, bool> unitDictionaryCanAttack = new Dictionary<string, bool>();
    public static Dictionary<string, bool> unitDictionaryCanMove = new Dictionary<string, bool>();
    
    public static List<string> neighbourList = new List<string>();

    public static string whoFight;
    public static string selection;

    public static bool indexScene;
    public static bool delayReplay;

    public static bool heal = false;

    public static WhoPlay whoPlayThisTurn;

    private void Awake(){

        DontDestroyOnLoad(gameObject);

        var a = FindObjectsOfType<GameManager>();

        if(a.Length > 1){

            Destroy(gameObject);

            return;
        }
        indexScene = true;
        delayReplay = false;

        goblinHealthMax = goblin.GetComponent<UnitGridCombat>().health;
        batHealthMax = bat.GetComponent<UnitGridCombat>().health;
        metalmanHealthMax = metalman.GetComponent<UnitGridCombat>().health;
        jazzmanHealthMax = jazzman.GetComponent<UnitGridCombat>().health;
        electronicmanHealthMax = electronicman.GetComponent<UnitGridCombat>().health;
        classicmanHealthMax = classicman.GetComponent<UnitGridCombat>().health;
    }

    void Update(){

        if (delayReplay)
        {
            delayReplay = false;
            StartCoroutine(DelayReplay());
        }
        if(SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Game") && indexScene)
        {
            indexScene = false;

            goblin = GameObject.Find("Ennemy (Goblin)");
            goblin1 = GameObject.Find("Ennemy (Goblin) (1)");
            goblin2 = GameObject.Find("Ennemy (Goblin) (2)");
            goblin3 = GameObject.Find("Ennemy (Goblin) (3)");
            goblin4 = GameObject.Find("Ennemy (Goblin) (4)");
            goblin5 = GameObject.Find("Ennemy (Goblin) (5)");
            bat = GameObject.Find("Ennemy (Chauve-Souris)");
            bat1 = GameObject.Find("Ennemy (Chauve-Souris) (1)");
            bat2 = GameObject.Find("Ennemy (Chauve-Souris) (2)");
            bat3 = GameObject.Find("Ennemy (Chauve-Souris) (3)");
            bat4 = GameObject.Find("Ennemy (Chauve-Souris) (4)");
            metalman = GameObject.Find("Player(Metalleux)");
            jazzman = GameObject.Find("Player(Jazz)");
            electronicman = GameObject.Find("Player(Electro)");
            classicman = GameObject.Find("Player(Classic)");
            attackMenuToAppearGoblin = GameObject.Find("AttackMenuGobin");
            attackMenuToAppearGoblin1 = GameObject.Find("AttackMenuGobin1");
            attackMenuToAppearGoblin2 = GameObject.Find("AttackMenuGobin2");
            attackMenuToAppearGoblin3 = GameObject.Find("AttackMenuGobin3");
            attackMenuToAppearGoblin4 = GameObject.Find("AttackMenuGobin4");
            attackMenuToAppearGoblin5 = GameObject.Find("AttackMenuGobin5");
            attackMenuToAppearBat = GameObject.Find("AttackMenuBat");
            attackMenuToAppearBat1 = GameObject.Find("AttackMenuBat1");
            attackMenuToAppearBat2 = GameObject.Find("AttackMenuBat2");
            attackMenuToAppearBat3 = GameObject.Find("AttackMenuBat3");
            attackMenuToAppearBat4 = GameObject.Find("AttackMenuBat4");
            healMenuToAppearMetalman = GameObject.Find("HealMenuMetalman");
            healMenuToAppearJazzman = GameObject.Find("HealMenuJazzman");
            healMenuToAppearElectronicman = GameObject.Find("HealMenuElectronicman");
            statEnemyUI = GameObject.Find("StatEnemy");
            statPlayerUI = GameObject.Find("StatPlayer");
            statEnemyText = GameObject.Find("StatEnemyText");
            statPlayerText = GameObject.Find("StatPlayerText");

            if(attackMenuToAppearGoblin != null)
                attackMenuToAppearGoblin.SetActive(false);
            if (attackMenuToAppearGoblin1 != null)
                attackMenuToAppearGoblin1.SetActive(false);
            if (attackMenuToAppearGoblin2 != null)
                attackMenuToAppearGoblin2.SetActive(false);
            if (attackMenuToAppearGoblin3 != null)
                attackMenuToAppearGoblin3.SetActive(false);
            if (attackMenuToAppearGoblin4 != null)
                attackMenuToAppearGoblin4.SetActive(false);
            if (attackMenuToAppearGoblin5 != null)
                attackMenuToAppearGoblin5.SetActive(false);
            if (attackMenuToAppearBat != null)
                attackMenuToAppearBat.SetActive(false);
            if (attackMenuToAppearBat1 != null)
                attackMenuToAppearBat1.SetActive(false);
            if (attackMenuToAppearBat2 != null)
                attackMenuToAppearBat2.SetActive(false);
            if (attackMenuToAppearBat3 != null)
                attackMenuToAppearBat3.SetActive(false);
            if (attackMenuToAppearBat4 != null)
                attackMenuToAppearBat4.SetActive(false);
            if (healMenuToAppearMetalman != null)
                healMenuToAppearMetalman.SetActive(false);
            if(healMenuToAppearJazzman != null)
                healMenuToAppearJazzman.SetActive(false);
            if(healMenuToAppearElectronicman != null)
                healMenuToAppearElectronicman.SetActive(false);

            statEnemyUI.SetActive(false);
            statPlayerUI.SetActive(false);
        }

        if(Input.GetMouseButtonDown(0)){

            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            Vector3 mouseWorldPosition = GetMousePosition.GetMouseWorldPosition();
            Grid<GridObject> grid = GameHandler_GridCombatSystem.Instance.GetGrid();
            GridObject gridObject = grid.GetGridObject(mouseWorldPosition);
            if(grid.GetGridObject(mouseWorldPosition) != null)
            {
                if (gridObject.GetUnitGridCombat() != null)
                {
                    if (GridCombatSystem.Instance.unitGridCombat != null)
                    {
                        if (GridCombatSystem.Instance.unitGridCombat.IsEnemy(gridObject.GetUnitGridCombat()))
                        {
                            if (gridObject.GetIsValidMovePosition())
                            {
                                if (hit.collider != null && hit.collider.gameObject == goblin)
                                {
                                    if(attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(true);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == goblin1)
                                {
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == goblin2)
                                {
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == goblin3)
                                {
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == goblin4)
                                {
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == goblin5)
                                {
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }

                                if (hit.collider != null && hit.collider.gameObject == bat)
                                {
                                    if(attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(true);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);

                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == bat1)
                                {
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == bat2)
                                {
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == bat3)
                                {
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                                if (hit.collider != null && hit.collider.gameObject == bat4)
                                {
                                    if (attackMenuToAppearBat4 != null)
                                        attackMenuToAppearBat4.SetActive(true);
                                    if (attackMenuToAppearBat != null)
                                        attackMenuToAppearBat.SetActive(false);
                                    if (attackMenuToAppearBat1 != null)
                                        attackMenuToAppearBat1.SetActive(false);
                                    if (attackMenuToAppearBat2 != null)
                                        attackMenuToAppearBat2.SetActive(false);
                                    if (attackMenuToAppearBat3 != null)
                                        attackMenuToAppearBat3.SetActive(false);
                                    if (attackMenuToAppearGoblin != null)
                                        attackMenuToAppearGoblin.SetActive(false);
                                    if (attackMenuToAppearGoblin1 != null)
                                        attackMenuToAppearGoblin1.SetActive(false);
                                    if (attackMenuToAppearGoblin2 != null)
                                        attackMenuToAppearGoblin2.SetActive(false);
                                    if (attackMenuToAppearGoblin3 != null)
                                        attackMenuToAppearGoblin3.SetActive(false);
                                    if (attackMenuToAppearGoblin4 != null)
                                        attackMenuToAppearGoblin4.SetActive(false);
                                    if (attackMenuToAppearGoblin5 != null)
                                        attackMenuToAppearGoblin5.SetActive(false);
                                    GridCombatSystem.Instance.state = State.Waiting;
                                }
                            }
                            else
                            {
                                // Cannot attack enemy
                            }

                        }
                        else
                        {
                            // Not an enemy
                        }
                    }
                    //break;//empeche l'uniter d'aller sur la position d'un allier ou un enemy
                }
                else
                {
                    // No unit here
                }
            }
            if(hit.collider != null && hit.collider.gameObject == goblin){

                whoEnemy = 1;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Goblin\nHP: " + goblin.GetComponent<UnitGridCombat>().health + " / " + goblinHealthMax + "\nAttack: " + goblin.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + goblin.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == goblin1){

                whoEnemy = 2;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Goblin\nHP: " + goblin1.GetComponent<UnitGridCombat>().health + " / " + goblinHealthMax + "\nAttack: " + goblin1.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + goblin1.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == goblin2){

                whoEnemy = 3;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Goblin\nHP: " + goblin2.GetComponent<UnitGridCombat>().health + " / " + goblinHealthMax + "\nAttack: " + goblin2.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + goblin2.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == goblin3){

                whoEnemy = 4;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Goblin\nHP: " + goblin3.GetComponent<UnitGridCombat>().health + " / " + goblinHealthMax + "\nAttack: " + goblin3.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + goblin3.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == goblin4){

                whoEnemy = 5;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Goblin\nHP: " + goblin4.GetComponent<UnitGridCombat>().health + " / " + goblinHealthMax + "\nAttack: " + goblin4.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + goblin4.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == goblin5){

                whoEnemy = 6;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Goblin\nHP: " + goblin5.GetComponent<UnitGridCombat>().health + " / " + goblinHealthMax + "\nAttack: " + goblin5.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + goblin5.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == bat){

                whoEnemy = 7;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Bat\nHP: " + bat.GetComponent<UnitGridCombat>().health + " / "+ batHealthMax + "\nAttack: " + bat.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + bat.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == bat1){

                whoEnemy = 8;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Bat\nHP: " + bat1.GetComponent<UnitGridCombat>().health + " / "+ batHealthMax + "\nAttack: " + bat1.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + bat1.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == bat2){

                whoEnemy = 9;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Bat\nHP: " + bat2.GetComponent<UnitGridCombat>().health + " / "+ batHealthMax + "\nAttack: " + bat2.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + bat2.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == bat3){

                whoEnemy = 10;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Bat\nHP: " + bat3.GetComponent<UnitGridCombat>().health + " / "+ batHealthMax + "\nAttack: " + bat3.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + bat3.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == bat4){

                whoEnemy = 11;

                statEnemyUI.SetActive(true);

                statEnemyText.GetComponent<TextMeshProUGUI>().text = "Bat\nHP: " + bat4.GetComponent<UnitGridCombat>().health + " / "+ batHealthMax + "\nAttack: " + bat4.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + bat4.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == metalman){

                whoAttack = 1;

                statPlayerUI.SetActive(true);

                statPlayerText.GetComponent<TextMeshProUGUI>().text = "Metalman\nHP: " + metalman.GetComponent<UnitGridCombat>().health + " / " + metalmanHealthMax + "\nAttack: " + metalman.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + metalman.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == jazzman){

                whoAttack = 2;

                statPlayerUI.SetActive(true);

                statPlayerText.GetComponent<TextMeshProUGUI>().text = "Jazzman\nHP: " + jazzman.GetComponent<UnitGridCombat>().health + " / " + jazzmanHealthMax + "\nAttack: " + jazzman.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + jazzman.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == electronicman){

                whoAttack = 3;

                statPlayerUI.SetActive(true);

                statPlayerText.GetComponent<TextMeshProUGUI>().text = "Electronicman\nHP: " + electronicman.GetComponent<UnitGridCombat>().health + " / " + electronicmanHealthMax + "\nAttack: " + electronicman.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + electronicman.GetComponent<UnitGridCombat>().reach;
            }

            if(hit.collider != null && hit.collider.gameObject == classicman){

                whoAttack = 4;

                statPlayerUI.SetActive(true);

                statPlayerText.GetComponent<TextMeshProUGUI>().text = "Classicman\nHP: " + classicman.GetComponent<UnitGridCombat>().health + " / " + classicmanHealthMax + "\nAttack: " + classicman.GetComponent<UnitGridCombat>().damage + "\nSpeed: " + classicman.GetComponent<UnitGridCombat>().reach;
            }
        }

        if(Input.GetMouseButtonDown(1)){

            if(attackMenuToAppearGoblin != null)
                attackMenuToAppearGoblin.SetActive(false);
            if (attackMenuToAppearGoblin1 != null)
                attackMenuToAppearGoblin1.SetActive(false);
            if (attackMenuToAppearGoblin2 != null)
                attackMenuToAppearGoblin2.SetActive(false);
            if (attackMenuToAppearGoblin3 != null)
                attackMenuToAppearGoblin3.SetActive(false);
            if (attackMenuToAppearGoblin4 != null)
                attackMenuToAppearGoblin4.SetActive(false);
            if (attackMenuToAppearGoblin5 != null)
                attackMenuToAppearGoblin5.SetActive(false);
            if (attackMenuToAppearBat != null)
                attackMenuToAppearBat.SetActive(false);
            if (attackMenuToAppearBat1 != null)
                attackMenuToAppearBat1.SetActive(false);
            if (attackMenuToAppearBat2 != null)
                attackMenuToAppearBat2.SetActive(false);
            if (attackMenuToAppearBat3 != null)
                attackMenuToAppearBat3.SetActive(false);
            if (attackMenuToAppearBat4 != null)
                attackMenuToAppearBat4.SetActive(false);
            statEnemyUI.SetActive(false);
            if(healMenuToAppearElectronicman != null)
                healMenuToAppearElectronicman.SetActive(false);
            if(healMenuToAppearJazzman != null)
                healMenuToAppearJazzman.SetActive(false);
            if(healMenuToAppearMetalman != null)
                healMenuToAppearMetalman.SetActive(false);
            //statPlayerUI.SetActive(false);
            GridCombatSystem.Instance.state = State.Normal;
        }
    }
    IEnumerator DelayReplay()
    {
        yield return new WaitForSeconds(0.1f);
        indexScene = true;
    }
}
