using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.Tiled.Renderers;
using MonoGame.Extended.Animations;
using MonoGame.Extended.Content;
using MonoGame.Extended.Sprites;
using MonoGame.Extended.Serialization;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Screens.Transitions;

namespace SAE
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private readonly ScreenManager _screenManager;
        public SpriteBatch _spriteBatch { get; set; }
        
        

        StartScreen startscreen;
        GameScreen gamescreen;
        EndScreen endscreen;

        /*
        //Joueur
        private Vector2 _positionPlayer;
        private AnimatedSprite _player;
        Player playerbase = new Player();

        */

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _screenManager = new ScreenManager();
            Components.Add(_screenManager);
        }
       
        protected override void Initialize()
        {
            /*
            //Joueur

            _positionPlayer = new Vector2(0, 0);
            //
            */

            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();

            

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            

            startscreen = new StartScreen(this); 
            gamescreen = new GameScreen(this); 
            endscreen = new EndScreen(this); 

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
            {
                _screenManager.LoadScreen(startscreen, new FadeTransition(GraphicsDevice,
                Color.White));
            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                _screenManager.LoadScreen(endscreen, new FadeTransition(GraphicsDevice,
                Color.Black));
            }
            else
            {

            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            

            // TODO: Add your drawing code here
            base.Draw(gameTime);
        }
    }
}