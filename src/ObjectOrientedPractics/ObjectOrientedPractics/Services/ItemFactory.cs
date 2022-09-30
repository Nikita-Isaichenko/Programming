using ObjectOrientedPractics.Model;



namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет метод для создания экземпляра класса <see cref="Item"./>
    /// </summary>
    class ItemFactory
    {
        /// <summary>
        /// товар.
        /// </summary>
        private Item _item;

        /// <summary>
        /// Парсер HTML страниц.
        /// </summary>
        private Parser _parser;

        public ItemFactory()
        {
            _parser = new Parser();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// с автоматически генерированными данными.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Item"/>.</returns>
        public Item CreatItem(int number)
        {
            _item.Cost = _parser.ItemsCost[number];
            _item.Name = _parser.ItemsName[number];
            _item.Description = _parser.ItemsDescription[number];

            return _item;
        }       
    }
}
