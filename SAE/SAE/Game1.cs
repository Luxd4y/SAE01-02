using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Sprites;

namespace SAE
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        //Joueur
        private Vector2 _positionPlayer;
        private AnimatedSprite _player;
        Player playerbase = new Player();

        //

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }
       
        protected override void Initialize()
        {
            //Joueur

            _positionPlayer = new Vector2(0, 0);
            //

            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            KeyboardState keyboardState = Keyboard.GetState();
            float deltaSeconds = (float)gameTime.ElapsedGameTime.TotalSeconds; // DeltaTime
            float walkSpeed = deltaSeconds; // Vitesse de déplacement du sprite

            //player bouge
            if (keyboardState.IsKeyDown(Keys.Up))
                _positionPlayer.Y += 1;
            else if (keyboardState.IsKeyDown(Keys.Down))
                _positionPlayer.Y -= 1;
            else if (keyboardState.IsKeyDown(Keys.Left))
                _positionPlayer.X -= 1;
            else if (Keyboard.GetState().IsKeyDown(Keys.Right))
                _positionPlayer.X += 1;


                // TODO: Add your update logic here
                base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}