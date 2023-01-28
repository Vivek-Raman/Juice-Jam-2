namespace wannaB.Utility.Exception
{
public class StateNotFoundException : System.Exception
{
    public StateNotFoundException(string stateKey, string stateList) : base(BuildMessage(stateKey, stateList))
    {
    }

    private static string BuildMessage(string stateKey, string stateList)
    {
        return "Failed to locate state " + stateKey + " in state machine, registered states are " +
               stateList.ToString();
    }
}
}
