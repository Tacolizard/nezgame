using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Nez;
using Nez.Sprites;

namespace nezgame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Core
    {
        public Game1() : base(width: 1280, height: 768, isFullScreen: false, enableEntitySystems: false)
        { }

        protected override void Initialize()
        {
            base.Initialize();
            Window.AllowUserResizing = true;

            // create our Scene with the DefaultRenderer and a clear color of CornflowerBlue
            var myScene = Scene.createWithDefaultRenderer(Color.CornflowerBlue);

            // load a Texture. Note that the Texture is loaded via the scene.content class. This works just like the standard MonoGame Content class
            // with the big difference being that it is tied to a Scene. When the Scene is unloaded so too is all the content loaded via myScene.content.
            var texture = myScene.content.Load<Texture2D>("images/Capture");

            // setup our Scene by adding some Entities
            var entityOne = myScene.createEntity("entity-one");
            entityOne.addComponent(new Sprite(texture));

            var entityTwo = myScene.createEntity("entity-two");
            entityTwo.addComponent(new Sprite(texture));

            // move entityTwo to a new location so it isn't overlapping entityOne
            entityTwo.transform.position = new Vector2(200, 200);

            // set the scene so Nez can take over
            scene = myScene;
        }
        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
