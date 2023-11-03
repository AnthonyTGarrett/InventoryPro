namespace InventoryPro
{
    internal class StorageBin
    {
        private string _name;

        private int[] _values = new int[2];

        public StorageBin(string name, int[] values)
        {
            _name = name;
            _values = values;
        }
    }
}