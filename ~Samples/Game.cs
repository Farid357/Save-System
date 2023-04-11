using SaveSystem;
using SaveSystem.Paths;

namespace Samples
{
    public sealed class Game
    {
        //Example of using the plugin
        public Game()
        {
            ISaveStorage<Money> storage = new BinaryStorage<Money>(new Path(nameof(IWallet)));
            IWallet wallet = new Wallet(storage);
            
            //You can use class "SavesStorage" to delete all saves
            ISavesStorage savesStorage = new SavesStorage();
            //Delete all saves
            savesStorage.DeleteAllSaves();
        }
    }
}