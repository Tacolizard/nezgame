using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Nez;
using Nez.Sprites;
namespace nezgame
{
    public class Laser : Component, IUpdatable
    {

        BoxCollider _boxCollider;
        Sprite _sprite;
        Velocity _velocity;


        public override void onAddedToEntity()
        {
            var texture = entity.scene.content.Load<Texture2D>("images/laser");
            _sprite = entity.addComponent(new Sprite(texture));
            _boxCollider = entity.addComponent(new BoxCollider());
            _velocity = entity.addComponent(new Velocity());
            entity.transform.scale = new Vector2(0.2f, 0.2f);
            entity.transform.rotationDegrees = 1;
        }

        void IUpdatable.update()
        {
            
        }
    }
}
