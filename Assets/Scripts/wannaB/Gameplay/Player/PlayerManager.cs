using wannaB.Gameplay.Player.State;
using wannaB.Utility.StateManagement;

namespace wannaB.Gameplay.Player
{
public class PlayerManager : StateMachine<PlayerState>
{
    private StateItem _moveStateItem;

    private PlayerMovement _playerMovement;

    public void RegisterPlayer(PlayerMovement playerMovement)
    {
        this._playerMovement = playerMovement;
        _moveStateItem = new MoveStateItem(this._playerMovement);

        this.RegisterState(PlayerState.Move, _moveStateItem, true);
    }
}
}
