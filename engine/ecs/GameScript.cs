using SailorsTale.engine.gui;
using SailorsTale.engine.interfaces;

namespace SailorsTale.engine.ecs;

public abstract class GameScript : IUpdatable {
    public GameObject GameObject { get; set; } = null!;

    public virtual void OnInit() {}
    public virtual void OnTick() {}
    public virtual void OnUpdate() {}
    public virtual void OnGui(GuiContext ctx) {}
}

public class DisallowMultipleInstancesAttribute : Attribute {}

public class DisallowRemovalAttribute : Attribute {}