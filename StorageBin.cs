namespace InventoryPro
{
    internal class StorageBin
    {
        public string Name { get; set; }

        public int[] Values = new int[2];

        public StorageBin(string name, int[] values)
        {
            Name = name;
            Values = values;
        }
    }
}