using SailorsTale.engine;
using SailorsTale.engine.ecs;
using SailorsTale.engine.gui;
using SailorsTale.engine.scripts;
using SailorsTale.game.scripts.intro;

namespace SailorsTale.game.scenes; 

public class Intro : Engine.Scene {

    public Intro() : base(
        soundsToRegister: new() {
            { "Seashore Waves", @"assets/sounds/music/seashore-waves.wav" },
            { "Ocean", @"assets/sounds/ambient/ocean.wav" },
        },

        texturesToRegister: new() {
            { "Ocean", @"assets/images/seashore-intro-sea.gif" },
            { "Seaman", @"assets/images/seashore-intro-guy.gif" }
        },
        
        gameObjectsToSpawn: new() {
            { "Intro Title", new GameObject()
                .WithTransform(new Transform(0, 10))
                .AddScript(new Title("~ A Sailor's Tale ~"))
            },

            { "Continue Text", new GameObject()
                .WithTransform(new Transform(0, -10))
                .AddScript(new Continue("Press <Space> to continue..."))
            }
        }
    ) { }

    public override void OnInit() {
        foreach (var s in new[] { "Seashore Waves", "Ocean" }) {
            Engine.PlaySound(s, true);
        }
    }

    public override void OnGui(GuiContext ctx) {
        ctx.AlignX = Align.Center;
        ctx.AlignY = Align.Center;
        ctx.DrawTexture("Ocean", 0, -10);
        ctx.DrawTexture("Seaman", 0, -10);
    }
}
