using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using UserControl = System.Windows.Forms.UserControl;


namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит логику обработки событий окна.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Создает товары с автоматически заполненными данными.
        /// </summary>
        private ItemFactory _itemFactory;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private static List<Item> _items = new List<Item>();

        /// <summary>
        /// Текущий товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Название файла.
        /// </summary>
        private static string _nameFile = "Items";

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();

            _itemFactory = new ItemFactory();

            if (Serializer.IsFile(_nameFile))
            {
                _items = Serializer.LoadFromFile<Item>(_nameFile);

                foreach (var item in _items)
                {
                    ItemsListBox.Items.Add(item.Name);
                }

                ItemsListBox.SelectedIndex = 0;
                CategoryComboBox.SelectedItem = _currentItem.Category;
            }

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }           

            CheckingAvailabilityItems();
        }

        /// <summary>
        /// Обновляет все текстовые поля значениями выбранного товара.
        /// </summary>
        private void UpdateTextBoxes(Item item)
        {           
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name;
            DescriptionTextBox.Text = item.Description;
            IDTextBox.Text = item.Id.ToString();
            CategoryComboBox.SelectedItem = item.Category;
        }

        /// <summary>
        /// Очищает все текстовые поля.
        /// </summary>
        private void ClearTextBoxes()
        {
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            IDTextBox.Clear();
            CategoryComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Проверяет есть ли в списке товары.
        /// Если есть, то делает текстовые поля доступными.
        /// </summary>
        private void CheckingAvailabilityItems()
        {
            if (_items.Count == 0)
            {
                CostTextBox.Enabled = false;
                NameTextBox.Enabled = false;
                DescriptionTextBox.Enabled = false;
                CategoryComboBox.Enabled = false;

                ClearTextBoxes();
            }
            else
            {
                CostTextBox.Enabled = true;
                NameTextBox.Enabled = true;
                DescriptionTextBox.Enabled = true;
                CategoryComboBox.Enabled = true;
            }            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();

            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);

            ItemsListBox.SelectedIndex = _items.Count - 1;

            UpdateTextBoxes(_currentItem);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0) return;

            int index = ItemsListBox.SelectedIndex;          

            ItemsListBox.Items.RemoveAt(index);
            _items.RemoveAt(index);

            ItemsListBox.SelectedIndex = _items.Count > 0 ? 0 : -1;
            
            UpdateTextBoxes(_currentItem);
            CheckingAvailabilityItems();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {           
            _currentItem = _itemFactory.CreatItem();

            _items.Add(_currentItem);
            ItemsListBox.Items.Add(_currentItem.Name);

            ItemsListBox.SelectedIndex = _items.Count - 1;

            UpdateTextBoxes(_currentItem);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {           
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;
            
            _currentItem = _items[index];
           
            UpdateTextBoxes(_currentItem);
            CheckingAvailabilityItems();
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
            }
            catch(Exception ex)
            {
                CostTextBox.BackColor = AppColor.ErrorBackColor;
                CostToolTip.SetToolTip(CostTextBox, ex.Message);

                if (_items.Count == 0)
                    CostTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Name = NameTextBox.Text;
                ItemsListBox.
                    Items[_items.IndexOf(_currentItem)] = _currentItem.Name;
            }
            catch (Exception ex)
            {
                NameTextBox.BackColor = AppColor.ErrorBackColor;
                NameToolTip.SetToolTip(NameTextBox, ex.Message);

                if (_items.Count == 0) 
                    NameTextBox.BackColor = AppColor.NormalBackColor;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionTextBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Description = DescriptionTextBox.Text;
            }
            catch (Exception ex)
            {
                DescriptionTextBox.BackColor = AppColor.ErrorBackColor;
                DescriptionToolTip.SetToolTip(DescriptionTextBox, ex.Message);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategoryComboBox.BackColor = AppColor.NormalBackColor;
                _currentItem.Category = (Category)CategoryComboBox.SelectedIndex;
            }
            catch
            {
                CategoryComboBox.BackColor = AppColor.ErrorBackColor;
            }
        }

        /// <summary>
        /// Сохраняет данные о товарах.
        /// </summary>
        public static void SaveItemsData()
        {
            Serializer.SaveToFile(_nameFile, _items);
        }
    }
}
