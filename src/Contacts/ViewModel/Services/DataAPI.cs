using System.IO;
using System.Net;

namespace ViewModel.Services
{
    /// <summary>
    /// Хранит логику для работы с api сайта для генерации данных.
    /// </summary>
    public class DataAPI
    {
        /// <summary>
        /// Путь к сайту.
        /// </summary>
        private string _sitePath = "https://api.randomdatatools.ru/?unescaped=false&params=";

        /// <summary>
        /// Возвращает и задает параметры для запроса к сайту.
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// Объект для отправки запроса к веб ресурсу.
        /// </summary>
        private HttpWebRequest _request;

        /// <summary>
        /// Объект для получения ответа от веб ресурса.
        /// </summary>
        private HttpWebResponse _response;

        /// <summary>
        /// Создает экземпляр класса <see cref="DataAPI"/>
        /// </summary>
        /// <param name="parameters">Поля, которые надо сгенерировать.</param>
        public DataAPI(string parameters)
        {
            Parameters = parameters;
        }

        /// <summary>
        /// Получает данные в json формате.
        /// </summary>
        /// <returns>Данные в виде json.</returns>
        public string GetJsonData()
        {
            string jsonText;

            _request = (HttpWebRequest)WebRequest.Create(_sitePath + Parameters);
            _response = (HttpWebResponse)_request.GetResponse();

            using (StreamReader reader = new StreamReader(_response.GetResponseStream()))
            {
                jsonText = reader.ReadToEnd();
            }

            return jsonText;
        }
    }
}
