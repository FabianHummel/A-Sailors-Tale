using SailorsTale.engine.ecs;

namespace SailorsTale.engine.interfaces;

public interface IInteractable {
    void OnInteract(GameObject interactor);
}