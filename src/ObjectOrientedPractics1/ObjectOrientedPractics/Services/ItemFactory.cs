using Newtonsoft.Json;
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
            /// Oбъект класса <see cref="DataAPI"/>.
            /// </summary>
            private DataAPI dataAPI;

            /// <summary>
            /// Параметры для запроса.
            /// </summary>
            private string _parameters = "CarBrand,CarModel,CarYear,CarColor";

            /// <summary>
            /// Создает экземпляр класса <see cref="ItemFactory"/>.
            /// </summary>
            public ItemFactory()
            {
                dataAPI = new DataAPI(_parameters);
            }

            /// <summary>
            /// Создает экземпляр класса <see cref="Item"/>
            /// с автоматически генерированными данными.
            /// </summary>
            /// <returns>Экземпляр класса <see cref="Item"/>.</returns>
            public Item CreatItem()
            {
                _item = JsonConvert.DeserializeObject<Item>(dataAPI.GetJsonData());
                _item.Category = Category.Cars;
                return _item;
            }
        }
}
