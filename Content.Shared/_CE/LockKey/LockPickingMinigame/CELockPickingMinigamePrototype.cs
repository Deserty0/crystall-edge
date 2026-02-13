using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared._CE.LockKey.LockPickingMinigame;

/// <summary>
/// Hey I know I could give more freedom, but it would be too hard and no one would use it
/// </summary>
[Prototype("CELockPickingMinigame")]
public sealed partial class CELockPickingMinigamePrototype : IPrototype
{
    [IdDataField]
    public string ID { get; private set; } = default!;

    /// <summary>
    /// Textures for pin paths
    /// </summary>
    [DataField(required: true)]
    public CELockPickingMinigamePinPaths PinPath;

    /// <summary>
    /// Textures for pins
    /// </summary>
    [DataField(required: true)]
    public CELockPickingMinigamePins Pin;

    /// <summary>
    /// Textures for status indicators
    /// </summary>
    [DataField(required: true)]
    public CELockPickingMinigameStatusIndicator StatusIndicator;

    /// <summary>
    /// Textures for power scale
    /// </summary>
    [DataField(required: true)]
    public CELockPickingMinigamePowerScale PowerScale;
}

/// <summary>
/// Hello insert dimensions here (they are same)
/// </summary>
[DataDefinition]
public partial struct CELockPickingMinigamePinPaths
{
    [DataField(required: true)]
    public ResPath SinglePinPath;

    [DataField(required: true)]
    public ResPath LeftPinPath;

    [DataField(required: true)]
    public ResPath MiddlePinPath;

    [DataField(required: true)]
    public ResPath RightPinPath;
}

/// <summary>
/// Hello insert dimensions here (they are same)
/// </summary>
[DataDefinition]
public partial struct CELockPickingMinigamePins
{
    [DataField(required: true)]
    public ResPath Pin;

    /// <summary>
    /// Please leave here amount of frames
    /// </summary>
    [DataField(required: true)]
    public ResPath PinSuccessAnimation;

    /// <summary>
    /// Pwease leave here amount of frames (and fix so-called-typo :3)
    /// </summary>
    [DataField(required: true)]
    public ResPath PinFailureAnimation;
}

/// <summary>
/// Hey insert dimensions here!
/// </summary>
[DataDefinition]
public partial struct CELockPickingMinigameStatusIndicator
{
    [DataField(required: true)]
    public ResPath Done;

    [DataField(required: true)]
    public ResPath Selected;
}

[DataDefinition]
public partial struct CELockPickingMinigamePowerScale
{
    /// <summary>
    /// Insert required dimensions here
    /// </summary>
    [DataField(required: true)]
    public ResPath PowerScale;

    /// <summary>
    /// Insert required dimensions here
    /// </summary>
    [DataField(required: true)]
    public ResPath PowerIndicator;
}
