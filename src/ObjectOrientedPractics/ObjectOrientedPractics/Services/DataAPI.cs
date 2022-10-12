using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит методы для работы с api сайта для получения данных.
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
        /// Отправка запроса к веб ресурсу.
        /// </summary>
        private HttpWebRequest _request;

        /// <summary>
        /// Получение ответа от веб ресурса.
        /// </summary>
        private HttpWebResponse _response;

        /// <summary>
        /// Создает экземпляр класса <see cref="DataAPI"/>
        /// </summary>
        /// <param name="parameters"></param>
        public DataAPI(string parameters)
        {
            Parameters = parameters;

            _request = (HttpWebRequest)WebRequest.Create(_sitePath + Parameters);
            _response = (HttpWebResponse)_request.GetResponse();
        }

        public string GetJsonData()
        {
            string jsonText;

            using (StreamReader reader = new StreamReader(_response.GetResponseStream()))
            {
                jsonText = reader.ReadToEnd();
            }

            return jsonText;
        }
    }
}
