public enum ActionType
{
    Move = 0,
    Jump = 1,
    Dash = 2,
    Stop = 3,
    Climb = 4,
    Default = -1
}

[System.Serializable]
public struct EventAction
{
    public Action action;
    public ActionType type;
}
