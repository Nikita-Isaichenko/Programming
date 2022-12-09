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
        /// Параметры для запроса.
        /// </summary>
        private string _parameters = "FirstName,LastName,FatherName,Country,City,Street,House,Apartment";

        /// <summary>
        /// Oбъект класса <see cref="DataAPI"/>.
        /// </summary>
        private DataAPI dataAPI;

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomerFactory"/>
        /// </summary>
        public CustomerFactory()
        {
            dataAPI = new DataAPI(_parameters);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer",
        /// используя реальные данные о покупателях.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Customer"/> </returns>
        public Customer CreatCustomer()
        {
            string json = dataAPI.GetJsonData();
            _customer = JsonConvert.DeserializeObject<Customer>(json);
            _customer.Address = JsonConvert.DeserializeObject<Address>(json);
            _customer.Discounts.Add(new PointsDiscount());
            
            return _customer;
        }


    }
}
