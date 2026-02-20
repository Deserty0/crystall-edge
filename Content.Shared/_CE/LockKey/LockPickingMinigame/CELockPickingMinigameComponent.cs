using Content.Shared._CE.LockKey.Components;

namespace Content.Shared._CE.LockKey.LockPickingMinigame;

/// <summary>
/// Component for dummy entity that stores minigame data
/// </summary>
[RegisterComponent, AutoGenerateComponentState]
public sealed partial class CELockPickingMinigameComponent : Component
{
    [AutoNetworkedField]
    public bool IsButtonPressed = false;

    [AutoNetworkedField]
    public int Strength = 0;

    [AutoNetworkedField]
    public int Progress = 0;

    [AutoNetworkedField]
    public EntityUid Lockpick;

    [AutoNetworkedField]
    public EntityUid Lock;
}
