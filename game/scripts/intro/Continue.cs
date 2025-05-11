using Raylib_CsLo;
using SailorsTale.engine;
using SailorsTale.engine.ecs;
using SailorsTale.engine.gui;
using SailorsTale.game.scenes;
using SailorsTale.utility;
using Color = Raylib_CsLo.Color;
using scripts_Transform = SailorsTale.engine.scripts.Transform;
using Transform = SailorsTale.engine.scripts.Transform;

namespace SailorsTale.game.scripts.intro;

public class Continue : GameScript {

    private readonly string _text;
    private scripts_Transform _transform = null!;
    private Color _textColor = Raylib.RAYWHITE;

    public Continue(string text) {
        _text = text;
    }

    public override void OnInit() {
        _transform = GameObject.Transform;

        Engine.Wait(() => {
            Engine.Transition(t => {
                _textColor = MathUtil.LerpColor(Raylib.RAYWHITE, Raylib.LIGHTGRAY, t);
            }, 2.0f);
        }, 2.0f);
    }

    public override void OnUpdate() {
        if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE)) {
            Engine.SetScene<Seashore>();
        }
    }

    public override void OnGui(GuiContext ctx) {
        ctx.AlignX = Align.Center;
        ctx.AlignY = Align.End;
        ctx.DrawText(_text, _transform.X, _transform.Y, 5, _textColor);
    }
}
