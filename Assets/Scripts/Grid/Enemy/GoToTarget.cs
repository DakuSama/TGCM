using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static GridCombatSystem;

public class GoToTarget : BehaviorTree.Node
{
    private UnitGridCombat _playerTransform;
    private UnitGridCombat _unitGridCombat;

    public GoToTarget(UnitGridCombat unitGridCombat)
    {
        _unitGridCombat = unitGridCombat;

    }

    public override BehaviorTree.NodeState Evaluate()
    {
        GameHandler_GridCombatSystem.Instance.SetCameraFollowPosition(_unitGridCombat.GetPosition());
        if (_unitGridCombat.canMove)
        {
            if(_unitGridCombat.canMoveThisTurn)
            {
                _playerTransform = GridCombatSystem.Instance.WhoTarget(_unitGridCombat);
                GameHandler_GridCombatSystem.Instance.GetGrid().GetGridObject(_unitGridCombat.GetPosition()).CleanUnitGridCombat();

                GameHandler_GridCombatSystem.Instance.GetGrid().GetXY(_unitGridCombat.GetPosition(), out int gridX, out int gridY);
                GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(gridX, gridY).SetIsWalkable(true);

                _unitGridCombat.MoveTo(_playerTransform.transform.position, () =>
                {
                    _unitGridCombat.canMoveThisTurn = false;
                    _unitGridCombat.canAttack = true;
                    GameHandler_GridCombatSystem.Instance.GetGrid().GetXY(_unitGridCombat.GetPosition(), out int gridX, out int gridY);
                    GameHandler_GridCombatSystem.Instance.pathfinding.GetNode(gridX, gridY).SetIsWalkable(false);
                });
            }
            _unitGridCombat.canMove = false;
            
        }
        _unitGridCombat.StopEnemy();

        return BehaviorTree.NodeState.SUCCESS;
    }
}
