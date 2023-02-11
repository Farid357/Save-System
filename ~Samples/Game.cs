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
            
            //You can use class "SaveStorages" to delete all saves
            ISaveStorages saveStorages = new SaveStorages();
            saveStorages.Add(storage);
            
            //Delete all saves
            saveStorages.DeleteAllSaves();
        }
    }
}