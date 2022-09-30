using ObjectOrientedPractics.Model;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет метод для создания экземпляра класса <see cref="Item"/>.
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

        /// <summary>
        /// Возвращает доступное кол-во уникальных товаров.
        /// </summary>
        public int MaxCountUniqueItems { get; private set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemFactory"/>.
        /// </summary>
        public ItemFactory()
        {
            _parser = new Parser();
            MaxCountUniqueItems = _parser.CountOfParsedItems;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Item"/>
        /// с автоматически генерированными данными.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Item"/>.</returns>
        public Item CreatItem(int number)
        {
            _item = new Item
            {
                Cost = _parser.GetItemCost(number),
                Name = _parser.GetItemName(number),
                Description = _parser.GetItemDescription(number)
            };           

            return _item;
        }
    }
}
