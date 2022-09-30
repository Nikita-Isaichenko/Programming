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
        private Random random = new Random();

        /// <summary>
        /// Экземпляр класса <see cref="HtmlWeb"./>
        /// </summary>
        private HtmlWeb _web = new HtmlWeb();

        /// <summary>
        /// Переменная для сохранения HTML страницы.
        /// </summary>
        private HtmlDocument _htmlDocument;

        /// <summary>
        /// Список для сохранения HTML страниц.
        /// </summary>
        private List<HtmlDocument> _htmlDocuments;

        /// <summary>
        /// Возвращает и задает список имен для товаров.
        /// </summary>
        public List<string> ItemsName { get; }

        /// <summary>
        /// Возвращает и задает список описаний для товаров.
        /// </summary>
        public List<string> ItemsDescription { get; }

        /// <summary>
        /// Возвращает и задает список цен для товаров.
        /// </summary>
        public List<double> ItemsCost { get; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Parser"/>
        /// </summary>
        public Parser()
        {          
            _htmlDocument = _web.Load(_urlMainPages);

            GetHtmlPagesItems();
            ParseItemInfo();
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
        private void ParseItemInfo()
        {
            try
            {
                for (int i = 0; i < _htmlDocuments.Count - 1; i++)
                {
                    ItemsName.Add(_htmlDocuments[i]
                        .DocumentNode
                        .SelectSingleNode("//div[contains(@class, 'product-page__title')]").InnerText);

                    ItemsDescription.Add(_htmlDocuments[i]
                        .DocumentNode
                        .SelectSingleNode("//div[contains(@class, 'product-page__props-value')]").InnerText);

                    ItemsCost.Add(random.Next(7000, 15000));
                }
            }
            catch { }            
        }
    }
}
