using Content.Server.Objectives.Systems;

namespace Content.Server.Objectives.Components;

/// <summary>
/// Sets the target for <see cref="TargetObjectiveComponent"/> to a random head.
/// If there are no heads it will fallback to any person.
/// </summary>
[RegisterComponent, Access(typeof(StealPersonalityConditionSystem))]
public sealed partial class PickRandomHeadDnaComponent : Component
{
}
