using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MonoGame.Framework;

using SecondReality;

namespace SecondReality
{
    /// <summary>
    /// The root page used to display the game.
    /// </summary>
    public sealed partial class GamePage : SwapChainPanel  //Page
    {
        readonly SRController _game;

        public GamePage(string launchArguments)
        {
            this.InitializeComponent();

            //RnD
            // Create the game.
            _game = XamlGame<SRController>.Create
            (
                launchArguments, 
                Window.Current.CoreWindow, 
                this
            );
        }

        public MediaElement TheVideoPlayer
        {
            get
            {
                return VideoPlayer;
            }
        }
    }
}
