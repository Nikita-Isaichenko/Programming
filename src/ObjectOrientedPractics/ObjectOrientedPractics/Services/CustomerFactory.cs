using System.IO;
using System.Net;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;


namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для автоматического создания
    /// экземпляров объекта <see cref="Customer"/>
    /// </summary>
    class CustomerFactory
    {
        /// <summary>
        /// Покупатель.
        /// </summary>
        private Customer _customer;
        /// <summary>
        /// Отправка запроса к веб ресурсу.
        /// </summary>
        private HttpWebRequest _request;
            
        /// <summary>
        /// Получение ответа от веб ресурса.
        /// </summary>
        private HttpWebResponse _response;

        /// <summary>
        /// Возвращает и принимает URL адрес.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomerFactory"./>
        /// </summary>
        /// <param name="url">Адрес API.</param>
        public CustomerFactory(string url)
        {
            URL = url;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer",
        /// используя реальные данные о покупателях.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Customer"/> </returns>
        public Customer CreatCustomer()
        {
            _request = (HttpWebRequest)WebRequest.Create(URL);
            _response = (HttpWebResponse)_request.GetResponse();

            using (StreamReader reader = new StreamReader(_response.GetResponseStream()))
            {
                _customer = JsonConvert.DeserializeObject<Customer>(reader.ReadToEnd());
            }

            return _customer;
        }
    }
}
