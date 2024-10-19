using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIsWalkable : MonoBehaviour
{
    private void Start()
    {
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(5, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(5, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(15, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(15, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 0).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 0).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 0).isWalkable);
        
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 1).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 1).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 1).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 2).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 2).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 2).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 3).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 3).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 3).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 3).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 3).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 3).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 4).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 4).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 4).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 4).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 5).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 5).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 5).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 5).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 5).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 5).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 6).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 6).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 6).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 7).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 7).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 7).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 8).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 8).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 8).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(5, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(5, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 9).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 9).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 9).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 10).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 10).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(6, 10).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 10).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 10).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 10).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 10).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 10).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 10).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 11).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 11).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 11).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 11).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 11).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 11).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 12).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 12).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 13).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 13).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 13).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 13).isWalkable);


        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 14).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 14).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 14).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 14).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 14).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 14).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 14).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 14).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 14).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 14).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 14).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 14).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 14).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 14).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(13, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(14, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(15, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(15, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 15).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 15).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 15).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(11, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(12, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(15, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(15, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 16).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 16).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 16).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 17).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(7, 17).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 17).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 17).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(10, 17).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 17).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 17).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 17).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 17).isWalkable);
        
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 18).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 18).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 18).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 18).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 18).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(8, 18).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 18).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(9, 18).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 19).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 19).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 19).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 19).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 20).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 20).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 20).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 20).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 20).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 20).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 20).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 20).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 20).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 20).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 20).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 20).isWalkable);

        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(0, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(1, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(2, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(3, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(3, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(4, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(4, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(16, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(17, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(18, 21).isWalkable);
        GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 21).SetIsWalkable(!GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(19, 21).isWalkable);
       
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetIsWalkable();


        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 0, Tilemap.TilemapObject.TilemapSprite.Tile54);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 0, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 0, Tilemap.TilemapObject.TilemapSprite.Tile7);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(3, 0, Tilemap.TilemapObject.TilemapSprite.Tile58);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(5, 0, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(6, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 0, Tilemap.TilemapObject.TilemapSprite.Tile46);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 0, Tilemap.TilemapObject.TilemapSprite.Tile36);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 0, Tilemap.TilemapObject.TilemapSprite.Tile36);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(14, 0, Tilemap.TilemapObject.TilemapSprite.Tile36);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(15, 0, Tilemap.TilemapObject.TilemapSprite.Tile36);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(16, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 0, Tilemap.TilemapObject.TilemapSprite.Tile52);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 0, Tilemap.TilemapObject.TilemapSprite.Tile31);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 1, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 1, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 1, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(6, 1, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 1, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 1, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 1, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 1, Tilemap.TilemapObject.TilemapSprite.Tile53);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 1, Tilemap.TilemapObject.TilemapSprite.Tile33);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(16, 1, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 1, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 1, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 1, Tilemap.TilemapObject.TilemapSprite.Tile31);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 2, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 2, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(5, 2, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 2, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 2, Tilemap.TilemapObject.TilemapSprite.Tile36);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 2, Tilemap.TilemapObject.TilemapSprite.Tile36);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 2, Tilemap.TilemapObject.TilemapSprite.Tile33);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 2, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 2, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 2, Tilemap.TilemapObject.TilemapSprite.Tile31);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 3, Tilemap.TilemapObject.TilemapSprite.Tile7);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 3, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 3, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 3, Tilemap.TilemapObject.TilemapSprite.Tile31);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 4, Tilemap.TilemapObject.TilemapSprite.Tile7);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 4, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 4, Tilemap.TilemapObject.TilemapSprite.Tile59);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 4, Tilemap.TilemapObject.TilemapSprite.Tile39);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 5, Tilemap.TilemapObject.TilemapSprite.Tile7);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 5, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(14, 5, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 5, Tilemap.TilemapObject.TilemapSprite.Tile35);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 5, Tilemap.TilemapObject.TilemapSprite.Tile31);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 6, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 6, Tilemap.TilemapObject.TilemapSprite.Tile4);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 6, Tilemap.TilemapObject.TilemapSprite.Tile20);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 6, Tilemap.TilemapObject.TilemapSprite.Tile23);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 6, Tilemap.TilemapObject.TilemapSprite.Tile19);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 6, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 6, Tilemap.TilemapObject.TilemapSprite.Tile20);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 6, Tilemap.TilemapObject.TilemapSprite.Tile19);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 6, Tilemap.TilemapObject.TilemapSprite.Tile35);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 6, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 6, Tilemap.TilemapObject.TilemapSprite.Tile31);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 7, Tilemap.TilemapObject.TilemapSprite.Tile50);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 7, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 7, Tilemap.TilemapObject.TilemapSprite.Tile4);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(6, 7, Tilemap.TilemapObject.TilemapSprite.Tile20);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 7, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 7, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 7, Tilemap.TilemapObject.TilemapSprite.Tile48);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 7, Tilemap.TilemapObject.TilemapSprite.Tile23);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 7, Tilemap.TilemapObject.TilemapSprite.Tile23);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 7, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 7, Tilemap.TilemapObject.TilemapSprite.Tile50);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(14, 7, Tilemap.TilemapObject.TilemapSprite.Tile19);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 7, Tilemap.TilemapObject.TilemapSprite.Tile39);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 7, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 7, Tilemap.TilemapObject.TilemapSprite.Tile31);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 8, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 8, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 8, Tilemap.TilemapObject.TilemapSprite.Tile7);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(5, 8, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(6, 8, Tilemap.TilemapObject.TilemapSprite.Tile24);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 8, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 8, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 8, Tilemap.TilemapObject.TilemapSprite.Tile21);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 8, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 8, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 8, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 8, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(14, 8, Tilemap.TilemapObject.TilemapSprite.Tile18);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 8, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 8, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 8, Tilemap.TilemapObject.TilemapSprite.Tile49);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 9, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 9, Tilemap.TilemapObject.TilemapSprite.Tile55);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 9, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(5, 9, Tilemap.TilemapObject.TilemapSprite.Tile28);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(6, 9, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 9, Tilemap.TilemapObject.TilemapSprite.Tile49);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 9, Tilemap.TilemapObject.TilemapSprite.Tile22);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 9, Tilemap.TilemapObject.TilemapSprite.Tile58);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 9, Tilemap.TilemapObject.TilemapSprite.Tile17);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 9, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 9, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 9, Tilemap.TilemapObject.TilemapSprite.Tile22);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 9, Tilemap.TilemapObject.TilemapSprite.Tile32);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 9, Tilemap.TilemapObject.TilemapSprite.Tile36);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 10, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 10, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 10, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(6, 10, Tilemap.TilemapObject.TilemapSprite.Tile17);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 10, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 10, Tilemap.TilemapObject.TilemapSprite.Tile18);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 10, Tilemap.TilemapObject.TilemapSprite.Tile17);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 10, Tilemap.TilemapObject.TilemapSprite.Tile53);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 10, Tilemap.TilemapObject.TilemapSprite.Tile18);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 10, Tilemap.TilemapObject.TilemapSprite.Tile57);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 11, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 11, Tilemap.TilemapObject.TilemapSprite.Tile25);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 11, Tilemap.TilemapObject.TilemapSprite.Tile25);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(14, 11, Tilemap.TilemapObject.TilemapSprite.Tile57);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 12, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 12, Tilemap.TilemapObject.TilemapSprite.Tile5);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 13, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 13, Tilemap.TilemapObject.TilemapSprite.Tile5);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 13, Tilemap.TilemapObject.TilemapSprite.Tile1);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(4, 14, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 14, Tilemap.TilemapObject.TilemapSprite.Tile5);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 14, Tilemap.TilemapObject.TilemapSprite.Tile8);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 14, Tilemap.TilemapObject.TilemapSprite.Tile8);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(14, 14, Tilemap.TilemapObject.TilemapSprite.Tile4);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(15, 14, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 14, Tilemap.TilemapObject.TilemapSprite.Tile5);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 14, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 14, Tilemap.TilemapObject.TilemapSprite.Tile47);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 15, Tilemap.TilemapObject.TilemapSprite.Tile5);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 15, Tilemap.TilemapObject.TilemapSprite.Tile8);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 15, Tilemap.TilemapObject.TilemapSprite.Tile8);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 15, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 15, Tilemap.TilemapObject.TilemapSprite.Tile53);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 15, Tilemap.TilemapObject.TilemapSprite.Tile6);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(14, 15, Tilemap.TilemapObject.TilemapSprite.Tile6);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(15, 15, Tilemap.TilemapObject.TilemapSprite.Tile8);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(16, 15, Tilemap.TilemapObject.TilemapSprite.Tile8);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 15, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 15, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 15, Tilemap.TilemapObject.TilemapSprite.Tile1);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 16, Tilemap.TilemapObject.TilemapSprite.Tile59);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 16, Tilemap.TilemapObject.TilemapSprite.Tile5);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 16, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 16, Tilemap.TilemapObject.TilemapSprite.Tile47);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 16, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(11, 16, Tilemap.TilemapObject.TilemapSprite.Tile6);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(12, 16, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(15, 16, Tilemap.TilemapObject.TilemapSprite.Tile2);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(16, 16, Tilemap.TilemapObject.TilemapSprite.Tile6);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 16, Tilemap.TilemapObject.TilemapSprite.Tile55);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 16, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 16, Tilemap.TilemapObject.TilemapSprite.Tile1);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 17, Tilemap.TilemapObject.TilemapSprite.Tile19);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(7, 17, Tilemap.TilemapObject.TilemapSprite.Tile2);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 17, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 17, Tilemap.TilemapObject.TilemapSprite.Tile1);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 17, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 17, Tilemap.TilemapObject.TilemapSprite.Tile2);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 17, Tilemap.TilemapObject.TilemapSprite.Tile6);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 17, Tilemap.TilemapObject.TilemapSprite.Tile6);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 18, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 18, Tilemap.TilemapObject.TilemapSprite.Tile19);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(8, 18, Tilemap.TilemapObject.TilemapSprite.Tile2);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(9, 18, Tilemap.TilemapObject.TilemapSprite.Tile3);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(10, 18, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 18, Tilemap.TilemapObject.TilemapSprite.Tile57);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 19, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 19, Tilemap.TilemapObject.TilemapSprite.Tile22);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 19, Tilemap.TilemapObject.TilemapSprite.Tile58);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 20, Tilemap.TilemapObject.TilemapSprite.Tile51);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 20, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 20, Tilemap.TilemapObject.TilemapSprite.Tile19);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(3, 20, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(6, 20, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(13, 20, Tilemap.TilemapObject.TilemapSprite.Tile57);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 20, Tilemap.TilemapObject.TilemapSprite.Tile35);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 20, Tilemap.TilemapObject.TilemapSprite.Tile38);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 20, Tilemap.TilemapObject.TilemapSprite.Tile38);

        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(0, 21, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(1, 21, Tilemap.TilemapObject.TilemapSprite.Tile16);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(2, 21, Tilemap.TilemapObject.TilemapSprite.Tile55);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(3, 21, Tilemap.TilemapObject.TilemapSprite.Tile23);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(4, 21, Tilemap.TilemapObject.TilemapSprite.Tile19);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(16, 21, Tilemap.TilemapObject.TilemapSprite.Tile35);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(17, 21, Tilemap.TilemapObject.TilemapSprite.Tile31);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(18, 21, Tilemap.TilemapObject.TilemapSprite.Tile51);
        GameHandler_GridCombatSystem.Instance.GetWalkableTilemap().SetTilemapSprite(19, 21, Tilemap.TilemapObject.TilemapSprite.Tile31);
    }
}
