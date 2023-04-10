using Newtonsoft.Json;
using View.Model;
using View.ViewModel;

namespace View.Services
{
    class ContactVMFactory
    {
        /// <summary>
        /// Параметры для запроса.
        /// </summary>
        private string _parameters = "FirstName,Phone,Email";

        /// <summary>
        /// Oбъект класса <see cref="DataAPI"/>.
        /// </summary>
        private DataAPI _dataAPI;

        public ContactVMFactory()
        {
            _dataAPI = new DataAPI(_parameters);
        }

        public ContactVM MakeContactVM()
        {
            var contact = new Contact();
            string json = _dataAPI.GetJsonData();

            contact = JsonConvert.DeserializeObject<Contact>(json);

            var contactVM = new ContactVM(contact);

            return contactVM;
        }
    }
}
