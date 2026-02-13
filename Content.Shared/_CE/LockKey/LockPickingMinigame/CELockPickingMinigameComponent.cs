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

    /// <summary>
    /// I know that doesnt gonna work
    /// </summary>
    [AutoNetworkedField]
    public Entity<CELockpickComponent> Lockpick;

    /// <summary>
    /// That too
    /// </summary>
    [AutoNetworkedField]
    public Entity<CELockComponent> Lock;
}
