using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;
namespace nezgame
{
    public class DefaultScene : Scene
    {
        public int width = 1280;
        public int height = 720;

        public override void initialize()
        {
            
        }

        public void createRenderer()
        {
            addRenderer(new DefaultRenderer());
            setDesignResolution(width, height, Scene.SceneResolutionPolicy.None);
            Screen.setSize(width, height);
        }

        //way to create a scene with some vars for init
        public static S createWithArgs<S>(int width, int height) where S : DefaultScene, new()
        {
            var c = new S();
            c.width = width;
            c.height = height;
            c.createRenderer();
            return c;
        }
    }
}
