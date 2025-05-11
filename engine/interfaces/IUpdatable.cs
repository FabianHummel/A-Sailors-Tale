using SailorsTale.engine.gui;

namespace SailorsTale.engine.interfaces;

public interface IUpdatable {
    void OnInit();
    void OnTick();
    void OnUpdate();
    void OnGui(GuiContext ctx);
}