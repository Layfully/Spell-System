using UnityEngine;

namespace AdrianGaborek.SpellSystem
{
    public partial class SpellDatabaseType<D, T> where D : ScriptableObjectDatabase<T> where T : Spell, new()
    {
        [SerializeField] private D _database;
        [SerializeField] private string _databaseName;
        [SerializeField] private string _databasePath = @"Database";
        [SerializeField] public string _itemTypeName = "Item";

        public SpellDatabaseType(string name)
        {
            _databaseName = name;
        }

        public void OnEnable(string typeName)
        {
            _itemTypeName = typeName;

            if (_database == null)
            {
                LoadDatabase();
            }
        }

        public void OnGUI(Vector2 buttonSize, int width)
        {
            ListView(buttonSize, width);
            ItemDetails();
        }
    }
}

