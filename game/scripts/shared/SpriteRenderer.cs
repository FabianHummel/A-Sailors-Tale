using SailorsTale.engine;
using SailorsTale.engine.ecs;
using scripts_Transform = SailorsTale.engine.scripts.Transform;
using Transform = SailorsTale.engine.scripts.Transform;

namespace SailorsTale.game.scripts.shared; 

public class SpriteRenderer : GameScript {

    public string SpriteName { get; set; }

    private scripts_Transform _transform = null!;

    public SpriteRenderer(string spriteName) {
        SpriteName = spriteName;
    }

    public override void OnInit() {
        _transform = GameObject.Transform;
    }

    public override void OnUpdate() {
        Engine.DrawSceneImage(SpriteName, _transform.X, _transform.Y - _transform.Z);
    }
}