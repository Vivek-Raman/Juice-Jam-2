namespace wannaB.Utility.StateManagement
{
public abstract class StateItem
{
    public virtual void OnStateEnter() {}
    public virtual void OnStateTick() {}
    public virtual void OnStateFixedTick() {}
    public virtual void OnStateExit() {}
}
}
