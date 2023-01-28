using wannaB.Utility.StateManagement;

namespace wannaB.Gameplay.Player.State
{
public class MoveStateItem : StateItem
{
    private readonly PlayerMovement _playerMovement;

    public MoveStateItem(PlayerMovement playerMovement)
    {
        this._playerMovement = playerMovement;
    }

    public override void OnStateEnter()
    {
        this._playerMovement.CanMove = true;
    }

    public override void OnStateExit()
    {
        this._playerMovement.CanMove = false;
    }
}
}
