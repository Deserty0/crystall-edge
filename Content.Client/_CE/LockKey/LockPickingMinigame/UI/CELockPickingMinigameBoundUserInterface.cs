using Content.Shared._CE.LockKey.Components;
using Content.Shared._CE.LockKey.LockPickingMinigame;
using JetBrains.Annotations;
using Robust.Client.UserInterface;
using Robust.Shared.Prototypes;

namespace Content.Client._CE.LockKey.LockPickingMinigame.UI;

[UsedImplicitly]
public sealed class CELockPickingMinigameBoundUserInterface : BoundUserInterface
{
    [Dependency] private readonly IPrototypeManager _prototypeManager = default!;

    [ViewVariables]
    private CELockPickingMinigameWindow? _lockpickingWindow;

    public CELockPickingMinigameBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }

    protected override void Open()
    {
        base.Open();

        if (!EntMan.TryGetComponent<CELockPickingMinigameComponent>(Owner, out var minigameComponent))
            return;

        // :3
        if (!EntMan.TryGetComponent<CELockpickComponent>(minigameComponent.Lockpick, out var lockpickComponent))
            return;

        if (!EntMan.TryGetComponent<CELockComponent>(minigameComponent.Lock, out var lockComponent))
            return;

        if (!_prototypeManager.Resolve<CELockPickingMinigamePrototype>(lockComponent.LockPickingMinigameStyle, out var minigamePrototype))
            return;

        _lockpickingWindow = this.CreateWindow<CELockPickingMinigameWindow>();
        _lockpickingWindow.InitVisuals(minigamePrototype, lockpickComponent.MinigameTexture, lockComponent.Shape.Count);
    }

    public override void Update()
    {
        base.Update();

        _lockpickingWindow?.UpdateDraw();
    }
}
