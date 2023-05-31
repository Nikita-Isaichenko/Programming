using Model.Model;
using Newtonsoft.Json;
using ViewModel.ViewModel;

namespace ViewModel.Services
{
    /// <summary>
    /// Хранит логику для автоматического создания объектов.
    /// </summary>
    public class ContactVMFactory
    {
        /// <summary>
        /// Параметры для запроса.
        /// </summary>
        private string _parameters = "FirstName,Phone,Email";

        /// <summary>
        /// Oбъект класса <see cref="DataAPI"/>.
        /// </summary>
        private DataAPI _dataAPI;

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVMFactory"/>.
        /// </summary>
        public ContactVMFactory()
        {
            _dataAPI = new DataAPI(_parameters);
        }

        /// <summary>
        /// Создает объект на основе сгенерированных данных.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public ContactVM MakeContactVM()
        {
            string json = _dataAPI.GetJsonData();

            var contact = JsonConvert.DeserializeObject<Contact>(json);

            var contactVM = new ContactVM(contact);

            return contactVM;
        }
    }
}
