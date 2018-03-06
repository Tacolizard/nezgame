using Microsoft.Xna.Framework;
using Nez.Sprites;
using Nez;
using System;
using Microsoft.Xna.Framework.Graphics;
namespace nezgame
{
    public class TestScene : DefaultScene
    {

        public override void initialize()
        {
            base.initialize();


            // load a Texture. Note that the Texture is loaded via the scene.content class. This works just like the standard MonoGame Content class
            // with the big difference being that it is tied to a Scene. When the Scene is unloaded so too is all the content loaded via myScene.content.
            var testtex = this.content.Load<Texture2D>("images/Capture");
            var shuttletexture = this.content.Load<Texture2D>("images/shuttle");

            // setup our Scene by adding some Entities
            var shuttle = this.createEntity("shuttle");
            shuttle.addComponent(new Sprite(shuttletexture));
            shuttle.addComponent(new SimpleMover());
            shuttle.addComponent(new BoxCollider());

            var test = this.createEntity("test-thing");
            test.transform.position = new Vector2(500, 500);
            test.addComponent(new Laser());

        }
    }
}
