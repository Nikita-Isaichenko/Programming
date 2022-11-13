using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Services
{
    class Parser
    {
        /// <summary>
        /// Адрес главной страницы с вещами.
        /// </summary>
        private string _urlMainPages = @"https://skazkina.com/catalog/vse_tovary/?utm_medium=podpiska_busines&utm_campaign=%7Bcampaign_id%7D&utm_content=%7Bad_id%7D&utm_referer=geoadv_direct&utm_ya_campaign=202581234908&yabizcmpgn=6687248&utm_source=geoadv_direct&utm_candidate=5175123781&utm_content=%7Bad_id%7D&etext=2202.W0ljF19b3y3x0nAV5m--YF09b4dCxrjGUeDyHS_EyBdkbHJ4eGJmbnBybGJvZHdp.5e35d385b6119a2c40d8ad34a0f497e7868344ac&yclid=5748185463864494140";

        /// <summary>
        /// Случайные числа.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Экземпляр класса <see cref="HtmlWeb"./>
        /// </summary>
        private HtmlWeb _web = new HtmlWeb();

        /// <summary>
        /// Cписок имен для товаров.
        /// </summary>
        private List<string> _itemsName = new List<string>();

        /// <summary>
        /// Cписок описаний для товаров.
        /// </summary>
        private List<string> _itemsDescription = new List<string>();

        /// <summary>
        /// список цен для товаров.
        /// </summary>
        private List<double> _itemsCost = new List<double>();

        /// <summary>
        /// Переменная для сохранения HTML страницы.
        /// </summary>
        private HtmlDocument _htmlDocument;

        /// <summary>
        /// Список для сохранения HTML страниц.
        /// </summary>
        private List<HtmlDocument> _htmlDocuments = new List<HtmlDocument>();

        /// <summary>
        /// Возвращает кол-во распарсенных товаров.
        /// </summary>
        public int CountOfParsedItems { get; private set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Parser"/>
        /// </summary>
        public Parser()
        {
            if (Serializer.IsFile(nameof(_itemsDescription)) &&
                Serializer.IsFile(nameof(_itemsCost)) &&
                Serializer.IsFile(nameof(_itemsName)))
            {
                
            }
            else
            {
                _htmlDocument = _web.Load(_urlMainPages);

                GetHtmlPagesItems();
                ParseItemsInfo();
                SerializerItemsInfo();
            }            
        }

        /// <summary>
        /// Парсит основную страницу с товарами, находя для каждого товара свой URL адрес.
        /// Сохраняет HTML страницы каждого товара.
        /// </summary>
        private void GetHtmlPagesItems()
        {
            try
            {
                var nodes = _htmlDocument
                .DocumentNode
                .SelectNodes("//div[contains(@class,'image_wrapper_block js-notice-block__image ')]" +
                "/a[contains(@class,'thumb')]");

                foreach (var node in nodes)
                {
                    HtmlAttribute att = node.Attributes["href"];

                    _htmlDocuments.Add(_web.Load($"https://skazkina.com{att.Value}"));
                }               
            }
            catch { }           
        }

        /// <summary>
        /// Парсит данные о товаре из HTML страницы товара.
        /// </summary>
        private void ParseItemsInfo()
        {
            try
            {
                for (int i = 0; i < _htmlDocuments.Count - 1; i++)
                {
                    _itemsName.Add(_htmlDocuments[i]
                        .DocumentNode
                        .SelectSingleNode("//div[contains(@class, 'product-page__title')]").InnerText);

                    _itemsDescription.Add(_htmlDocuments[i]
                        .DocumentNode
                        .SelectSingleNode("//div[contains(@class, 'product-page__props-value')]").InnerText);

                    _itemsCost.Add(_random.Next(7000, 15000));

                    CountOfParsedItems = _itemsCost.Count;
                }
            }
            catch { }            
        }

        /// <summary>
        /// Возвращает имя для товара.
        /// </summary>
        /// <param name="number">индекс для выбора имени товара.</param>
        /// <returns>Имя товара.</returns>
        public string GetItemName(int number)
        {
            return _itemsName[number];
        }

        /// <summary>
        /// Возвращает описание для товара.
        /// </summary>
        /// <param name="number">индекс для выбора описания товара.</param>
        /// <returns>Описание товара.</returns>
        public string GetItemDescription(int number)
        {
            return _itemsDescription[number];
        }

        /// <summary>
        /// Возвращает цену товара.
        /// </summary>
        /// <param name="number">индекс для выбора цены товара.</param>
        /// <returns>Цена товара.</returns>
        public double GetItemCost(int number)
        {
            return _itemsCost[number];
        }


        /// <summary>
        /// Сериализует списки с информацией о товарах.
        /// </summary>
        private void SerializerItemsInfo()
        {
            Serializer.SaveToFile(nameof(_itemsDescription), _itemsDescription);
            Serializer.SaveToFile(nameof(_itemsCost), _itemsCost);
            Serializer.SaveToFile(nameof(_itemsName), _itemsName);
        }
    }
}
