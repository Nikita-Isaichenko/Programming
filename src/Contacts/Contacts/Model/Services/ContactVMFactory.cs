using Accessibility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    class ContactFactory
    {     
        /// <summary>
        /// Параметры для запроса.
        /// </summary>
        private string _parameters = "FirstName, Phone, Email";

        /// <summary>
        /// Oбъект класса <see cref="DataAPI"/>.
        /// </summary>
        private DataAPI _dataAPI;

        public ContactFactory()
        {
            _dataAPI = new DataAPI(_parameters);
        }

        public Contact MakeContact()
        {
            var contact = new Contact();
            string json = _dataAPI.GetJsonData();

            contact = JsonConvert.DeserializeObject<Contact>(json);

            return contact;
        }
    }
}
