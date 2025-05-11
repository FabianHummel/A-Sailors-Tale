using SailorsTale.engine;
using SailorsTale.engine.ecs;
using SailorsTale.engine.scripts;

namespace SailorsTale.game.scripts.seashore;


public class TestInteraction : Interactable
{
    public override void OnInteract(GameObject interactor)
    {
        Engine.QueueDialogue("Box", "Hello! Let me introduce myself...");
        Engine.QueueDialogue("Box", "Guess what, I am a box!");
        Engine.QueueDialogue("Box", "But not like any other box...");
        Engine.QueueDialogue("Box", "Who are you?", new[] {
            new Engine.DialogueOption("A lonely sailor", () => {
                Engine.QueueDialogue("Box", "We could be friends! Then you wouldn't be so lonely anymore!", new [] {
                    new Engine.DialogueOption("No.", () => {})
                });
            }),
            new Engine.DialogueOption("What is this place?", () => {
                Engine.QueueDialogue("Box", "Oh, this is my home.");
                Engine.QueueDialogue("Box", "I have been here on this spot for several years now.");
                Engine.QueueDialogue("Box", "Sometimes I wish I had legs like everyone else here...", new [] {
                    new Engine.DialogueOption("What makes you feel better?", () => {
                        Engine.QueueDialogue("Box", "We could explore the world together! I could tell you stories about the places we visit while you push me around!");
                        Engine.QueueDialogue("Box", "But remember to put me back here when we're done, okay?", new [] {
                            new Engine.DialogueOption("I'll think about it.", () => {})
                        });
                    }),
                    new Engine.DialogueOption("Sorry, I have to go.", () => {
                        Engine.QueueDialogue("Box", "Goodbye... I hope you come back soon! *sad sniff*");
                    }),
                });
            })
        });
    }
}
